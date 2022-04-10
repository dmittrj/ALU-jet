
namespace ALU_jet
{
    partial class ALU_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Jd_CreateProject_Label = new System.Windows.Forms.Label();
            this.Main_ProjectTypes_LB = new System.Windows.Forms.ListBox();
            this.Main_ProjectName_TB = new System.Windows.Forms.TextBox();
            this.Main_ProjectExtension_Label = new System.Windows.Forms.Label();
            this.Main_Description_Label = new System.Windows.Forms.Label();
            this.Main_CreateProject_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Main_Projects_LB = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jd_CreateProject_Label
            // 
            this.Jd_CreateProject_Label.AutoSize = true;
            this.Jd_CreateProject_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Jd_CreateProject_Label.Location = new System.Drawing.Point(24, 35);
            this.Jd_CreateProject_Label.Name = "Jd_CreateProject_Label";
            this.Jd_CreateProject_Label.Size = new System.Drawing.Size(132, 21);
            this.Jd_CreateProject_Label.TabIndex = 0;
            this.Jd_CreateProject_Label.Text = "Создать проект";
            // 
            // Main_ProjectTypes_LB
            // 
            this.Main_ProjectTypes_LB.FormattingEnabled = true;
            this.Main_ProjectTypes_LB.ItemHeight = 15;
            this.Main_ProjectTypes_LB.Items.AddRange(new object[] {
            "Проект ALU-1",
            "Проект ALU-R"});
            this.Main_ProjectTypes_LB.Location = new System.Drawing.Point(24, 61);
            this.Main_ProjectTypes_LB.Name = "Main_ProjectTypes_LB";
            this.Main_ProjectTypes_LB.Size = new System.Drawing.Size(206, 244);
            this.Main_ProjectTypes_LB.TabIndex = 1;
            this.Main_ProjectTypes_LB.SelectedIndexChanged += new System.EventHandler(this.Main_ProjectTypes_LB_SelectedIndexChanged);
            // 
            // Main_ProjectName_TB
            // 
            this.Main_ProjectName_TB.Location = new System.Drawing.Point(24, 311);
            this.Main_ProjectName_TB.Name = "Main_ProjectName_TB";
            this.Main_ProjectName_TB.Size = new System.Drawing.Size(206, 23);
            this.Main_ProjectName_TB.TabIndex = 2;
            this.Main_ProjectName_TB.Text = "Имя проекта...";
            // 
            // Main_ProjectExtension_Label
            // 
            this.Main_ProjectExtension_Label.AutoSize = true;
            this.Main_ProjectExtension_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Main_ProjectExtension_Label.Location = new System.Drawing.Point(232, 312);
            this.Main_ProjectExtension_Label.Name = "Main_ProjectExtension_Label";
            this.Main_ProjectExtension_Label.Size = new System.Drawing.Size(0, 21);
            this.Main_ProjectExtension_Label.TabIndex = 3;
            // 
            // Main_Description_Label
            // 
            this.Main_Description_Label.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Main_Description_Label.Location = new System.Drawing.Point(232, 61);
            this.Main_Description_Label.Name = "Main_Description_Label";
            this.Main_Description_Label.Size = new System.Drawing.Size(175, 228);
            this.Main_Description_Label.TabIndex = 4;
            this.Main_Description_Label.Text = "Проект ALU-1";
            // 
            // Main_CreateProject_Button
            // 
            this.Main_CreateProject_Button.Enabled = false;
            this.Main_CreateProject_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_CreateProject_Button.Location = new System.Drawing.Point(24, 353);
            this.Main_CreateProject_Button.Name = "Main_CreateProject_Button";
            this.Main_CreateProject_Button.Size = new System.Drawing.Size(100, 26);
            this.Main_CreateProject_Button.TabIndex = 5;
            this.Main_CreateProject_Button.Text = "Создать";
            this.Main_CreateProject_Button.UseVisualStyleBackColor = true;
            this.Main_CreateProject_Button.Click += new System.EventHandler(this.Main_CreateProject_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(435, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Открыть проект";
            // 
            // Main_Projects_LB
            // 
            this.Main_Projects_LB.FormattingEnabled = true;
            this.Main_Projects_LB.ItemHeight = 15;
            this.Main_Projects_LB.Location = new System.Drawing.Point(435, 61);
            this.Main_Projects_LB.Name = "Main_Projects_LB";
            this.Main_Projects_LB.Size = new System.Drawing.Size(206, 94);
            this.Main_Projects_LB.TabIndex = 7;
            this.Main_Projects_LB.SelectedIndexChanged += new System.EventHandler(this.Main_Projects_LB_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(435, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "Локальный";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ALU_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(783, 478);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Main_Projects_LB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Main_CreateProject_Button);
            this.Controls.Add(this.Main_Description_Label);
            this.Controls.Add(this.Main_ProjectExtension_Label);
            this.Controls.Add(this.Main_ProjectName_TB);
            this.Controls.Add(this.Main_ProjectTypes_LB);
            this.Controls.Add(this.Jd_CreateProject_Label);
            this.Name = "ALU_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALU-jet — начало работы";
            this.Load += new System.EventHandler(this.ALU_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Jd_CreateProject_Label;
        private System.Windows.Forms.ListBox Main_ProjectTypes_LB;
        private System.Windows.Forms.TextBox Main_ProjectName_TB;
        private System.Windows.Forms.Label Main_ProjectExtension_Label;
        private System.Windows.Forms.Label Main_Description_Label;
        private System.Windows.Forms.Button Main_CreateProject_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Main_Projects_LB;
        private System.Windows.Forms.Button button2;
    }
}

