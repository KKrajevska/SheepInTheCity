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
    public partial class FormStartingWindow : Form
    {
  
        private FormHowToPlay formHowToPlay;
        private FormPlay formPlay;
        public FormStartingWindow()
        {
            InitializeComponent();
        }

        private void btnHow_Click(object sender, EventArgs e)
        {
            this.Hide();
            formHowToPlay = new FormHowToPlay();
            formHowToPlay.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            formPlay = new FormPlay();
            formPlay.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnScores_Click(object sender, EventArgs e)
        {

        }
    }
}
