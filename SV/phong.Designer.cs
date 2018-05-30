namespace Quanlysv
{
    partial class Frmphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmphong));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblphong = new System.Windows.Forms.Label();
            this.lblkhu = new System.Windows.Forms.Label();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.lbltinhtrang = new System.Windows.Forms.Label();
            this.txttinhtrang = new System.Windows.Forms.TextBox();
            this.txtphong = new System.Windows.Forms.TextBox();
            this.txtkhunha = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btntrolai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.cbokhunha = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 153);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblphong
            // 
            this.lblphong.AutoSize = true;
            this.lblphong.BackColor = System.Drawing.Color.Aquamarine;
            this.lblphong.ForeColor = System.Drawing.Color.Black;
            this.lblphong.Location = new System.Drawing.Point(-2, 177);
            this.lblphong.Name = "lblphong";
            this.lblphong.Size = new System.Drawing.Size(56, 20);
            this.lblphong.TabIndex = 1;
            this.lblphong.Text = "Phòng";
            this.lblphong.Click += new System.EventHandler(this.lblphong_Click);
            // 
            // lblkhu
            // 
            this.lblkhu.AutoSize = true;
            this.lblkhu.BackColor = System.Drawing.Color.Aquamarine;
            this.lblkhu.ForeColor = System.Drawing.Color.Black;
            this.lblkhu.Location = new System.Drawing.Point(162, 265);
            this.lblkhu.Name = "lblkhu";
            this.lblkhu.Size = new System.Drawing.Size(70, 20);
            this.lblkhu.TabIndex = 1;
            this.lblkhu.Text = "Khu nhà";
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.BackColor = System.Drawing.Color.Aquamarine;
            this.lblsoluong.Location = new System.Drawing.Point(148, 177);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(74, 20);
            this.lblsoluong.TabIndex = 1;
            this.lblsoluong.Text = "Số lượng";
            // 
            // lbltinhtrang
            // 
            this.lbltinhtrang.AutoSize = true;
            this.lbltinhtrang.BackColor = System.Drawing.Color.Aquamarine;
            this.lbltinhtrang.ForeColor = System.Drawing.Color.Black;
            this.lbltinhtrang.Location = new System.Drawing.Point(-2, 265);
            this.lbltinhtrang.Name = "lbltinhtrang";
            this.lbltinhtrang.Size = new System.Drawing.Size(134, 20);
            this.lbltinhtrang.TabIndex = 1;
            this.lbltinhtrang.Text = "Tình trạng phòng";
            // 
            // txttinhtrang
            // 
            this.txttinhtrang.Location = new System.Drawing.Point(2, 301);
            this.txttinhtrang.Name = "txttinhtrang";
            this.txttinhtrang.Size = new System.Drawing.Size(130, 26);
            this.txttinhtrang.TabIndex = 2;
            // 
            // txtphong
            // 
            this.txtphong.Location = new System.Drawing.Point(2, 211);
            this.txtphong.Name = "txtphong";
            this.txtphong.Size = new System.Drawing.Size(130, 26);
            this.txtphong.TabIndex = 2;
            // 
            // txtkhunha
            // 
            this.txtkhunha.Location = new System.Drawing.Point(152, 301);
            this.txtkhunha.Name = "txtkhunha";
            this.txtkhunha.Size = new System.Drawing.Size(130, 26);
            this.txtkhunha.TabIndex = 2;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(152, 211);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(130, 26);
            this.txtsoluong.TabIndex = 2;
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(33, 364);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(99, 39);
            this.btnthem.TabIndex = 3;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Image = ((System.Drawing.Image)(resources.GetObject("btnluu.Image")));
            this.btnluu.Location = new System.Drawing.Point(183, 366);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(99, 39);
            this.btnluu.TabIndex = 3;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btntrolai
            // 
            this.btntrolai.Image = ((System.Drawing.Image)(resources.GetObject("btntrolai.Image")));
            this.btntrolai.Location = new System.Drawing.Point(452, 366);
            this.btntrolai.Name = "btntrolai";
            this.btntrolai.Size = new System.Drawing.Size(99, 39);
            this.btntrolai.TabIndex = 3;
            this.btntrolai.UseVisualStyleBackColor = true;
            this.btntrolai.Click += new System.EventHandler(this.btntrolai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.Location = new System.Drawing.Point(452, 301);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(99, 40);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(335, 364);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(99, 42);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(335, 301);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(99, 40);
            this.btnsua.TabIndex = 4;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // cbokhunha
            // 
            this.cbokhunha.FormattingEnabled = true;
            this.cbokhunha.Location = new System.Drawing.Point(152, 301);
            this.cbokhunha.Name = "cbokhunha";
            this.cbokhunha.Size = new System.Drawing.Size(130, 28);
            this.cbokhunha.TabIndex = 5;
            // 
            // Frmphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(563, 424);
            this.Controls.Add(this.cbokhunha);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntrolai);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtkhunha);
            this.Controls.Add(this.txtphong);
            this.Controls.Add(this.txttinhtrang);
            this.Controls.Add(this.lbltinhtrang);
            this.Controls.Add(this.lblsoluong);
            this.Controls.Add(this.lblkhu);
            this.Controls.Add(this.lblphong);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmphong";
            this.Text = "Phòng";
            this.Load += new System.EventHandler(this.Frmphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblphong;
        private System.Windows.Forms.Label lblkhu;
        private System.Windows.Forms.Label lblsoluong;
        private System.Windows.Forms.Label lbltinhtrang;
        private System.Windows.Forms.TextBox txttinhtrang;
        private System.Windows.Forms.TextBox txtphong;
        private System.Windows.Forms.TextBox txtkhunha;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btntrolai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.ComboBox cbokhunha;
    }
}