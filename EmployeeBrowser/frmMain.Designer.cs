namespace EmployeeBrowser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cBxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dTPFrom = new System.Windows.Forms.DateTimePicker();
            this.lblCount = new System.Windows.Forms.Label();
            this.grVwMain = new System.Windows.Forms.DataGridView();
            this.dbBindSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTPTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblStats = new System.Windows.Forms.Label();
            this.cBxFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cBxEmpl = new System.Windows.Forms.ComboBox();
            this.lblEmpl = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Button();
            this.tBxFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grVwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBindSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(14, 12);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(50, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Фильтр:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1041, 518);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Location = new System.Drawing.Point(960, 518);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // cBxStatus
            // 
            this.cBxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBxStatus.FormattingEnabled = true;
            this.cBxStatus.Location = new System.Drawing.Point(15, 472);
            this.cBxStatus.Name = "cBxStatus";
            this.cBxStatus.Size = new System.Drawing.Size(200, 21);
            this.cBxStatus.TabIndex = 6;
            this.cBxStatus.Text = "-";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 456);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус:";
            // 
            // dTPFrom
            // 
            this.dTPFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFrom.Location = new System.Drawing.Point(37, 501);
            this.dTPFrom.Name = "dTPFrom";
            this.dTPFrom.Size = new System.Drawing.Size(200, 20);
            this.dTPFrom.TabIndex = 8;
            this.dTPFrom.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(93, 529);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(167, 13);
            this.lblCount.TabIndex = 9;
            this.lblCount.Text = "Количество сотрудников: -";
            // 
            // grVwMain
            // 
            this.grVwMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grVwMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grVwMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grVwMain.Location = new System.Drawing.Point(15, 35);
            this.grVwMain.Name = "grVwMain";
            this.grVwMain.Size = new System.Drawing.Size(1104, 382);
            this.grVwMain.TabIndex = 0;
            // 
            // dTPTo
            // 
            this.dTPTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPTo.Location = new System.Drawing.Point(274, 501);
            this.dTPTo.Name = "dTPTo";
            this.dTPTo.Size = new System.Drawing.Size(200, 20);
            this.dTPTo.TabIndex = 10;
            this.dTPTo.Value = new System.DateTime(2017, 7, 7, 19, 48, 54, 0);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(13, 505);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(23, 13);
            this.lblDateFrom.TabIndex = 11;
            this.lblDateFrom.Text = "От:";
            // 
            // lblDateTo
            // 
            this.lblDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(243, 505);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(25, 13);
            this.lblDateTo.TabIndex = 12;
            this.lblDateTo.Text = "До:";
            // 
            // lblStats
            // 
            this.lblStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStats.AutoSize = true;
            this.lblStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStats.Location = new System.Drawing.Point(12, 436);
            this.lblStats.Name = "lblStats";
            this.lblStats.Size = new System.Drawing.Size(90, 15);
            this.lblStats.TabIndex = 13;
            this.lblStats.Text = "Статистика:";
            // 
            // cBxFilter
            // 
            this.cBxFilter.FormattingEnabled = true;
            this.cBxFilter.Items.AddRange(new object[] {
            "-",
            "По статусу",
            "По отделу",
            "По должности",
            "По фамилии"});
            this.cBxFilter.Location = new System.Drawing.Point(70, 9);
            this.cBxFilter.Name = "cBxFilter";
            this.cBxFilter.Size = new System.Drawing.Size(121, 21);
            this.cBxFilter.TabIndex = 14;
            this.cBxFilter.Text = "-";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(512, 7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Применить";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cBxEmpl
            // 
            this.cBxEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBxEmpl.FormattingEnabled = true;
            this.cBxEmpl.Items.AddRange(new object[] {
            "Принят на работу",
            "Уволен"});
            this.cBxEmpl.Location = new System.Drawing.Point(274, 472);
            this.cBxEmpl.Name = "cBxEmpl";
            this.cBxEmpl.Size = new System.Drawing.Size(200, 21);
            this.cBxEmpl.TabIndex = 16;
            this.cBxEmpl.Text = "-";
            // 
            // lblEmpl
            // 
            this.lblEmpl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmpl.AutoSize = true;
            this.lblEmpl.Location = new System.Drawing.Point(273, 456);
            this.lblEmpl.Name = "lblEmpl";
            this.lblEmpl.Size = new System.Drawing.Size(61, 13);
            this.lblEmpl.TabIndex = 17;
            this.lblEmpl.Text = "Состояние";
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(12, 524);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(75, 23);
            this.btnStats.TabIndex = 18;
            this.btnStats.Text = "Применить";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // tBxFilter
            // 
            this.tBxFilter.Location = new System.Drawing.Point(197, 9);
            this.tBxFilter.Name = "tBxFilter";
            this.tBxFilter.Size = new System.Drawing.Size(309, 20);
            this.tBxFilter.TabIndex = 20;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 553);
            this.Controls.Add(this.tBxFilter);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lblEmpl);
            this.Controls.Add(this.cBxEmpl);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cBxFilter);
            this.Controls.Add(this.lblStats);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.dTPTo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.dTPFrom);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cBxStatus);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.grVwMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(907, 280);
            this.Name = "frmMain";
            this.Text = "Просмотр сотрудников";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grVwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbBindSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ComboBox cBxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DateTimePicker dTPFrom;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView grVwMain;
        private System.Windows.Forms.BindingSource dbBindSource;
        private System.Windows.Forms.DateTimePicker dTPTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.ComboBox cBxFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cBxEmpl;
        private System.Windows.Forms.Label lblEmpl;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.TextBox tBxFilter;
    }
}

