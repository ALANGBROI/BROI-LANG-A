namespace Quanlysv
{
    partial class Frmquanlysv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmquanlysv));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khuNhàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hợpĐồngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkViolet;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.khuNhàToolStripMenuItem,
            this.hợpĐồngToolStripMenuItem,
            this.tìmKiếmToolStripMenuItem,
            this.phòngToolStripMenuItem,
            this.tácGiảToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.BackColor = System.Drawing.Color.DarkViolet;
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.dangxuatToolStripMenuItem});
            this.hethongToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.hethongToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangxuatToolStripMenuItem
            // 
            this.dangxuatToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.dangxuatToolStripMenuItem.Name = "dangxuatToolStripMenuItem";
            this.dangxuatToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.dangxuatToolStripMenuItem.Text = "Đăng xuất hệ thống";
            this.dangxuatToolStripMenuItem.Click += new System.EventHandler(this.hợpĐồngToolStripMenuItem_Click);
            // 
            // khuNhàToolStripMenuItem
            // 
            this.khuNhàToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem1});
            this.khuNhàToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.khuNhàToolStripMenuItem.Name = "khuNhàToolStripMenuItem";
            this.khuNhàToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.khuNhàToolStripMenuItem.Text = "Sinh viên";
            this.khuNhàToolStripMenuItem.Click += new System.EventHandler(this.khuNhàToolStripMenuItem_Click);
            // 
            // thêmToolStripMenuItem1
            // 
            this.thêmToolStripMenuItem1.BackColor = System.Drawing.Color.Cyan;
            this.thêmToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thêmToolStripMenuItem1.Name = "thêmToolStripMenuItem1";
            this.thêmToolStripMenuItem1.Size = new System.Drawing.Size(152, 30);
            this.thêmToolStripMenuItem1.Text = "Xem";
            this.thêmToolStripMenuItem1.Click += new System.EventHandler(this.thêmToolStripMenuItem1_Click);
            // 
            // hợpĐồngToolStripMenuItem
            // 
            this.hợpĐồngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem});
            this.hợpĐồngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.hợpĐồngToolStripMenuItem.Name = "hợpĐồngToolStripMenuItem";
            this.hợpĐồngToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.hợpĐồngToolStripMenuItem.Text = "Hợp đồng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.BackColor = System.Drawing.Color.Cyan;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.thêmToolStripMenuItem.Text = "Xem";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            this.tìmKiếmToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.phòngToolStripMenuItem.Text = "Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.tácGiảToolStripMenuItem.Text = "Tác giả";
            this.tácGiảToolStripMenuItem.Click += new System.EventHandler(this.tácGiảToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
            this.đổiMậtKhẩuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(254, 30);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // Frmquanlysv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(601, 482);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmquanlysv";
            this.Text = "Quản lý KTX Trường ĐH Quảng Nam";
            this.Load += new System.EventHandler(this.Frmquanlysv_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangxuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuNhàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hợpĐồngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
    }
}

