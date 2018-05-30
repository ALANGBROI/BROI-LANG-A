namespace Quanlysv
{
    partial class Frmtimkiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmtimkiem));
            this.txtnhapthongtin = new System.Windows.Forms.TextBox();
            this.lblnhapthongtin = new System.Windows.Forms.Label();
            this.chktheoma = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntrolai = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.chktheoten = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnhapthongtin
            // 
            this.txtnhapthongtin.Location = new System.Drawing.Point(15, 60);
            this.txtnhapthongtin.Margin = new System.Windows.Forms.Padding(2);
            this.txtnhapthongtin.Name = "txtnhapthongtin";
            this.txtnhapthongtin.Size = new System.Drawing.Size(204, 26);
            this.txtnhapthongtin.TabIndex = 0;
            // 
            // lblnhapthongtin
            // 
            this.lblnhapthongtin.AutoSize = true;
            this.lblnhapthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblnhapthongtin.Location = new System.Drawing.Point(11, 19);
            this.lblnhapthongtin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnhapthongtin.Name = "lblnhapthongtin";
            this.lblnhapthongtin.Size = new System.Drawing.Size(209, 20);
            this.lblnhapthongtin.TabIndex = 1;
            this.lblnhapthongtin.Text = "Nhập thông tin SV cần tìm:";
            // 
            // chktheoma
            // 
            this.chktheoma.AutoSize = true;
            this.chktheoma.Location = new System.Drawing.Point(259, 102);
            this.chktheoma.Name = "chktheoma";
            this.chktheoma.Size = new System.Drawing.Size(126, 24);
            this.chktheoma.TabIndex = 2;
            this.chktheoma.Text = "Tìm theo mã ";
            this.chktheoma.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 124);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(543, 15);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(102, 47);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntrolai
            // 
            this.btntrolai.Image = ((System.Drawing.Image)(resources.GetObject("btntrolai.Image")));
            this.btntrolai.Location = new System.Drawing.Point(484, 79);
            this.btntrolai.Name = "btntrolai";
            this.btntrolai.Size = new System.Drawing.Size(102, 47);
            this.btntrolai.TabIndex = 4;
            this.btntrolai.UseVisualStyleBackColor = true;
            this.btntrolai.Click += new System.EventHandler(this.btntrolai_Click);
            // 
            // btntim
            // 
            this.btntim.Image = ((System.Drawing.Image)(resources.GetObject("btntim.Image")));
            this.btntim.Location = new System.Drawing.Point(435, 15);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(102, 47);
            this.btntim.TabIndex = 4;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // chktheoten
            // 
            this.chktheoten.AutoSize = true;
            this.chktheoten.Location = new System.Drawing.Point(259, 49);
            this.chktheoten.Name = "chktheoten";
            this.chktheoten.Size = new System.Drawing.Size(121, 24);
            this.chktheoten.TabIndex = 5;
            this.chktheoten.Text = "Tìm theo tên";
            this.chktheoten.UseVisualStyleBackColor = true;
            // 
            // Frmtimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(644, 306);
            this.Controls.Add(this.chktheoten);
            this.Controls.Add(this.btntrolai);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chktheoma);
            this.Controls.Add(this.lblnhapthongtin);
            this.Controls.Add(this.txtnhapthongtin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmtimkiem";
            this.Text = "Tìm kiếm SV";
            this.Load += new System.EventHandler(this.Frmtimkiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhapthongtin;
        private System.Windows.Forms.Label lblnhapthongtin;
        private System.Windows.Forms.CheckBox chktheoma;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntrolai;
        private System.Windows.Forms.CheckBox chktheoten;
    }
}