using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheepInTheCity
{
    public partial class FormGame : Form
    {
        bool isPaused;
        private int time = 60;
        private FormWinner formWinner;
        private FormLoser formLoser;
        PictureBox sheepAtTheEnd = new PictureBox();
        Point startingPoint = new Point();
        Size originalSize = new Size();
        int countSheep;
        int countLives;

        public FormGame()
        {
            KeyDown += new KeyEventHandler(Form2_KeyDown);
            InitializeComponent();
            sheepAtTheEnd.Image = Properties.Resources.sheepinthegame;
            startingPoint = pbSheep.Location;
            originalSize = pbSheep.Size;
            countLives = 3;
            countSheep = 0;
            isPaused = false;
            
        }
      
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            int X = pbSheep.Location.X;
            int Y = pbSheep.Location.Y;
            int step = 18;
            if (e.KeyCode == Keys.Right)
            {
                if (pbSheep.Location.X <= 377)
                {
                    X += step;
                }

            }
            else if (e.KeyCode == Keys.Left)
            {
                if (pbSheep.Location.X >= 15)
                {
                    X -= step;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (pbSheep.Location.Y >= 24)
                {
                    Y -= step;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                if (pbSheep.Location.Y <= 460)
                {
                    Y += step;
                }
            }

            pbSheep.Location = new Point(X, Y);
            if (pbSheep.Location.Y <= 24)
            {
                if (IsTouching(pbSheep, pbEnd1))
                {
                    countSheep++;
                    pbEnd1.BackgroundImage = sheepAtTheEnd.Image;
                    pbSheep.Location = startingPoint;
                }
                else if (IsTouching(pbSheep, pbEnd2))
                {
                    countSheep++;
                    pbEnd2.BackgroundImage = sheepAtTheEnd.Image;
                    pbSheep.Location = startingPoint;
                }
                else if (IsTouching(pbSheep, pbEnd3))
                {
                    countSheep++;
                    pbEnd3.BackgroundImage = sheepAtTheEnd.Image;
                    pbSheep.Location = startingPoint;
                }
                else if (IsTouching(pbSheep, pbEnd4))
                {
                    countSheep++;
                    pbEnd4.BackgroundImage = sheepAtTheEnd.Image;
                    pbSheep.Location = startingPoint;
                }
                else if (IsTouching(pbSheep, pbEnd5))
                {
                    countSheep++;
                    pbEnd5.BackgroundImage = sheepAtTheEnd.Image;
                    pbSheep.Location = startingPoint;
                }
                else
                {
                    livesDecrement();
                }

            }

        }

        private bool IsTouching(PictureBox pbSheep, PictureBox pb)
        {
            if (pbSheep.Bounds.IntersectsWith(pb.Bounds))
                return true;
            else return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {

                if (pbGreenCar.Location.X + pbGreenCar.Size.Width >= 500)
                {
                    pbGreenCar.Location = new Point(-10, pbGreenCar.Location.Y);
                }
                else pbGreenCar.Location = new Point(pbGreenCar.Location.X + 5, pbGreenCar.Location.Y);
                if (pbYellowCar.Location.X + pbYellowCar.Size.Width <= 10)
                {
                    pbYellowCar.Location = new Point(500, pbYellowCar.Location.Y);
                }
                else pbYellowCar.Location = new Point(pbYellowCar.Location.X - 10, pbYellowCar.Location.Y);
                if (pbRedCar2.Location.X + pbRedCar2.Size.Width <= 10)
                {
                    pbRedCar2.Location = new Point(500, pbRedCar2.Location.Y);
                }
                else pbRedCar2.Location = new Point(pbRedCar2.Location.X - 10, pbRedCar2.Location.Y);
                if (IsTouching(pbSheep, pbGreenCar) || IsTouching(pbSheep, pbYellowCar) || IsTouching(pbSheep, pbRedCar2))
                {
                    livesDecrement();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                if (pbRedCar.Location.X + pbRedCar.Size.Width >= 500)
                {
                    pbRedCar.Location = new Point(-10, pbRedCar.Location.Y);
                }
                else pbRedCar.Location = new Point(pbRedCar.Location.X + 5, pbRedCar.Location.Y);
                if (pbWhiteCar.Location.X + pbWhiteCar.Size.Width >= 500)
                {
                    pbWhiteCar.Location = new Point(-10, pbWhiteCar.Location.Y);
                }
                else pbWhiteCar.Location = new Point(pbWhiteCar.Location.X + 5, pbWhiteCar.Location.Y);
                if (pbGreyCar.Location.X + pbGreyCar.Size.Width <= 10)
                {
                    pbGreyCar.Location = new Point(500, pbGreyCar.Location.Y);
                }
                else pbGreyCar.Location = new Point(pbGreyCar.Location.X - 10, pbGreyCar.Location.Y);
                if (pbTrain2.Location.X + pbTrain2.Size.Width <= 10)
                {
                    pbTrain2.Location = new Point(500, pbTrain2.Location.Y);
                }
                else pbTrain2.Location = new Point(pbTrain2.Location.X - 5, pbTrain2.Location.Y);
                if (IsTouching(pbSheep, pbRedCar) || IsTouching(pbSheep, pbGreyCar) || IsTouching(pbSheep, pbTrain2) || IsTouching(pbSheep, pbWhiteCar))
                {
                    livesDecrement();

                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                if (pbTrain1.Location.X + pbTrain1.Size.Width >= 500)
                {
                    pbTrain1.Location = new Point(-10, pbTrain1.Location.Y);
                }
                else pbTrain1.Location = new Point(pbTrain1.Location.X + 5, pbTrain1.Location.Y);
                if (pbTree1.Location.X + pbTree1.Size.Width >= 500)
                {
                    pbTree1.Location = new Point(-10, pbTree1.Location.Y);
                }
                else pbTree1.Location = new Point(pbTree1.Location.X + 5, pbTree1.Location.Y);
                if (pbTree2.Location.X + pbTree2.Size.Width <= 10)
                {
                    pbTree2.Location = new Point(500, pbTree2.Location.Y);
                }
                else pbTree2.Location = new Point(pbTree2.Location.X - 5, pbTree2.Location.Y);
                if (pbTree3.Location.X + pbTree3.Size.Width >= 500)
                {
                    pbTree3.Location = new Point(-10, pbTree3.Location.Y);
                }
                else pbTree3.Location = new Point(pbTree3.Location.X + 5, pbTree3.Location.Y);
                if (IsTouching(pbSheep, pbTrain1))
                {
                    livesDecrement();

                }
                if (pbSheep.Location.Y >= 29 && pbSheep.Location.Y <= 131)
                {
                    if (IsTouching(pbSheep, pbTree1))
                    {
                        pbSheep.Location = new Point(pbSheep.Location.X + 5, pbSheep.Location.Y);
                    }
                    else if (IsTouching(pbSheep, pbTree2))
                    {
                        pbSheep.Location = new Point(pbSheep.Location.X - 5, pbSheep.Location.Y);
                    }
                    else if (IsTouching(pbSheep, pbTree3))
                    {
                        pbSheep.Location = new Point(pbSheep.Location.X + 5, pbSheep.Location.Y);
                    }
                    else
                    {
                        livesDecrement();
                    }
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                time--;
                lblTime.Text = string.Format("Time: {0}", time.ToString());
                if (time == 0)
                {
                    timer4.Stop();
                    this.Hide();
                    formLoser = new FormLoser();
                    formLoser.Show();
                }
                if (countSheep == 5)
                {
                    timer4.Stop();
                    this.Hide();
                    formWinner = new FormWinner();
                    formWinner.label1.Text = string.Format("Your score is: {0}", time.ToString());
                    formWinner.Show();

                }
            }
        }
        private void livesDecrement()
        {

            if (countLives == 1)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                this.Hide();
                formLoser = new FormLoser();
                formLoser.Show();
            }
            else
            {
                countLives--;
                lblLivesCount.Text = countLives.ToString();
                pbSheep.Location = startingPoint;

            }
        }
    

        private void FormGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isPaused == false)
            {
                if (e.KeyChar == 'p' || e.KeyChar == 'P')
                {
                    isPaused = true;
                }
            }
            else isPaused = false;
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }  
}
