namespace VirtualMachineAutomation
{
    partial class MdiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newVirtualMachineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newVirtualMachineToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newVirtualMachineToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVirtualMachineToolStripMenuItem1,
            this.newVirtualMachineToolStripMenuItem2,
            this.newVirtualMachineToolStripMenuItem3});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newVirtualMachineToolStripMenuItem1
            // 
            this.newVirtualMachineToolStripMenuItem1.Name = "newVirtualMachineToolStripMenuItem1";
            this.newVirtualMachineToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.newVirtualMachineToolStripMenuItem1.Text = "New Virtual Machine..";
            this.newVirtualMachineToolStripMenuItem1.Click += new System.EventHandler(this.menuNewVirtualMachine_Click);
            // 
            // newVirtualMachineToolStripMenuItem2
            // 
            this.newVirtualMachineToolStripMenuItem2.Name = "newVirtualMachineToolStripMenuItem2";
            this.newVirtualMachineToolStripMenuItem2.Size = new System.Drawing.Size(211, 22);
            this.newVirtualMachineToolStripMenuItem2.Text = "Upgrade Virtual Machine..";
            this.newVirtualMachineToolStripMenuItem2.Click += new System.EventHandler(this.menuUpgradeVirtualMachine_Click);
            // 
            // newVirtualMachineToolStripMenuItem3
            // 
            this.newVirtualMachineToolStripMenuItem3.Name = "newVirtualMachineToolStripMenuItem3";
            this.newVirtualMachineToolStripMenuItem3.Size = new System.Drawing.Size(211, 22);
            this.newVirtualMachineToolStripMenuItem3.Text = "Remove Virtual Machine..";
            this.newVirtualMachineToolStripMenuItem3.Click += new System.EventHandler(this.menuRemoveVirtualMachine_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.Help_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MdiForm";
            this.Text = "Virtual Machine Automation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVirtualMachineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newVirtualMachineToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newVirtualMachineToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}