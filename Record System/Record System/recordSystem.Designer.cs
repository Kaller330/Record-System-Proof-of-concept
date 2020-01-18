namespace Record_System
{
    partial class recordSystem
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
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativeOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roleManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.auditingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrativeOptionsToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // administrativeOptionsToolStripMenuItem
            // 
            this.administrativeOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roleManagerToolStripMenuItem,
            this.userManagerToolStripMenuItem,
            this.modulesToolStripMenuItem});
            this.administrativeOptionsToolStripMenuItem.Name = "administrativeOptionsToolStripMenuItem";
            this.administrativeOptionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.administrativeOptionsToolStripMenuItem.Text = "Administrative Options";
            // 
            // roleManagerToolStripMenuItem
            // 
            this.roleManagerToolStripMenuItem.Name = "roleManagerToolStripMenuItem";
            this.roleManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roleManagerToolStripMenuItem.Text = "Role Manager";
            // 
            // userManagerToolStripMenuItem
            // 
            this.userManagerToolStripMenuItem.Name = "userManagerToolStripMenuItem";
            this.userManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userManagerToolStripMenuItem.Text = "User Manager";
            // 
            // modulesToolStripMenuItem
            // 
            this.modulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageModulesToolStripMenuItem});
            this.modulesToolStripMenuItem.Name = "modulesToolStripMenuItem";
            this.modulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modulesToolStripMenuItem.Text = "Modules";
            // 
            // manageModulesToolStripMenuItem
            // 
            this.manageModulesToolStripMenuItem.Name = "manageModulesToolStripMenuItem";
            this.manageModulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageModulesToolStripMenuItem.Text = "Manage Modules";
            // 
            // auditingToolStripMenuItem
            // 
            this.auditingToolStripMenuItem.Name = "auditingToolStripMenuItem";
            this.auditingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.auditingToolStripMenuItem.Text = "Auditing";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(454, 112);
            this.button1.TabIndex = 1;
            this.button1.Text = "big ol connection test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recordSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "recordSystem";
            this.Text = "Record System";
            this.Load += new System.EventHandler(this.recordSystem_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrativeOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roleManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditingToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

