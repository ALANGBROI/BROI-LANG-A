namespace Quanlysv
{
    partial class frmtacgia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtacgia));
            this.lblname = new System.Windows.Forms.Label();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.lblquangnam = new System.Windows.Forms.Label();
            this.lblqn = new System.Windows.Forms.Label();
            this.btntrolai = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblname.Location = new System.Drawing.Point(335, 33);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(183, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "QUAN LY KY TUC XA";
            this.lblname.Click += new System.EventHandler(this.lblname_Click);
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblcopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblcopyright.Location = new System.Drawing.Point(335, 64);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(346, 40);
            this.lblcopyright.TabIndex = 1;
            this.lblcopyright.Text = "Copyright (c) 2017 \r\n A LANG BROI (alangbroi020@gmail.com)\r\n";
            this.lblcopyright.Click += new System.EventHandler(this.lblcopyright_Click);
            // 
            // lblquangnam
            // 
            this.lblquangnam.AutoSize = true;
            this.lblquangnam.Location = new System.Drawing.Point(234, 97);
            this.lblquangnam.Name = "lblquangnam";
            this.lblquangnam.Size = new System.Drawing.Size(0, 20);
            this.lblquangnam.TabIndex = 2;
            // 
            // lblqn
            // 
            this.lblqn.AutoSize = true;
            this.lblqn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblqn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqn.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblqn.Location = new System.Drawing.Point(335, 119);
            this.lblqn.Name = "lblqn";
            this.lblqn.Size = new System.Drawing.Size(234, 20);
            this.lblqn.TabIndex = 3;
            this.lblqn.Text = "QUANG NAM UNIVERSITY ";
            this.lblqn.Click += new System.EventHandler(this.lblqn_Click);
            // 
            // btntrolai
            // 
            this.btntrolai.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btntrolai.Image = ((System.Drawing.Image)(resources.GetObject("btntrolai.Image")));
            this.btntrolai.Location = new System.Drawing.Point(-1, 1);
            this.btntrolai.Name = "btntrolai";
            this.btntrolai.Size = new System.Drawing.Size(97, 38);
            this.btntrolai.TabIndex = 4;
            this.btntrolai.UseVisualStyleBackColor = false;
            this.btntrolai.Click += new System.EventHandler(this.btntrolai_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(356, 218);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 96);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Hướng dẫn\nMuốn sử dụng được, nhập thông tin sinh viên  trước và\nphòng  và sau tạo" +
    " hợp đồng sinh viên\n\n\n";
            // 
            // frmtacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 335);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btntrolai);
            this.Controls.Add(this.lblqn);
            this.Controls.Add(this.lblquangnam);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.lblname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmtacgia";
            this.Text = "Tác giả";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.Label lblquangnam;
        private System.Windows.Forms.Label lblqn;
        private System.Windows.Forms.Button btntrolai;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}