﻿using System;
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
    }
}
