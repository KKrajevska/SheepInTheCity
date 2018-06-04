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
    public partial class Form4 : Form
    {
        private Form2 form2;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Show();
        }

        private void btnOld_Click(object sender, EventArgs e)
        {

        }
    }
}
