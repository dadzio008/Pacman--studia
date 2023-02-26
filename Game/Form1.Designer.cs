namespace Game
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class GameForm : Form
    {
        public const int WINDOW_WIDTH = 1000;
        public const int WINDOW_HEIGHT = 480;

        private PictureBox gameScreen;
        private Timer timer;
        private Pac pacman;
        private Ghost ghost;

        public GameForm()
        {
            gameScreen = new PictureBox();
            gameScreen.Size = new Size(1000, 480);
            gameScreen.BackColor = Color.Black;
            Controls.Add(gameScreen);
            // Set up the form
            Text = "Pacman";
            ClientSize = new Size(WINDOW_WIDTH, WINDOW_HEIGHT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;

            // Create the game objects
            pacman = new Pac(new PointF(WINDOW_WIDTH / 2, WINDOW_HEIGHT / 2));
            ghost = new Ghost(new PointF(WINDOW_WIDTH / 2, WINDOW_HEIGHT / 2));

            // Set up the timer for the game loop
            timer = new Timer();
            timer.Interval = 16; // 60 FPS
            timer.Tick += new EventHandler(GameLoop);
            timer.Start();
        }



        protected override void OnKeyDown(KeyEventArgs e)
        {
            // Set Pacman's direction based on the arrow keys
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pacman.SetDirection(Direction.Left);
                    break;
                case Keys.Right:
                    pacman.SetDirection(Direction.Right);
                    break;
                case Keys.Up:
                    pacman.SetDirection(Direction.Up);
                    break;
                case Keys.Down:
                    pacman.SetDirection(Direction.Down);
                    break;
            }
        }

        private void GameLoop(object sender, EventArgs e)
        {
            // Update the game objects
            pacman.Update();
            ghost.Update();

            // Check for collisions
            if (pacman.GetBoundingBox().IntersectsWith(ghost.GetBoundingBox()))
            {
                // Pacman is caught by the ghost, end the game or perform some action
                // ...
            }

            // Redraw the form
            Invalidate();
        }
        private void gameStart(KeyEventArgs key)
        {
            if (key.Equals(Keys.Space))
            {

            }
        }

    }
}