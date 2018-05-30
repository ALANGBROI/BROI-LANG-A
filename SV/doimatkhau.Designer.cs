namespace Quanlysv
{
    partial class frmdoimatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdoimatkhau));
            this.lblmakhaucu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatkhaucu = new System.Windows.Forms.TextBox();
            this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.btChange = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btntrolai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmakhaucu
            // 
            this.lblmakhaucu.AutoSize = true;
            this.lblmakhaucu.BackColor = System.Drawing.Color.Cyan;
            this.lblmakhaucu.Location = new System.Drawing.Point(48, 76);
            this.lblmakhaucu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmakhaucu.Name = "lblmakhaucu";
            this.lblmakhaucu.Size = new System.Drawing.Size(107, 20);
            this.lblmakhaucu.TabIndex = 0;
            this.lblmakhaucu.Text = "Mật khẩu cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(48, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(14, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "xác nhận lại mật khẩu";
            // 
            // txtmatkhaucu
            // 
            this.txtmatkhaucu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtmatkhaucu.Location = new System.Drawing.Point(226, 73);
            this.txtmatkhaucu.Name = "txtmatkhaucu";
            this.txtmatkhaucu.PasswordChar = '*';
            this.txtmatkhaucu.Size = new System.Drawing.Size(166, 26);
            this.txtmatkhaucu.TabIndex = 1;
            // 
            // txtmatkhaumoi
            // 
            this.txtmatkhaumoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtmatkhaumoi.Location = new System.Drawing.Point(226, 135);
            this.txtmatkhaumoi.Name = "txtmatkhaumoi";
            this.txtmatkhaumoi.PasswordChar = '*';
            this.txtmatkhaumoi.Size = new System.Drawing.Size(166, 26);
            this.txtmatkhaumoi.TabIndex = 1;
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtxacnhan.Location = new System.Drawing.Point(226, 187);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.PasswordChar = '*';
            this.txtxacnhan.Size = new System.Drawing.Size(166, 26);
            this.txtxacnhan.TabIndex = 1;
            // 
            // btChange
            // 
            this.btChange.BackColor = System.Drawing.Color.Cyan;
            this.btChange.Location = new System.Drawing.Point(117, 295);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(96, 33);
            this.btChange.TabIndex = 2;
            this.btChange.Text = "Thay đổi";
            this.btChange.UseVisualStyleBackColor = false;
            this.btChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Cyan;
            this.btCancel.Location = new System.Drawing.Point(276, 295);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(96, 33);
            this.btCancel.TabIndex = 3;
            this.btCancel.Text = "Thoát";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btntrolai
            // 
            this.btntrolai.BackColor = System.Drawing.Color.Cyan;
            this.btntrolai.Image = ((System.Drawing.Image)(resources.GetObject("btntrolai.Image")));
            this.btntrolai.Location = new System.Drawing.Point(0, 1);
            this.btntrolai.Name = "btntrolai";
            this.btntrolai.Size = new System.Drawing.Size(84, 39);
            this.btntrolai.TabIndex = 4;
            this.btntrolai.UseVisualStyleBackColor = false;
            this.btntrolai.Click += new System.EventHandler(this.btntrolai_Click);
            // 
            // frmdoimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(459, 390);
            this.Controls.Add(this.btntrolai);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.txtxacnhan);
            this.Controls.Add(this.txtmatkhaumoi);
            this.Controls.Add(this.txtmatkhaucu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmakhaucu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdoimatkhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmdoimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmakhaucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatkhaucu;
        private System.Windows.Forms.TextBox txtmatkhaumoi;
        private System.Windows.Forms.TextBox txtxacnhan;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btntrolai;
    }
}