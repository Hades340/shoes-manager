namespace DoAnNet001.Views.ucCaiDat
{
    partial class DoiMatKhau_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MKHienTai = new System.Windows.Forms.TextBox();
            this.txt_NewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NhapLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại:";
            // 
            // txt_MKHienTai
            // 
            this.txt_MKHienTai.Location = new System.Drawing.Point(371, 122);
            this.txt_MKHienTai.Name = "txt_MKHienTai";
            this.txt_MKHienTai.PasswordChar = '*';
            this.txt_MKHienTai.Size = new System.Drawing.Size(156, 20);
            this.txt_MKHienTai.TabIndex = 1;
            // 
            // txt_NewPass
            // 
            this.txt_NewPass.Location = new System.Drawing.Point(371, 164);
            this.txt_NewPass.Name = "txt_NewPass";
            this.txt_NewPass.PasswordChar = '*';
            this.txt_NewPass.Size = new System.Drawing.Size(156, 20);
            this.txt_NewPass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txt_NhapLai
            // 
            this.txt_NhapLai.Location = new System.Drawing.Point(371, 213);
            this.txt_NhapLai.Name = "txt_NhapLai";
            this.txt_NhapLai.PasswordChar = '*';
            this.txt_NhapLai.Size = new System.Drawing.Size(156, 20);
            this.txt_NhapLai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(438, 254);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(89, 23);
            this.btn_Luu.TabIndex = 6;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // DoiMatKhau_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_NhapLai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MKHienTai);
            this.Controls.Add(this.label1);
            this.Name = "DoiMatKhau_uc";
            this.Size = new System.Drawing.Size(978, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MKHienTai;
        private System.Windows.Forms.TextBox txt_NewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NhapLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Luu;
    }
}
