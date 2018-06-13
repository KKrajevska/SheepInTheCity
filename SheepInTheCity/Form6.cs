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
    public partial class FormLoser : Form
    {
        public FormLoser()
        {
            InitializeComponent();
        }

        private void btnLoseExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoseNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormGame formGame = new FormGame();
            formGame.Show();
        }
    }
}
