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
        readonly Hashtable commands = new();
        string Bus = "00000000";
        string Ax = "00000000";
        string Bx = "00000000";
        string A = "00000000";
        string B = "00000000";
        string R = "00000000";
        string S = "00000000";

        public ALU1()
        {
            InitializeComponent();
        }

        private bool PerformCommand(string command)
        {
            if (command == "y0")
            {
                Bus = Ax;
                ALU1_BusValue_Label.Text = Bus;
                return false;
            }
            if (command == "y1")
            {
                Bus = Bx;
                ALU1_BusValue_Label.Text = Bus;
                return false;
            }
            if (command == "y2")
            {
                A = Bus;
                ALU1_AValue_Label.Text = A;
                return false;
            }
            if (command == "y3")
            {
                B = Bus;
                ALU1_BValue_Label.Text = B;
                return false;
            }
            if (command == "y4")
            {
                R = A;
                ALU1_RValue_Label.Text = R;
                return false;
            }
            if (command == "y5")
            {
                R = "";
                foreach (char digit in A)
                {
                    R += digit == '1' ? "0" : "1";
                }
                ALU1_RValue_Label.Text = R;
                return false;
            }
            if (command == "y6")
            {
                S = B;
                ALU1_SValue_Label.Text = S;
                return false;
            }
            if (command == "y7")
            {
                S = "";
                foreach (char digit in B)
                {
                    S += digit == '1' ? "0" : "1";
                }
                ALU1_SValue_Label.Text = S;
                return false;
            }
            if (command == "y21")
            {
                return true;
            }
            if (command == " " || command == "," || command == "")
            {
                return false;
            }
            return true;
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
            Bitmap alu1bmp = new(ALU1_Background_PB.Width, ALU1_Background_PB.Height);
            using Graphics grfx = Graphics.FromImage(alu1bmp);
            Point[] shina =
            {
                new Point(90, 85),
                new Point(500, 85),
                new Point(500, 430),
                new Point(90, 430),
                new Point(90, 422),
                new Point(492, 422),
                new Point(492, 93),
                new Point(90, 93)
            };
            Point[] tr1 =
            {
                new Point(168, 75),
                new Point(176, 75),
                new Point(172, 81)
            };
            Point[] tr2 =
            {
                new Point(446, 75),
                new Point(454, 75),
                new Point(450, 81)
            };
            Point[] tr3 =
            {
                new Point(183, 115),
                new Point(191, 115),
                new Point(187, 121)
            };
            Point[] tr4 =
            {
                new Point(431, 115),
                new Point(439, 115),
                new Point(435, 121)
            };
            grfx.DrawPolygon(new Pen(Brushes.Black, 1), shina);
            grfx.DrawLine(new Pen(Brushes.Black, 2), new Point(172, 60), new Point(172, 75));
            grfx.DrawPolygon(new Pen(Brushes.Black, 2), tr1);
            grfx.DrawLine(new Pen(Brushes.Black, 2), new Point(450, 60), new Point(450, 75));
            grfx.DrawPolygon(new Pen(Brushes.Black, 2), tr2);
            grfx.DrawLine(new Pen(Brushes.Black, 2), new Point(187, 94), new Point(187, 115));
            grfx.DrawPolygon(new Pen(Brushes.Black, 2), tr3);
            grfx.DrawLine(new Pen(Brushes.Black, 2), new Point(435, 94), new Point(435, 115));
            grfx.DrawPolygon(new Pen(Brushes.Black, 2), tr4);
            ALU1_Background_PB.Image = alu1bmp;
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
            if (ALU1_Temp_RTB.SelectedText == " " || ALU1_Temp_RTB.Text == "")
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

        private async void ALU1_Launch_Button_Click(object sender, EventArgs e)
        {
            int s = 0;
            int l = 1;
            ALU1_Microprogram_RTB.ReadOnly = true;
            string mp = ALU1_Microprogram_RTB.Text;
            if (mp.Length == 0) return;
            string currentCommand = mp.Substring(s, l);
            ALU1_Menu.BackColor = Color.CornflowerBlue;
            while (true)
            {
                while (currentCommand[^1] != ',' &&
                    currentCommand[^1] != ' ' &&
                    currentCommand[^1] != '\n')
                {
                    if (s + l >= mp.Length) {
                        break;
                    };
                    currentCommand = mp.Substring(s, ++l);
                }
                if (s + l < mp.Length)
                    currentCommand = mp.Substring(s, --l);
                if (PerformCommand(currentCommand))
                {
                    ALU1_Menu.BackColor = Color.WhiteSmoke;
                    ALU1_Microprogram_RTB.ReadOnly = false;
                    return;
                };
                //Text = currentCommand;
                s += l + 1;
                if (s + l > mp.Length)
                {
                    ALU1_Menu.BackColor = Color.WhiteSmoke;
                    ALU1_Microprogram_RTB.ReadOnly = false;
                    return;
                };
                currentCommand = mp.Substring(s, 1);
                l = 1;
                await Task.Delay(30);
            }
        }
    }
}
