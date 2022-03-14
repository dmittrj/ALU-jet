using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALU_jet
{
    public partial class ALU1 : Form
    {
        public ALU1()
        {
            InitializeComponent();
        }

        private void ALU1_Load(object sender, EventArgs e)
        {

        }

        private void ALU1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.main.Show();
        }
    }
}
