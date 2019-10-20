namespace KPO
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MMenu = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmEnterprises = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenEnterPrise = new System.Windows.Forms.ToolStripMenuItem();
            this.SStatus = new System.Windows.Forms.StatusStrip();
            this.dgvAgroEnterprises = new System.Windows.Forms.DataGridView();
            this.tbDataFileName = new System.Windows.Forms.MaskedTextBox();
            this.tbLogPath = new System.Windows.Forms.MaskedTextBox();
            this.FileOpeningProgress = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgroEnterprises)).BeginInit();
            this.SuspendLayout();
            // 
            // MMenu
            // 
            this.MMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmEnterprises});
            this.MMenu.Location = new System.Drawing.Point(0, 0);
            this.MMenu.Name = "MMenu";
            this.MMenu.Size = new System.Drawing.Size(800, 24);
            this.MMenu.TabIndex = 0;
            this.MMenu.Text = "menuStrip1";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnExit,
            this.mnOpen});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(48, 20);
            this.mmFile.Text = "Файл";
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(121, 22);
            this.mnExit.Text = "Выход";
            this.mnExit.Click += new System.EventHandler(this.MnExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(121, 22);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.MnOpen_Click);
            // 
            // mmEnterprises
            // 
            this.mmEnterprises.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenEnterPrise});
            this.mmEnterprises.Name = "mmEnterprises";
            this.mmEnterprises.Size = new System.Drawing.Size(92, 20);
            this.mmEnterprises.Text = "Предприятия";
            // 
            // mnOpenEnterPrise
            // 
            this.mnOpenEnterPrise.Name = "mnOpenEnterPrise";
            this.mnOpenEnterPrise.Size = new System.Drawing.Size(195, 22);
            this.mnOpenEnterPrise.Text = "Открыть предприятие";
            this.mnOpenEnterPrise.Click += new System.EventHandler(this.MnOpenEnterPrise_Click);
            // 
            // SStatus
            // 
            this.SStatus.Location = new System.Drawing.Point(0, 428);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(800, 22);
            this.SStatus.TabIndex = 1;
            this.SStatus.Text = "statusStrip1";
            // 
            // dgvAgroEnterprises
            // 
            this.dgvAgroEnterprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgroEnterprises.Location = new System.Drawing.Point(17, 41);
            this.dgvAgroEnterprises.Name = "dgvAgroEnterprises";
            this.dgvAgroEnterprises.Size = new System.Drawing.Size(240, 150);
            this.dgvAgroEnterprises.TabIndex = 2;
            // 
            // tbDataFileName
            // 
            this.tbDataFileName.Location = new System.Drawing.Point(17, 305);
            this.tbDataFileName.Name = "tbDataFileName";
            this.tbDataFileName.Size = new System.Drawing.Size(100, 20);
            this.tbDataFileName.TabIndex = 4;
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(17, 268);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.Size = new System.Drawing.Size(100, 20);
            this.tbLogPath.TabIndex = 5;
            // 
            // FileOpeningProgress
            // 
            this.FileOpeningProgress.Location = new System.Drawing.Point(17, 402);
            this.FileOpeningProgress.Name = "FileOpeningProgress";
            this.FileOpeningProgress.Size = new System.Drawing.Size(144, 23);
            this.FileOpeningProgress.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Прогресс открытия файла";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileOpeningProgress);
            this.Controls.Add(this.tbLogPath);
            this.Controls.Add(this.tbDataFileName);
            this.Controls.Add(this.dgvAgroEnterprises);
            this.Controls.Add(this.SStatus);
            this.Controls.Add(this.MMenu);
            this.MainMenuStrip = this.MMenu;
            this.Name = "FrmMain";
            this.Text = "КПО:4162 Вдовичев";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MMenu.ResumeLayout(false);
            this.MMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgroEnterprises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MMenu;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.StatusStrip SStatus;
        private System.Windows.Forms.DataGridView dgvAgroEnterprises;
        private System.Windows.Forms.ToolStripMenuItem mmEnterprises;
        private System.Windows.Forms.ToolStripMenuItem mnOpenEnterPrise;
        private System.Windows.Forms.MaskedTextBox tbDataFileName;
        private System.Windows.Forms.MaskedTextBox tbLogPath;
        private System.Windows.Forms.ProgressBar FileOpeningProgress;
        private System.Windows.Forms.Label label1;
    }
}

