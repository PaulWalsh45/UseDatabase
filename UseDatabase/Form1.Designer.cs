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
            this.VisualStudioCheckBox = new System.Windows.Forms.CheckBox();
            this.VisionblueCheckBox = new System.Windows.Forms.CheckBox();
            this.DelphiCheckBox = new System.Windows.Forms.CheckBox();
            this.ChangeDatabaseButton = new System.Windows.Forms.Button();
            this.QAPreCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // VisualStudioCheckBox
            // 
            this.VisualStudioCheckBox.AutoSize = true;
            this.VisualStudioCheckBox.Location = new System.Drawing.Point(147, 45);
            this.VisualStudioCheckBox.Name = "VisualStudioCheckBox";
            this.VisualStudioCheckBox.Size = new System.Drawing.Size(202, 17);
            this.VisualStudioCheckBox.TabIndex = 3;
            this.VisualStudioCheckBox.Text = "Visual Studio (debug SE.02.0022/....)";
            this.VisualStudioCheckBox.UseVisualStyleBackColor = true;
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
            // DelphiCheckBox
            // 
            this.DelphiCheckBox.AutoSize = true;
            this.DelphiCheckBox.Location = new System.Drawing.Point(147, 148);
            this.DelphiCheckBox.Name = "DelphiCheckBox";
            this.DelphiCheckBox.Size = new System.Drawing.Size(161, 17);
            this.DelphiCheckBox.TabIndex = 3;
            this.DelphiCheckBox.Text = "Delphi (Embarcadero debug)";
            this.DelphiCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChangeDatabaseButton
            // 
            this.ChangeDatabaseButton.Location = new System.Drawing.Point(147, 175);
            this.ChangeDatabaseButton.Name = "ChangeDatabaseButton";
            this.ChangeDatabaseButton.Size = new System.Drawing.Size(100, 23);
            this.ChangeDatabaseButton.TabIndex = 4;
            this.ChangeDatabaseButton.Text = "Change";
            this.ChangeDatabaseButton.UseVisualStyleBackColor = true;
            this.ChangeDatabaseButton.Click += new System.EventHandler(this.ChangeDatabaseButton_Click);
            // 
            // QAPreCheckBox
            // 
            this.QAPreCheckBox.AutoSize = true;
            this.QAPreCheckBox.Location = new System.Drawing.Point(147, 68);
            this.QAPreCheckBox.Name = "QAPreCheckBox";
            this.QAPreCheckBox.Size = new System.Drawing.Size(179, 17);
            this.QAPreCheckBox.TabIndex = 3;
            this.QAPreCheckBox.Text = "QA Pre Release (debug QA/.....)";
            this.QAPreCheckBox.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 206);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeDatabaseButton);
            this.Controls.Add(this.QAPreCheckBox);
            this.Controls.Add(this.DelphiCheckBox);
            this.Controls.Add(this.VisionblueCheckBox);
            this.Controls.Add(this.VisualStudioCheckBox);
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
        private System.Windows.Forms.CheckBox VisualStudioCheckBox;
        private System.Windows.Forms.CheckBox VisionblueCheckBox;
        private System.Windows.Forms.CheckBox DelphiCheckBox;
        private System.Windows.Forms.Button ChangeDatabaseButton;
        private System.Windows.Forms.CheckBox QAPreCheckBox;
        private System.Windows.Forms.Label label3;
    }
}

