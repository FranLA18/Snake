using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(Snake_Move);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Snake_Move(object sender, KeyEventArgs e)
        {
            
            // HOLA ACA ESTUVO FACU
            int numeroContador = Convert.ToInt32(lblContador.Text);

            if (e.KeyCode == Keys.A)
            {
                // Move right

                lblSnakeHead.Location = new Point(lblSnakeHead.Location.X - 10, lblSnakeHead.Location.Y);
                lblSnakeHead.Text = "<";

                if(lblSnakeHead.Bounds.IntersectsWith(pbApple.Bounds))
                {
                    numeroContador += 1;
                    lblContador.Text = numeroContador.ToString();
                    pbApple.Location = new Point(new Random().Next(0, this.ClientSize.Width - pbApple.Width), new Random().Next(0, this.ClientSize.Height - pbApple.Height));
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                // Move left

                lblSnakeHead.Location = new Point(lblSnakeHead.Location.X + 10, lblSnakeHead.Location.Y);
                lblSnakeHead.Text = ">";

                if (lblSnakeHead.Bounds.IntersectsWith(pbApple.Bounds))
                {
                    numeroContador += 1;
                    lblContador.Text = numeroContador.ToString();
                    pbApple.Location = new Point(new Random().Next(0, this.ClientSize.Width - pbApple.Width), new Random().Next(0, this.ClientSize.Height - pbApple.Height));
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                // Move up

                lblSnakeHead.Location = new Point(lblSnakeHead.Location.X, lblSnakeHead.Location.Y - 10);
                lblSnakeHead.Text = "^";

                if (lblSnakeHead.Bounds.IntersectsWith(pbApple.Bounds))
                {
                    numeroContador += 1;
                    lblContador.Text = numeroContador.ToString();
                    pbApple.Location = new Point(new Random().Next(0, this.ClientSize.Width - pbApple.Width), new Random().Next(0, this.ClientSize.Height - pbApple.Height));
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                // Move down

                lblSnakeHead.Location = new Point(lblSnakeHead.Location.X, lblSnakeHead.Location.Y + 10);
                lblSnakeHead.Text = "v";

                if (lblSnakeHead.Bounds.IntersectsWith(pbApple.Bounds))
                {
                    numeroContador += 1;
                    lblContador.Text = numeroContador.ToString();
                    pbApple.Location = new Point(new Random().Next(0, this.ClientSize.Width - pbApple.Width), new Random().Next(0, this.ClientSize.Height - pbApple.Height));
                }
            }


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblContador_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
