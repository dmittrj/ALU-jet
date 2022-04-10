using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALU_jet
{
    public partial class ALU_Main : Form
    {
        string[] ALU_Files;
        public static string CurrentProject = "";

        readonly string[] Main_ProjectTypesDescriptions =
        {
            "Проект ALU-1 — восьмиразрядного двоичного АЛУ,\nс которым взаимодействует управляющий автомат",
            "Проект ALU-R — восьмиразрядного двоичного АЛУ\nс двухпортовым регистровым СОЗУ"
        };
        readonly string[] Main_ProjectExtensions =
        {
            ".alu1",
            ".alur"
        };
        public ALU_Main()
        {
            InitializeComponent();
        }

        private void Main_ProjectTypes_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Main_Description_Label.Text = Main_ProjectTypesDescriptions[Main_ProjectTypes_LB.SelectedIndex];
            Main_ProjectExtension_Label.Text = Main_ProjectExtensions[Main_ProjectTypes_LB.SelectedIndex];
            Main_CreateProject_Button.Enabled = true;
        }

        [STAThread]
        private void Main_CreateProject_Button_Click(object sender, EventArgs e)
        {
            FileStream fs = new(Main_ProjectName_TB.Text +
                Main_ProjectExtensions[Main_ProjectTypes_LB.SelectedIndex], FileMode.Create);
            fs.Close();
            CurrentProject = fs.Name;
            ALU1 alu1 = new();
            alu1.Show();
            this.Hide();
        }

        private void ALU_Main_Load(object sender, EventArgs e)
        {
            ALU_Files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (string p_file in ALU_Files)
            {
                FileInfo info = new(p_file);
                if (info.Extension == ".alu1" || info.Extension == ".alur")
                {
                    Main_Projects_LB.Items.Add(info.Name);
                }
            }
        }

        private void Main_Projects_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo info = new(Directory.GetCurrentDirectory() + "\\" + Main_Projects_LB.Items[Main_Projects_LB.SelectedIndex].ToString());
            if (info.Extension == ".alu1")
            {
                CurrentProject = info.FullName;
                ALU1 alu1 = new();
                alu1.Show();
                this.Hide();
            }
        }
    }
}
