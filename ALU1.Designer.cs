
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
            this.Main_CreateProject_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ALU1_Micro_CMS.SuspendLayout();
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
            // Main_CreateProject_Button
            // 
            this.Main_CreateProject_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_CreateProject_Button.Location = new System.Drawing.Point(622, 362);
            this.Main_CreateProject_Button.Name = "Main_CreateProject_Button";
            this.Main_CreateProject_Button.Size = new System.Drawing.Size(137, 26);
            this.Main_CreateProject_Button.TabIndex = 6;
            this.Main_CreateProject_Button.Text = "Собрать и запустить";
            this.Main_CreateProject_Button.UseVisualStyleBackColor = true;
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
            // ALU1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Main_CreateProject_Button);
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
            this.ALU1_Micro_CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.Button Main_CreateProject_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip ALU1_Micro_CMS;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Description_CMI;
        private System.Windows.Forms.ToolStripSeparator ALU1_Description_CMSep;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Cut_CMI;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Copy_CMI;
        private System.Windows.Forms.ToolStripMenuItem ALU1_Paste_CMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem добавитьТочкуОстановаToolStripMenuItem;
    }
}