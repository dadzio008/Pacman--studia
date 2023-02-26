using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Properties;

namespace Game
{

    public class Pac : PictureBox
    {
        private const int SIZE = 10;

        private PointF position;
        private Direction direction;

        public Pac(PointF startPosition)
        {
            position = startPosition;
            direction = Direction.None;
        }

        public void Update()
        {
            // Move in current direction
            switch (direction)
            {
                case Direction.Left:
                    position.X -= SIZE;
                    break;
                case Direction.Right:
                    position.X += SIZE;
                    break;
                case Direction.Up:
                    position.Y -= SIZE;
                    break;
                case Direction.Down:
                    position.Y += SIZE;
                    break;
            }
        }

        public void Draw(Graphics g)
        {
            var bmp = new Bitmap(Properties.Resources.pac_man);
            g.DrawImage(bmp, position);
        }

        public RectangleF GetBoundingBox()
        {
            // Get Pacman's bounding box for collision detection
            return new RectangleF(position.X - SIZE / 2, position.Y - SIZE / 2, SIZE, SIZE);
        }

        public void SetDirection(Direction newDirection)
        {
            // Set Pacman's new direction if it's valid
            if (CanMoveInDirection(newDirection))
            {
                direction = newDirection;
            }
        }

        private bool CanMoveInDirection(Direction newDirection)
        {
            // Check if Pacman can move in the new direction without colliding with the walls
            // (Replace this with your own collision detection logic)
            switch (newDirection)
            {
                case Direction.Left:
                    return position.X > 0;
                case Direction.Right:
                    return position.X < GameForm.WINDOW_WIDTH;
                case Direction.Up:
                    return position.Y > 0;
                case Direction.Down:
                    return position.Y < GameForm.WINDOW_HEIGHT;
                default:
                    return false;
            }
        }
    }
}
