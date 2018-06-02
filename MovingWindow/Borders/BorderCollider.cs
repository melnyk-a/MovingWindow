using MovingWindow.Movements;
using System.Drawing;

namespace MovingWindow.Borders
{
    internal sealed class BorderCollider
    {
        private readonly IBorderProvider borderProvider;
        private Point collideLocation;
        private readonly IDirectionManager directionManager;

        public BorderCollider(IBorderProvider borderProvider, DirectionManager directionManager)
        {
            this.borderProvider = borderProvider;
            this.directionManager = directionManager;
        }

        public Point CollideLocation => collideLocation;

        public bool IsCollided(Point point, int width, int height)
        {
            return IsCollidedLeftBorder(point) ||
                IsCollidedRightBorder(point, width) ||
                IsCollidedTopBorder(point) ||
                IsCollidedBottomBorder(point, height);
        }

        private bool IsCollidedBottomBorder(Point point, int height)
        {
            bool isCollided = point.Y + height > borderProvider.Bottom;
            if (isCollided)
            {
                collideLocation = new Point(point.X, borderProvider.Bottom - height);
                directionManager.Direction = Directions.Up;
            }
            return isCollided;
        }

        private bool IsCollidedLeftBorder(Point point)
        {
            bool isCollided = point.X < borderProvider.Left;
            if (isCollided)
            {
                collideLocation = new Point(borderProvider.Left, point.Y);
                directionManager.Direction = Directions.Right;
            }
            return isCollided;
        }

        private bool IsCollidedRightBorder(Point point, int width)
        {
            bool isCollided = point.X + width > borderProvider.Right;
            if (isCollided)
            {
                collideLocation = new Point(borderProvider.Right - width, point.Y);
                directionManager.Direction = Directions.Left;
            }
            return isCollided;
        }

        private bool IsCollidedTopBorder(Point point)
        {
            bool isCollided = point.Y < borderProvider.Top;
            if (isCollided)
            {
                collideLocation = new Point(point.X, borderProvider.Top);
                directionManager.Direction = Directions.Down;
            }
            return isCollided;
        }
    }
}