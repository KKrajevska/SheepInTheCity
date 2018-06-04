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
        private int time = 0;
        private Form5 form5;
        private Form6 form6;
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
            if (p1.Location==p2.Location)
                return true;
            else return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbGreenCar.Location.X + pbGreenCar.Size.Width >= 400)
            {
                pbGreenCar.Location = new Point(12, pbGreenCar.Location.Y);
            }
            else pbGreenCar.Location = new Point(pbGreenCar.Location.X + 5, pbGreenCar.Location.Y);
            if (pbYellowCar.Location.X + pbYellowCar.Size.Width <= 60)
            {
                pbYellowCar.Location = new Point(369, pbYellowCar.Location.Y);
            }
            else pbYellowCar.Location = new Point(pbYellowCar.Location.X - 5, pbYellowCar.Location.Y);
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pbRedCar.Location.X + pbRedCar.Size.Width >= 400)
            {
                pbRedCar.Location = new Point(12, pbRedCar.Location.Y);
            }
            else pbRedCar.Location = new Point(pbRedCar.Location.X + 5, pbRedCar.Location.Y);
            if (pbGreyCar.Location.X + pbGreyCar.Size.Width <= 60)
            {
                pbGreyCar.Location = new Point(369, pbGreyCar.Location.Y);
            }
            else pbGreyCar.Location = new Point(pbGreyCar.Location.X - 5, pbGreyCar.Location.Y);
            if (pbTrain2.Location.X + pbTrain2.Size.Width <= 60)
            {
                pbTrain2.Location = new Point(369, pbTrain2.Location.Y);
            }
            else pbTrain2.Location = new Point(pbTrain2.Location.X - 5, pbTrain2.Location.Y);

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pbTrain1.Location.X + pbTrain1.Size.Width >= 500)
            {
                pbTrain1.Location = new Point(0, pbTrain1.Location.Y);
            }
            else pbTrain1.Location = new Point(pbTrain1.Location.X + 5, pbTrain1.Location.Y);
            if (pbTree1.Location.X + pbTree1.Size.Width >= 500)
            {
                pbTree1.Location = new Point(0, pbTree1.Location.Y);
            }
            else pbTree1.Location = new Point(pbTree1.Location.X + 5, pbTree1.Location.Y);
            if (pbTree2.Location.X + pbTree2.Size.Width <= 60)
            {
                pbTree2.Location = new Point(369, pbTree2.Location.Y);
            }
            else pbTree2.Location = new Point(pbTree2.Location.X - 5, pbTree2.Location.Y);
            if (pbTree3.Location.X + pbTree3.Size.Width >= 500)
            {
                pbTree3.Location = new Point(0, pbTree3.Location.Y);
            }
            else pbTree3.Location = new Point(pbTree3.Location.X + 5, pbTree3.Location.Y);

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            time++;
            toolStripStatusLabel1.Text = string.Format("Time: {0}", time);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
