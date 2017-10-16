using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form_mainForm : Form
    {
        List<Ball> listBalls;
        public Form_mainForm()
        {
            InitializeComponent();
            listBalls = new List<Ball>();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            // stop button 
            timer_ballMovement.Enabled = !timer_ballMovement.Enabled;
            button_start.Text = timer_ballMovement.Enabled ? "Stop" : "Start";
        }

        private void panel_screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_ballMovement_Tick(object sender, EventArgs e)
        {
            foreach (Ball ball in listBalls)
            {
                int ball_sx = ball.Size.Width;
                int ball_sy = ball.Size.Height;
                int ball_px = ball.Location.X;
                int ball_py = ball.Location.Y;
                int ball_nx = ball_px + (int)ball.Vx;
                int ball_ny = ball_py + (int)ball.Vy;
                ball.Location = new Point(ball_nx, ball_ny);

                int paddle_x = panel_paddle.Location.X;
                int paddle_y = panel_paddle.Location.Y;
                int paddle_width = panel_paddle.Width;
                int paddle_height = panel_paddle.Height;

                if (ball_ny + ball_sy > paddle_y &&
                    ball_ny + ball_sy < paddle_y + paddle_height &&
                    ball_nx > paddle_x &&
                    ball_nx < paddle_x + paddle_width)
                {
                    /*double MAXBOUNCEANGLE = 3.14 / 2;
                    double relativeIntersectY = (paddle_x + (paddle_width / 2.0)) - ball_nx;
                    double normalizedRelativeIntersectionY = (relativeIntersectY / (paddle_width / 2.0));
                    double bounceAngle = normalizedRelativeIntersectionY * MAXBOUNCEANGLE;
                    ball.Vx = ball.Vx * -Math.Sin(bounceAngle);
                    ball.Vy = ball.Vy * Math.Cos(bounceAngle);*/
                    ball.Vy *= -1;
                }
                else if (ball_ny > panel_screen.Height - ball_sy || ball_ny < 0)
                {
                    ball.Vy *= -1;
                } else if (ball_nx > panel_screen.Width - ball_sx || ball_nx < 0)
                {
                    ball.Vx *= -1;
                }
            }
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Ball ball = new Ball();
            ball.Image = global::Pong.Properties.Resources.ball;
            ball.Name = "ball_" + listBalls.Count;
            ball.Size = new System.Drawing.Size(48, 48);
            int sx = ball.Size.Width;
            int sy = ball.Size.Height;
            ball.Location = new System.Drawing.Point(
                random.Next(panel_screen.Width - 96) + 48,
                random.Next(panel_screen.Height - 96) + 48
            );
            ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ball.TabIndex = 0;
            ball.TabStop = false;
            ball.Vx = random.NextDouble() * 10 + 0.5;
            ball.Vy = random.NextDouble() * 10 + 0.5;
            panel_screen.Controls.Add(ball);
            listBalls.Add(ball);
        }

        private void panel_screen_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            x = Math.Min(x, panel_screen.Width - panel_paddle.Width);
            int y = panel_paddle.Location.Y;
            panel_paddle.Location = new Point(x, y);
        }
    }
}

