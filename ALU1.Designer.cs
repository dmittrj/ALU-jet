
namespace ALU_jet
{
    partial class ALU1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Jd_ProjectName_TB = new System.Windows.Forms.TextBox();
            this.Jd_CreateProject_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ALU1_Microprogram_RTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ALU1_SyntaxHighlight_Timer = new System.Windows.Forms.Timer(this.components);
            this.ALU1_Temp_RTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Jd_ProjectName_TB);
            this.panel1.Controls.Add(this.Jd_CreateProject_Label);
            this.panel1.Location = new System.Drawing.Point(123, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 58);
            this.panel1.TabIndex = 1;
            // 
            // Jd_ProjectName_TB
            // 
            this.Jd_ProjectName_TB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Jd_ProjectName_TB.Location = new System.Drawing.Point(4, 25);
            this.Jd_ProjectName_TB.Name = "Jd_ProjectName_TB";
            this.Jd_ProjectName_TB.Size = new System.Drawing.Size(83, 26);
            this.Jd_ProjectName_TB.TabIndex = 3;
            this.Jd_ProjectName_TB.Text = "00000000";
            this.Jd_ProjectName_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Jd_CreateProject_Label
            // 
            this.Jd_CreateProject_Label.AutoSize = true;
            this.Jd_CreateProject_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Jd_CreateProject_Label.Location = new System.Drawing.Point(1, 2);
            this.Jd_CreateProject_Label.Name = "Jd_CreateProject_Label";
            this.Jd_CreateProject_Label.Size = new System.Drawing.Size(30, 21);
            this.Jd_CreateProject_Label.TabIndex = 1;
            this.Jd_CreateProject_Label.Text = "Ax";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(398, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 58);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "00000000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bx";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ALU1_Microprogram_RTB
            // 
            this.ALU1_Microprogram_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ALU1_Microprogram_RTB.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_Microprogram_RTB.Location = new System.Drawing.Point(622, 56);
            this.ALU1_Microprogram_RTB.Name = "ALU1_Microprogram_RTB";
            this.ALU1_Microprogram_RTB.Size = new System.Drawing.Size(236, 300);
            this.ALU1_Microprogram_RTB.TabIndex = 3;
            this.ALU1_Microprogram_RTB.Text = "";
            this.ALU1_Microprogram_RTB.TextChanged += new System.EventHandler(this.ALU1_Microprogram_RTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(620, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Микропрограмма";
            // 
            // ALU1_SyntaxHighlight_Timer
            // 
            this.ALU1_SyntaxHighlight_Timer.Interval = 1000;
            this.ALU1_SyntaxHighlight_Timer.Tick += new System.EventHandler(this.ALU1_SyntaxHighlight_Timer_Tick);
            // 
            // ALU1_Temp_RTB
            // 
            this.ALU1_Temp_RTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ALU1_Temp_RTB.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_Temp_RTB.Location = new System.Drawing.Point(841, 454);
            this.ALU1_Temp_RTB.Name = "ALU1_Temp_RTB";
            this.ALU1_Temp_RTB.Size = new System.Drawing.Size(17, 12);
            this.ALU1_Temp_RTB.TabIndex = 5;
            this.ALU1_Temp_RTB.Text = "";
            this.ALU1_Temp_RTB.Visible = false;
            // 
            // ALU1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 478);
            this.Controls.Add(this.ALU1_Temp_RTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ALU1_Microprogram_RTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ALU1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALU-1 — ALU-jet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ALU1_FormClosing);
            this.Load += new System.EventHandler(this.ALU1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Jd_CreateProject_Label;
        private System.Windows.Forms.TextBox Jd_ProjectName_TB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ALU1_Microprogram_RTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ALU1_SyntaxHighlight_Timer;
        private System.Windows.Forms.RichTextBox ALU1_Temp_RTB;
    }
}