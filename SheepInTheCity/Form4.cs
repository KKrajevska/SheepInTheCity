using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheepInTheCity
{
    public partial class FormPlay : Form
    {
        private FormGame formGame;
        public FormPlay()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            formGame = new FormGame();
            formGame.Show();
        }

        private void btnOld_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStartingWindow formStartingWindow = new FormStartingWindow();
            formStartingWindow.Show();
        }

        private void FormPlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
