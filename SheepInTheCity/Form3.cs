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
    public partial class FormHowToPlay : Form
    {
        public FormHowToPlay()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStartingWindow formStartingWindow = new FormStartingWindow();
            formStartingWindow.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void FormHowToPlay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
