using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Ghost
    {
        private const int SPEED = 3;
        private const int SIZE = 40;
        private Image image;

        private PointF position;
        private float speed;
        private Direction direction;
        private SizeF size;

        public Ghost(PointF startPosition)
        {
            speed = 2f;
            position = startPosition;
            direction = Direction.Right;
            size = new SizeF(32, 32);
            image = Properties.Resources.pink_guy;
        }

        public void Update()
        {
            // Move in current direction
            switch (direction)
            {
                case Direction.Left:
                    position.X -= SPEED;
                    break;
                case Direction.Right:
                    position.X += SPEED;
                    break;
                case Direction.Up:
                    position.Y -= SPEED;
                    break;
                case Direction.Down:
                    position.Y += SPEED;
                    break;
            }
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Red);
            g.FillEllipse(brush, position.X - SIZE / 2, position.Y - SIZE / 2, SIZE, SIZE);
        }

        public bool CollidesWith(Pac pacman)
        {
            // Check if Pacman's position is within ghost's bounding box
            RectangleF ghostBoundingBox = new RectangleF(position.X - SIZE / 2, position.Y - SIZE / 2, SIZE, SIZE);
            return ghostBoundingBox.IntersectsWith(pacman.GetBoundingBox());
        }
        public RectangleF GetBoundingBox()
        {
            // Return a rectangle that represents the ghost's bounding box
            return new RectangleF(position.X - size.Width / 2, position.Y - size.Height / 2, size.Width, size.Height);
        }
    }
}
