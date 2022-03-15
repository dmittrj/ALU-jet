using System;
using System.Collections;
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
        Hashtable commands = new Hashtable();
        int Shina = 0;
        string Ax = "00000000";
        string Bx = "00000000";

        public ALU1()
        {
            InitializeComponent();
        }

        private void ALU1_Load(object sender, EventArgs e)
        {
            commands["y0"] = "Шина := Ax";
            commands["y1"] = "Шина := Bx";
            commands["y2"] = "A := Шина";
            commands["y3"] = "B := Шина";
            commands["y4"] = "R := A";
            commands["y5"] = "R := ~A";
            commands["y6"] = "S := B";
            commands["y7"] = "S := ~B";
            commands["y8"] = "Q := R + S + p0";
            commands["y9"] = "Q := R - S - p0";
            commands["y10"] = "Q := S - R - p0";
            commands["y11"] = "Q := S & R";
            commands["y12"] = "Q := S v R";
            commands["y13"] = "Q := S (+) R";
            commands["y14"] = "p0 := 0";
            commands["y15"] = "p0 := 1";
            commands["y16"] = "F := Q";
            commands["y17"] = "F := DL >> Q >> DR";
            commands["y18"] = "F := DL << Q << DR";
            commands["y19"] = "F := DR >> Q >> DR";
            commands["y20"] = "F := << Q << Z";
            commands["y21"] = "Стоп";
            commands["y22"] = "Счетчик := 0";
            commands["y23"] = "Счетчик += 1";
            commands["y24"] = "С := F";
            commands["y25"] = "D := F";
            commands["y26"] = "Шина := C";
            commands["y27"] = "Шина := D";
            commands["y28"] = "DL := 0";
            commands["y29"] = "DL := 1";
            commands["y30"] = "DR := 0";
            commands["y31"] = "DR := 1";
            commands["y32"] = "Q := R";
        }

        private void ALU1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.main.Show();
        }

        private void ALU1_Microprogram_RTB_TextChanged(object sender, EventArgs e)
        {
            ALU1_Temp_RTB.ForeColor = Color.Black;
            ALU1_SyntaxHighlight_Timer.Start();
            //ALU1_Microprogram_RTB.Se
        }

        private void ALU1_SyntaxHighlight_Timer_Tick(object sender, EventArgs e)
        {
            int s = ALU1_Microprogram_RTB.SelectionStart;
            int d = ALU1_Microprogram_RTB.SelectionLength;
            ALU1_Temp_RTB.Text = ALU1_Microprogram_RTB.Text;
            for (int i = 0; i < ALU1_Temp_RTB.Text.Length; i++)
            {
                ALU1_Temp_RTB.Select(i, 1);
                ALU1_Temp_RTB.SelectionColor = Color.Black;
                if (ALU1_Temp_RTB.SelectedText == ":")
                {
                    while (i > 0)
                    {
                        ALU1_Temp_RTB.Select(--i, 1);
                        if (ALU1_Temp_RTB.SelectedText == " " ||
                            ALU1_Temp_RTB.SelectedText == "\n")
                            break;
                    }
                    ALU1_Temp_RTB.Select(i, 1);
                    do
                    {
                        ALU1_Temp_RTB.Select(i++, 1);
                        ALU1_Temp_RTB.SelectionColor = Color.SaddleBrown;
                    } while (ALU1_Temp_RTB.SelectedText != ":");
                    i--;
                    continue;
                }
                if (ALU1_Temp_RTB.SelectedText == "y")
                {
                    ALU1_Temp_RTB.Select(++i, 1);
                    if (ALU1_Temp_RTB.SelectedText == "2")
                    {
                        ALU1_Temp_RTB.Select(++i, 1);
                        if (ALU1_Temp_RTB.SelectedText == "1")
                        {
                            i -= 2;
                            ALU1_Temp_RTB.Select(i, 3);
                            ALU1_Temp_RTB.SelectionColor = Color.Firebrick;
                            i += 2;
                            continue;
                        }
                        else i -= 2;
                    }
                    else i--;
                }
                ALU1_Temp_RTB.Select(i, 1);
                if (ALU1_Temp_RTB.SelectedText == ";")
                {
                    do
                    {
                        ALU1_Temp_RTB.Select(++i, 1);
                        ALU1_Temp_RTB.SelectionColor = Color.Teal;
                    } while (ALU1_Temp_RTB.SelectedText != "\n" &&
                    i < ALU1_Temp_RTB.Text.Length);
                }
                if (ALU1_Temp_RTB.SelectedText == "#")
                {
                    ALU1_Temp_RTB.SelectionColor = Color.DarkGray;
                    do
                    {
                        ALU1_Temp_RTB.Select(++i, 1);
                        ALU1_Temp_RTB.SelectionColor = Color.DarkGray;
                    } while (ALU1_Temp_RTB.SelectedText != "\n" &&
                    i < ALU1_Temp_RTB.Text.Length);
                }
            }
            ALU1_Microprogram_RTB.Text = ALU1_Temp_RTB.Text;
            ALU1_Microprogram_RTB.Rtf = ALU1_Temp_RTB.Rtf;
            ALU1_Microprogram_RTB.Select(s, d);
            ALU1_SyntaxHighlight_Timer.Stop();
        }

        private void ALU1_Cut_CMI_Click(object sender, EventArgs e)
        {
            ALU1_Microprogram_RTB.Cut();
        }

        private void ALU1_Copy_CMI_Click(object sender, EventArgs e)
        {
            ALU1_Microprogram_RTB.Copy();
        }

        private void ALU1_Paste_CMI_Click(object sender, EventArgs e)
        {
            ALU1_Microprogram_RTB.Paste();
        }

        private void ALU1_Micro_CMS_Opening(object sender, CancelEventArgs e)
        {
            int s = ALU1_Microprogram_RTB.SelectionStart;
            int l = 1;
            ALU1_Temp_RTB.Select(s, l);
            if (ALU1_Temp_RTB.SelectedText == " ")
            {
                ALU1_Description_CMI.Visible = false;
                ALU1_Description_CMSep.Visible = false;
            } else
            {
                do
                {
                    if (--s < 0) break;
                    ALU1_Temp_RTB.Select(s, ++l);
                }
                while ((ALU1_Temp_RTB.SelectedText[0] != ' ' &&
                ALU1_Temp_RTB.SelectedText[0] != '\n' &&
                ALU1_Temp_RTB.SelectedText[0] != ':') &&
                s >= 0);
                s++;
                ALU1_Temp_RTB.Select(s, l);
                while ((ALU1_Temp_RTB.SelectedText[^1] != ' ' &&
                ALU1_Temp_RTB.SelectedText[^1] != '\n' &&
                ALU1_Temp_RTB.SelectedText[^1] != ',' &&
                ALU1_Temp_RTB.SelectedText[^1] != ';') &&
                s + l <= ALU1_Temp_RTB.Text.Length)
                {
                    ALU1_Temp_RTB.Select(s, ++l);
                }
                l--;
                ALU1_Temp_RTB.Select(s, l);
                if (commands.ContainsKey(ALU1_Temp_RTB.SelectedText)) {
                    ALU1_Description_CMI.Text = commands[ALU1_Temp_RTB.SelectedText].ToString();
                    ALU1_Description_CMI.Visible = true;
                    ALU1_Description_CMSep.Visible = true;
                }
                else
                {
                    ALU1_Description_CMI.Visible = false;
                    ALU1_Description_CMSep.Visible = false;
                }
                //Text = ALU1_Temp_RTB.SelectedText;
            }
        }

        private void ALU1_RegAx_Label_TextChanged(object sender, EventArgs e)
        {
            if (ALU1_RegAx_Label.Text.Length > 8)
            {
                ALU1_RegAx_Label.Select(ALU1_RegAx_Label.SelectionStart, 1);
                ALU1_RegAx_Label.SelectedText = "";
            } 
            else if (ALU1_RegAx_Label.Text.Length < 8)
            {
                ALU1_RegAx_Label.Text = Ax;
            }
            foreach (char item in ALU1_RegAx_Label.Text)
            {
                if (item != '0' && item != '1')
                {
                    ALU1_RegAx_Label.Text = Ax;
                    return;
                }
            }
            Ax = ALU1_RegAx_Label.Text;
        }

        private void ALU1_RegBx_Label_TextChanged(object sender, EventArgs e)
        {
            if (ALU1_RegBx_Label.Text.Length > 8)
            {
                ALU1_RegBx_Label.Select(ALU1_RegBx_Label.SelectionStart, 1);
                ALU1_RegBx_Label.SelectedText = "";
            }
            else if (ALU1_RegBx_Label.Text.Length < 8)
            {
                ALU1_RegBx_Label.Text = Bx;
            }
            foreach (char item in ALU1_RegBx_Label.Text)
            {
                if (item != '0' && item != '1')
                {
                    ALU1_RegBx_Label.Text = Bx;
                    return;
                }
            }
            Bx = ALU1_RegBx_Label.Text;
        }
    }
}
