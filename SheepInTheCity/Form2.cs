using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheepInTheCity
{

    public partial class Form2 : Form
    {

        private Form5 form5;
        public Form2()
        {
            KeyDown += new KeyEventHandler(Form2_KeyDown);
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int X = pictureBox1.Location.X;
            int Y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Right)
            {
                if (pictureBox1.Location.X <= 377) {
                    X += 5;
                }
               
            }
            else if (e.KeyCode == Keys.Left) 
            {
                if (pictureBox1.Location.X >= 15)
                {
                    X -= 5;
                }
            }
            else if (e.KeyCode == Keys.Up) 
            {
                if(pictureBox1.Location.Y>=2)
                {
                    Y -= 5;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (pictureBox1.Location.Y <=414)
                {
                    Y+= 5;
                }
            }
            
            pictureBox1.Location = new Point(X, Y);
            if(IsTouching(pictureBox1,pictureBox2))
            {
                form5 = new Form5();
                form5.Show();
            }
        }
        private bool IsTouching(PictureBox p1, PictureBox p2)
        {
            if (p1.Location.X + p1.Width < p2.Location.X)
                return false;
            if (p2.Location.X + p2.Width < p1.Location.X)
                return false;
            if (p1.Location.Y + p1.Height < p2.Location.Y)
                return false;
            if (p2.Location.Y + p2.Height < p1.Location.Y)
                return false;
            return true;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
