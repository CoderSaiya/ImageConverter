namespace ImageConverterApp
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lbNameProject = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblFormat = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(347, 96);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(110, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Chọn File...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // lbNameProject
            // 
            this.lbNameProject.AutoSize = true;
            this.lbNameProject.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbNameProject.ForeColor = System.Drawing.Color.White;
            this.lbNameProject.Location = new System.Drawing.Point(20, 20);
            this.lbNameProject.Name = "lbNameProject";
            this.lbNameProject.Size = new System.Drawing.Size(254, 32);
            this.lbNameProject.TabIndex = 2;
            this.lbNameProject.Text = "CHUYỂN ĐỔI ẢNH";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.headerPanel.Controls.Add(this.lbNameProject);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(257, 151);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(111, 16);
            this.lblFormat.TabIndex = 2;
            this.lblFormat.Text = "Định dạng đầu ra:";
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(398, 148);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(121, 24);
            this.cmbFormat.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(347, 197);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(99, 40);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Chuyển đổi";
            this.btnConvert.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(12, 260);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(776, 178);
            this.rtbLog.TabIndex = 5;
            this.rtbLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lbNameProject;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox rtbLog;
    }
}

