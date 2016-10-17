namespace SMManagement
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
            this.components = new System.ComponentModel.Container();
            this.hehotn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLTKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLBHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hehotn
            // 
            this.hehotn.Name = "contextMenuStrip1";
            this.hehotn.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLTKToolStripMenuItem,
            this.QLBHToolStripMenuItem,
            this.QLKToolStripMenuItem,
            this.QLKHToolStripMenuItem});
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hethongToolStripMenuItem.Text = "Hệ thống";
            // 
            // QLTKToolStripMenuItem
            // 
            this.QLTKToolStripMenuItem.Name = "QLTKToolStripMenuItem";
            this.QLTKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLTKToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // QLBHToolStripMenuItem
            // 
            this.QLBHToolStripMenuItem.Name = "QLBHToolStripMenuItem";
            this.QLBHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLBHToolStripMenuItem.Text = "Quản lý bán hàng";
            // 
            // QLKToolStripMenuItem
            // 
            this.QLKToolStripMenuItem.Name = "QLKToolStripMenuItem";
            this.QLKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLKToolStripMenuItem.Text = "Quản lý kho";
            // 
            // QLKHToolStripMenuItem
            // 
            this.QLKHToolStripMenuItem.Name = "QLKHToolStripMenuItem";
            this.QLKHToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QLKHToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip hehotn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLTKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLBHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLKHToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

