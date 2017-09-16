namespace Install
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataShow = new System.Windows.Forms.DataGridView();
            this.ButtonReview = new System.Windows.Forms.Button();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.CopyStatus = new System.Windows.Forms.Label();
            this.InstallStatus = new System.Windows.Forms.Label();
            this.TBoxStatus = new System.Windows.Forms.ListView();
            this.Application = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadConfigFileToolStripMenuItem,
            this.addProgramToolStripMenuItem,
            this.editProgramToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadConfigFileToolStripMenuItem
            // 
            this.loadConfigFileToolStripMenuItem.Name = "loadConfigFileToolStripMenuItem";
            this.loadConfigFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.loadConfigFileToolStripMenuItem.Text = "Load Config File";
            // 
            // addProgramToolStripMenuItem
            // 
            this.addProgramToolStripMenuItem.Name = "addProgramToolStripMenuItem";
            this.addProgramToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addProgramToolStripMenuItem.Text = "Add Program";
            this.addProgramToolStripMenuItem.Click += new System.EventHandler(this.addProgramToolStripMenuItem_Click);
            // 
            // editProgramToolStripMenuItem
            // 
            this.editProgramToolStripMenuItem.Name = "editProgramToolStripMenuItem";
            this.editProgramToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editProgramToolStripMenuItem.Text = "Edit Program";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // versToolStripMenuItem
            // 
            this.versToolStripMenuItem.Name = "versToolStripMenuItem";
            this.versToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.versToolStripMenuItem.Text = "About";
            this.versToolStripMenuItem.Click += new System.EventHandler(this.versToolStripMenuItem_Click);
            // 
            // DataShow
            // 
            this.DataShow.AllowUserToAddRows = false;
            this.DataShow.AllowUserToDeleteRows = false;
            this.DataShow.AllowUserToResizeColumns = false;
            this.DataShow.AllowUserToResizeRows = false;
            this.DataShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataShow.Location = new System.Drawing.Point(12, 61);
            this.DataShow.Name = "DataShow";
            this.DataShow.Size = new System.Drawing.Size(611, 311);
            this.DataShow.TabIndex = 1;
            // 
            // ButtonReview
            // 
            this.ButtonReview.Location = new System.Drawing.Point(639, 61);
            this.ButtonReview.Name = "ButtonReview";
            this.ButtonReview.Size = new System.Drawing.Size(100, 37);
            this.ButtonReview.TabIndex = 2;
            this.ButtonReview.Text = "Review Install";
            this.ButtonReview.UseVisualStyleBackColor = true;
            this.ButtonReview.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.Location = new System.Drawing.Point(639, 60);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Size = new System.Drawing.Size(100, 37);
            this.ButtonInstall.TabIndex = 3;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.UseVisualStyleBackColor = true;
            this.ButtonInstall.Visible = false;
            this.ButtonInstall.Click += new System.EventHandler(this.ButtonInstall_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(639, 115);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 37);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Visible = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CopyStatus
            // 
            this.CopyStatus.AutoSize = true;
            this.CopyStatus.Location = new System.Drawing.Point(36, 84);
            this.CopyStatus.Name = "CopyStatus";
            this.CopyStatus.Size = new System.Drawing.Size(48, 13);
            this.CopyStatus.TabIndex = 5;
            this.CopyStatus.Text = "Installing";
            this.CopyStatus.Visible = false;
            // 
            // InstallStatus
            // 
            this.InstallStatus.AutoSize = true;
            this.InstallStatus.Location = new System.Drawing.Point(36, 127);
            this.InstallStatus.Name = "InstallStatus";
            this.InstallStatus.Size = new System.Drawing.Size(48, 13);
            this.InstallStatus.TabIndex = 6;
            this.InstallStatus.Text = "Installing";
            this.InstallStatus.Visible = false;
            // 
            // TBoxStatus
            // 
            this.TBoxStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Application,
            this.Status});
            this.TBoxStatus.Location = new System.Drawing.Point(24, 143);
            this.TBoxStatus.Name = "TBoxStatus";
            this.TBoxStatus.Size = new System.Drawing.Size(584, 229);
            this.TBoxStatus.TabIndex = 7;
            this.TBoxStatus.UseCompatibleStateImageBehavior = false;
            this.TBoxStatus.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 395);
            this.Controls.Add(this.TBoxStatus);
            this.Controls.Add(this.InstallStatus);
            this.Controls.Add(this.CopyStatus);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonInstall);
            this.Controls.Add(this.ButtonReview);
            this.Controls.Add(this.DataShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProgramToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataShow;
        private System.Windows.Forms.ToolStripMenuItem editProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versToolStripMenuItem;
        private System.Windows.Forms.Button ButtonReview;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label CopyStatus;
        private System.Windows.Forms.Label InstallStatus;
        private System.Windows.Forms.ListView TBoxStatus;
        private System.Windows.Forms.ColumnHeader Application;
        private System.Windows.Forms.ColumnHeader Status;
    }
}

