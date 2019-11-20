namespace EmployeeBrowser
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblConStr = new System.Windows.Forms.Label();
            this.tBxConStr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(359, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblConStr
            // 
            this.lblConStr.AutoSize = true;
            this.lblConStr.Location = new System.Drawing.Point(9, 8);
            this.lblConStr.Name = "lblConStr";
            this.lblConStr.Size = new System.Drawing.Size(113, 13);
            this.lblConStr.TabIndex = 1;
            this.lblConStr.Text = "Строка подключения";
            // 
            // tBxConStr
            // 
            this.tBxConStr.Location = new System.Drawing.Point(10, 27);
            this.tBxConStr.Name = "tBxConStr";
            this.tBxConStr.Size = new System.Drawing.Size(424, 20);
            this.tBxConStr.TabIndex = 2;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 87);
            this.Controls.Add(this.tBxConStr);
            this.Controls.Add(this.lblConStr);
            this.Controls.Add(this.btnClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblConStr;
        private System.Windows.Forms.TextBox tBxConStr;
    }
}