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
        public Form2()
        {
            KeyDown += new KeyEventHandler(Form2_KeyDown);
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int X = pictureBox1.Location.X;
            int Y = pictureBox1.Location.Y;
            if (e.KeyCode == Keys.Right) X += 5;
            else if (e.KeyCode == Keys.Left) X -= 5;
            else if (e.KeyCode == Keys.Up) Y -= 5;
            else if (e.KeyCode == Keys.Down) Y += 5;
            pictureBox1.Location = new Point(X, Y);
        }
    }
}
