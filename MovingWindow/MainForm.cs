using MovingWindow.Borders;
using MovingWindow.Commands;
using MovingWindow.Movements;
using MovingWindow.Timers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MovingWindow
{
    public partial class MainForm : Form
    {
        private const int movingStep = 6;
        private readonly ICommandProvider commandProvider;
        private readonly BorderCollider borderCollider;
        private readonly IBorderProvider borderProvider = new BorderProvider();
        private readonly IDirectionProvider directionProvider;
        private readonly ITimerProvider timerProvider = new TimerProvider();

        public MainForm()
        {
            InitializeComponent();

            DirectionManager directionManager = new DirectionManager();
            directionProvider = directionManager;
            commandProvider = new CommandProvider(directionManager, timerProvider, this);
            borderCollider = new BorderCollider(borderProvider, directionManager);

            timerProvider.Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Location = new Point(
                Location.X + directionProvider.Direction.OffsetX * movingStep,
                Location.Y + directionProvider.Direction.OffsetY * movingStep
            );
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (Command command in commandProvider.Commands)
            {
                if (command.CanExecute(e.KeyCode))
                {
                    command.Execute();
                }
            }
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (borderCollider.IsCollided(Location, Width, Height))
            {
                Location = borderCollider.CollideLocation;
            }
        }
    }
}