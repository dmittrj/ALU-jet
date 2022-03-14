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
    public partial class ALU_Main : Form
    {
        readonly string[] Main_ProjectTypesDescriptions =
        {
            "Проект ALU-1 — восьмиразрядного двоичного АЛУ,\nс которым взаимодействует управляющий автомат"
        };
        public ALU_Main()
        {
            InitializeComponent();
        }

        private void Main_ProjectTypes_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main_Description_Label.Text = Main_ProjectTypesDescriptions[Main_ProjectTypes_LB.SelectedIndex];
        }

        [STAThread]
        private void Main_CreateProject_Button_Click(object sender, EventArgs e)
        {
            ALU1 alu1 = new();
            alu1.Show();
            this.Hide();
        }
    }
}
