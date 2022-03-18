
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
            this.ALU1_Menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ALU1_RegAx_Label = new System.Windows.Forms.TextBox();
            this.Jd_CreateProject_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ALU1_RegBx_Label = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ALU1_Microprogram_RTB = new System.Windows.Forms.RichTextBox();
            this.ALU1_Micro_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ALU1_Description_CMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ALU1_Description_CMSep = new System.Windows.Forms.ToolStripSeparator();
            this.ALU1_Cut_CMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ALU1_Copy_CMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ALU1_Paste_CMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.добавитьТочкуОстановаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ALU1_SyntaxHighlight_Timer = new System.Windows.Forms.Timer(this.components);
            this.ALU1_Temp_RTB = new System.Windows.Forms.RichTextBox();
            this.ALU1_Launch_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ALU1_Background_PB = new System.Windows.Forms.PictureBox();
            this.ALU1_BusValue_Label = new System.Windows.Forms.Label();
            this.ALU1_AValue_Label = new System.Windows.Forms.Label();
            this.ALU1_BValue_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ALU1_SValue_Label = new System.Windows.Forms.Label();
            this.ALU1_RValue_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ALU1_Menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ALU1_Micro_CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALU1_Background_PB)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ALU1_Menu
            // 
            this.ALU1_Menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ALU1_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.ALU1_Menu.Location = new System.Drawing.Point(0, 0);
            this.ALU1_Menu.Name = "ALU1_Menu";
            this.ALU1_Menu.Size = new System.Drawing.Size(858, 27);
            this.ALU1_Menu.TabIndex = 0;
            this.ALU1_Menu.Text = "menuStrip1";
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
            this.panel1.Controls.Add(this.ALU1_RegAx_Label);
            this.panel1.Controls.Add(this.Jd_CreateProject_Label);
            this.panel1.Location = new System.Drawing.Point(123, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 58);
            this.panel1.TabIndex = 1;
            // 
            // ALU1_RegAx_Label
            // 
            this.ALU1_RegAx_Label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_RegAx_Label.Location = new System.Drawing.Point(4, 25);
            this.ALU1_RegAx_Label.Name = "ALU1_RegAx_Label";
            this.ALU1_RegAx_Label.Size = new System.Drawing.Size(83, 26);
            this.ALU1_RegAx_Label.TabIndex = 3;
            this.ALU1_RegAx_Label.Text = "00000000";
            this.ALU1_RegAx_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ALU1_RegAx_Label.TextChanged += new System.EventHandler(this.ALU1_RegAx_Label_TextChanged);
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
            this.panel2.Controls.Add(this.ALU1_RegBx_Label);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(398, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 58);
            this.panel2.TabIndex = 2;
            // 
            // ALU1_RegBx_Label
            // 
            this.ALU1_RegBx_Label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_RegBx_Label.Location = new System.Drawing.Point(13, 25);
            this.ALU1_RegBx_Label.Name = "ALU1_RegBx_Label";
            this.ALU1_RegBx_Label.Size = new System.Drawing.Size(83, 26);
            this.ALU1_RegBx_Label.TabIndex = 3;
            this.ALU1_RegBx_Label.Text = "00000000";
            this.ALU1_RegBx_Label.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ALU1_RegBx_Label.TextChanged += new System.EventHandler(this.ALU1_RegBx_Label_TextChanged);
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
            this.ALU1_Microprogram_RTB.ContextMenuStrip = this.ALU1_Micro_CMS;
            this.ALU1_Microprogram_RTB.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_Microprogram_RTB.Location = new System.Drawing.Point(622, 56);
            this.ALU1_Microprogram_RTB.Name = "ALU1_Microprogram_RTB";
            this.ALU1_Microprogram_RTB.Size = new System.Drawing.Size(236, 300);
            this.ALU1_Microprogram_RTB.TabIndex = 3;
            this.ALU1_Microprogram_RTB.Text = "";
            this.ALU1_Microprogram_RTB.TextChanged += new System.EventHandler(this.ALU1_Microprogram_RTB_TextChanged);
            // 
            // ALU1_Micro_CMS
            // 
            this.ALU1_Micro_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ALU1_Description_CMI,
            this.ALU1_Description_CMSep,
            this.ALU1_Cut_CMI,
            this.ALU1_Copy_CMI,
            this.ALU1_Paste_CMI,
            this.toolStripSeparator2,
            this.добавитьТочкуОстановаToolStripMenuItem});
            this.ALU1_Micro_CMS.Name = "ALU1_Micro_CMS";
            this.ALU1_Micro_CMS.Size = new System.Drawing.Size(214, 126);
            this.ALU1_Micro_CMS.Opening += new System.ComponentModel.CancelEventHandler(this.ALU1_Micro_CMS_Opening);
            // 
            // ALU1_Description_CMI
            // 
            this.ALU1_Description_CMI.Enabled = false;
            this.ALU1_Description_CMI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ALU1_Description_CMI.Name = "ALU1_Description_CMI";
            this.ALU1_Description_CMI.Size = new System.Drawing.Size(213, 22);
            this.ALU1_Description_CMI.Text = "Описание команды";
            // 
            // ALU1_Description_CMSep
            // 
            this.ALU1_Description_CMSep.Name = "ALU1_Description_CMSep";
            this.ALU1_Description_CMSep.Size = new System.Drawing.Size(210, 6);
            // 
            // ALU1_Cut_CMI
            // 
            this.ALU1_Cut_CMI.Name = "ALU1_Cut_CMI";
            this.ALU1_Cut_CMI.Size = new System.Drawing.Size(213, 22);
            this.ALU1_Cut_CMI.Text = "Вырезать";
            this.ALU1_Cut_CMI.Click += new System.EventHandler(this.ALU1_Cut_CMI_Click);
            // 
            // ALU1_Copy_CMI
            // 
            this.ALU1_Copy_CMI.Name = "ALU1_Copy_CMI";
            this.ALU1_Copy_CMI.Size = new System.Drawing.Size(213, 22);
            this.ALU1_Copy_CMI.Text = "Копировать";
            this.ALU1_Copy_CMI.Click += new System.EventHandler(this.ALU1_Copy_CMI_Click);
            // 
            // ALU1_Paste_CMI
            // 
            this.ALU1_Paste_CMI.Name = "ALU1_Paste_CMI";
            this.ALU1_Paste_CMI.Size = new System.Drawing.Size(213, 22);
            this.ALU1_Paste_CMI.Text = "Вставить";
            this.ALU1_Paste_CMI.Click += new System.EventHandler(this.ALU1_Paste_CMI_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
            // 
            // добавитьТочкуОстановаToolStripMenuItem
            // 
            this.добавитьТочкуОстановаToolStripMenuItem.Name = "добавитьТочкуОстановаToolStripMenuItem";
            this.добавитьТочкуОстановаToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.добавитьТочкуОстановаToolStripMenuItem.Text = "Добавить точку останова";
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
            this.ALU1_Temp_RTB.Location = new System.Drawing.Point(830, 452);
            this.ALU1_Temp_RTB.Name = "ALU1_Temp_RTB";
            this.ALU1_Temp_RTB.Size = new System.Drawing.Size(16, 14);
            this.ALU1_Temp_RTB.TabIndex = 5;
            this.ALU1_Temp_RTB.Text = "";
            this.ALU1_Temp_RTB.Visible = false;
            // 
            // ALU1_Launch_Button
            // 
            this.ALU1_Launch_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALU1_Launch_Button.Location = new System.Drawing.Point(622, 362);
            this.ALU1_Launch_Button.Name = "ALU1_Launch_Button";
            this.ALU1_Launch_Button.Size = new System.Drawing.Size(137, 26);
            this.ALU1_Launch_Button.TabIndex = 6;
            this.ALU1_Launch_Button.Text = "Собрать и запустить";
            this.ALU1_Launch_Button.UseVisualStyleBackColor = true;
            this.ALU1_Launch_Button.Click += new System.EventHandler(this.ALU1_Launch_Button_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(765, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Шаг";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ALU1_Background_PB
            // 
            this.ALU1_Background_PB.Location = new System.Drawing.Point(0, 28);
            this.ALU1_Background_PB.Name = "ALU1_Background_PB";
            this.ALU1_Background_PB.Size = new System.Drawing.Size(616, 449);
            this.ALU1_Background_PB.TabIndex = 8;
            this.ALU1_Background_PB.TabStop = false;
            // 
            // ALU1_BusValue_Label
            // 
            this.ALU1_BusValue_Label.AutoSize = true;
            this.ALU1_BusValue_Label.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_BusValue_Label.Location = new System.Drawing.Point(16, 108);
            this.ALU1_BusValue_Label.Name = "ALU1_BusValue_Label";
            this.ALU1_BusValue_Label.Size = new System.Drawing.Size(72, 18);
            this.ALU1_BusValue_Label.TabIndex = 9;
            this.ALU1_BusValue_Label.Text = "00000000";
            // 
            // ALU1_AValue_Label
            // 
            this.ALU1_AValue_Label.AutoSize = true;
            this.ALU1_AValue_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ALU1_AValue_Label.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_AValue_Label.Location = new System.Drawing.Point(151, 153);
            this.ALU1_AValue_Label.Name = "ALU1_AValue_Label";
            this.ALU1_AValue_Label.Size = new System.Drawing.Size(74, 19);
            this.ALU1_AValue_Label.TabIndex = 10;
            this.ALU1_AValue_Label.Text = "00000000";
            this.ALU1_AValue_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ALU1_BValue_Label
            // 
            this.ALU1_BValue_Label.AutoSize = true;
            this.ALU1_BValue_Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ALU1_BValue_Label.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_BValue_Label.Location = new System.Drawing.Point(398, 153);
            this.ALU1_BValue_Label.Name = "ALU1_BValue_Label";
            this.ALU1_BValue_Label.Size = new System.Drawing.Size(74, 19);
            this.ALU1_BValue_Label.TabIndex = 11;
            this.ALU1_BValue_Label.Text = "00000000";
            this.ALU1_BValue_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ALU1_SValue_Label);
            this.panel3.Controls.Add(this.ALU1_RValue_Label);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(225, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 76);
            this.panel3.TabIndex = 12;
            // 
            // ALU1_SValue_Label
            // 
            this.ALU1_SValue_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_SValue_Label.ForeColor = System.Drawing.Color.Black;
            this.ALU1_SValue_Label.Location = new System.Drawing.Point(88, 1);
            this.ALU1_SValue_Label.Name = "ALU1_SValue_Label";
            this.ALU1_SValue_Label.Size = new System.Drawing.Size(83, 18);
            this.ALU1_SValue_Label.TabIndex = 16;
            this.ALU1_SValue_Label.Text = "00000000";
            this.ALU1_SValue_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ALU1_RValue_Label
            // 
            this.ALU1_RValue_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ALU1_RValue_Label.ForeColor = System.Drawing.Color.Black;
            this.ALU1_RValue_Label.Location = new System.Drawing.Point(3, 1);
            this.ALU1_RValue_Label.Name = "ALU1_RValue_Label";
            this.ALU1_RValue_Label.Size = new System.Drawing.Size(83, 18);
            this.ALU1_RValue_Label.TabIndex = 14;
            this.ALU1_RValue_Label.Text = "00000000";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(3, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "АЛБ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(184, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "R:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(398, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = ":S";
            // 
            // ALU1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 478);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ALU1_BValue_Label);
            this.Controls.Add(this.ALU1_AValue_Label);
            this.Controls.Add(this.ALU1_BusValue_Label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ALU1_Launch_Button);
            this.Controls.Add(this.ALU1_Temp_RTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ALU1_Microprogram_RTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ALU1_Menu);
            this.Controls.Add(this.ALU1_Background_PB);
            this.MainMenuStrip = this.ALU1_Menu;
            this.Name = "ALU1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALU-1 — ALU-jet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ALU1_FormClosing);
            this.Load += new System.EventHandler(this.ALU1_Load);
            this.ALU1_Menu.ResumeLayout(false);
            this.ALU1_Menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ALU1_Micro_CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ALU1_Background_PB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ALU1_Menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Jd_CreateProject_Label;
        private System.Windows.Forms.TextBox ALU1_RegAx_Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ALU1_RegBx_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ALU1_Microprogram_RTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ALU1_SyntaxHighlight_Timer;
        private System.Windows.Forms.RichTextBox ALU1_Temp_RTB;
        private System.Windows.Forms.Button ALU1_Launch_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip ALU1_Micro_CMS;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Description_CMI;
        private System.Windows.Forms.ToolStripSeparator ALU1_Description_CMSep;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Cut_CMI;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Copy_CMI;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Paste_CMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem добавитьТочкуОстановаToolStripMenuItem;
        private System.Windows.Forms.PictureBox ALU1_Background_PB;
        private System.Windows.Forms.Label ALU1_BusValue_Label;
        private System.Windows.Forms.Label ALU1_AValue_Label;
        private System.Windows.Forms.Label ALU1_BValue_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ALU1_RValue_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ALU1_SValue_Label;
        private System.Windows.Forms.Label label6;
    }
}