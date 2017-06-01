namespace UseDatabase
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VisualStudioDevCheckBox = new System.Windows.Forms.CheckBox();
            this.VisionblueCheckBox = new System.Windows.Forms.CheckBox();
            this.Delphi18CheckBox = new System.Windows.Forms.CheckBox();
            this.ChangeDatabaseButton = new System.Windows.Forms.Button();
            this.VisualStudioQACheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DelphiDebugQACheckbox = new System.Windows.Forms.CheckBox();
            this.DelphiDebugDevCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Use Database";
            // 
            // DatabaseComboBox
            // 
            this.DatabaseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseComboBox.FormattingEnabled = true;
            this.DatabaseComboBox.Location = new System.Drawing.Point(147, 10);
            this.DatabaseComboBox.Name = "DatabaseComboBox";
            this.DatabaseComboBox.Size = new System.Drawing.Size(149, 21);
            this.DatabaseComboBox.TabIndex = 1;
            this.DatabaseComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabaseComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Change Locations";
            // 
            // VisualStudioDevCheckBox
            // 
            this.VisualStudioDevCheckBox.AutoSize = true;
            this.VisualStudioDevCheckBox.Location = new System.Drawing.Point(147, 45);
            this.VisualStudioDevCheckBox.Name = "VisualStudioDevCheckBox";
            this.VisualStudioDevCheckBox.Size = new System.Drawing.Size(227, 17);
            this.VisualStudioDevCheckBox.TabIndex = 3;
            this.VisualStudioDevCheckBox.Text = "Visual Studio DEV (debug SE.02.0022/....)";
            this.VisualStudioDevCheckBox.UseVisualStyleBackColor = true;
            // 
            // VisionblueCheckBox
            // 
            this.VisionblueCheckBox.AutoSize = true;
            this.VisionblueCheckBox.Location = new System.Drawing.Point(147, 125);
            this.VisionblueCheckBox.Name = "VisionblueCheckBox";
            this.VisionblueCheckBox.Size = new System.Drawing.Size(146, 17);
            this.VisionblueCheckBox.TabIndex = 3;
            this.VisionblueCheckBox.Text = "Visionblue (InsolvUK.exe)";
            this.VisionblueCheckBox.UseVisualStyleBackColor = true;
            // 
            // Delphi18CheckBox
            // 
            this.Delphi18CheckBox.AutoSize = true;
            this.Delphi18CheckBox.Location = new System.Drawing.Point(147, 148);
            this.Delphi18CheckBox.Name = "Delphi18CheckBox";
            this.Delphi18CheckBox.Size = new System.Drawing.Size(176, 17);
            this.Delphi18CheckBox.TabIndex = 3;
            this.Delphi18CheckBox.Text = "Delphi 18 (Embarcadero debug)";
            this.Delphi18CheckBox.UseVisualStyleBackColor = true;
            // 
            // ChangeDatabaseButton
            // 
            this.ChangeDatabaseButton.Location = new System.Drawing.Point(147, 225);
            this.ChangeDatabaseButton.Name = "ChangeDatabaseButton";
            this.ChangeDatabaseButton.Size = new System.Drawing.Size(100, 23);
            this.ChangeDatabaseButton.TabIndex = 4;
            this.ChangeDatabaseButton.Text = "Change";
            this.ChangeDatabaseButton.UseVisualStyleBackColor = true;
            this.ChangeDatabaseButton.Click += new System.EventHandler(this.ChangeDatabaseButton_Click);
            // 
            // VisualStudioQACheckBox
            // 
            this.VisualStudioQACheckBox.AutoSize = true;
            this.VisualStudioQACheckBox.Location = new System.Drawing.Point(147, 68);
            this.VisualStudioQACheckBox.Name = "VisualStudioQACheckBox";
            this.VisualStudioQACheckBox.Size = new System.Drawing.Size(185, 17);
            this.VisualStudioQACheckBox.TabIndex = 3;
            this.VisualStudioQACheckBox.Text = "Visual Studio QA  (debug QA/.....)";
            this.VisualStudioQACheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(147, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "These are overwritten in the dbxconnection.ini file Visual Studio";
            // 
            // DelphiDebugQACheckbox
            // 
            this.DelphiDebugQACheckbox.AutoSize = true;
            this.DelphiDebugQACheckbox.Location = new System.Drawing.Point(147, 171);
            this.DelphiDebugQACheckbox.Name = "DelphiDebugQACheckbox";
            this.DelphiDebugQACheckbox.Size = new System.Drawing.Size(179, 17);
            this.DelphiDebugQACheckbox.TabIndex = 3;
            this.DelphiDebugQACheckbox.Text = "Delphi QA (Embarcadero debug)";
            this.DelphiDebugQACheckbox.UseVisualStyleBackColor = true;
            // 
            // DelphiDebugDevCheckbox
            // 
            this.DelphiDebugDevCheckbox.AutoSize = true;
            this.DelphiDebugDevCheckbox.Location = new System.Drawing.Point(147, 194);
            this.DelphiDebugDevCheckbox.Name = "DelphiDebugDevCheckbox";
            this.DelphiDebugDevCheckbox.Size = new System.Drawing.Size(184, 17);
            this.DelphiDebugDevCheckbox.TabIndex = 3;
            this.DelphiDebugDevCheckbox.Text = "Delphi Dev (Embarcadero debug)";
            this.DelphiDebugDevCheckbox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeDatabaseButton);
            this.Controls.Add(this.VisualStudioQACheckBox);
            this.Controls.Add(this.DelphiDebugDevCheckbox);
            this.Controls.Add(this.DelphiDebugQACheckbox);
            this.Controls.Add(this.Delphi18CheckBox);
            this.Controls.Add(this.VisionblueCheckBox);
            this.Controls.Add(this.VisualStudioDevCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabaseComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DatabaseComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox VisualStudioDevCheckBox;
        private System.Windows.Forms.CheckBox VisionblueCheckBox;
        private System.Windows.Forms.CheckBox Delphi18CheckBox;
        private System.Windows.Forms.Button ChangeDatabaseButton;
        private System.Windows.Forms.CheckBox VisualStudioQACheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox DelphiDebugQACheckbox;
        private System.Windows.Forms.CheckBox DelphiDebugDevCheckbox;
    }
}

