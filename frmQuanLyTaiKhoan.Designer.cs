namespace AutoNgoalongMRD
{
    partial class frmQuanLyTaiKhoan
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
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHoTro = new System.Windows.Forms.Button();
            this.btnHuyLuuTaiKhoan = new System.Windows.Forms.Button();
            this.btnLuuTaiKhoan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(61, 19);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(156, 20);
            this.txbUser.TabIndex = 1;
            this.txbUser.Validating += new System.ComponentModel.CancelEventHandler(this.txbUser_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHoTro);
            this.groupBox1.Controls.Add(this.btnHuyLuuTaiKhoan);
            this.groupBox1.Controls.Add(this.btnLuuTaiKhoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbServer);
            this.groupBox1.Controls.Add(this.txbPass);
            this.groupBox1.Controls.Add(this.txbUser);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // btnHoTro
            // 
            this.btnHoTro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoTro.ForeColor = System.Drawing.Color.Red;
            this.btnHoTro.Location = new System.Drawing.Point(181, 98);
            this.btnHoTro.Name = "btnHoTro";
            this.btnHoTro.Size = new System.Drawing.Size(36, 23);
            this.btnHoTro.TabIndex = 8;
            this.btnHoTro.Text = "?";
            this.btnHoTro.UseVisualStyleBackColor = true;
            this.btnHoTro.Click += new System.EventHandler(this.btnHoTro_Click);
            // 
            // btnHuyLuuTaiKhoan
            // 
            this.btnHuyLuuTaiKhoan.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuyLuuTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHuyLuuTaiKhoan.Location = new System.Drawing.Point(121, 98);
            this.btnHuyLuuTaiKhoan.Name = "btnHuyLuuTaiKhoan";
            this.btnHuyLuuTaiKhoan.Size = new System.Drawing.Size(54, 23);
            this.btnHuyLuuTaiKhoan.TabIndex = 7;
            this.btnHuyLuuTaiKhoan.Text = "Hủy";
            this.btnHuyLuuTaiKhoan.UseVisualStyleBackColor = true;
            this.btnHuyLuuTaiKhoan.Click += new System.EventHandler(this.btnHuyLuuTaiKhoan_Click);
            // 
            // btnLuuTaiKhoan
            // 
            this.btnLuuTaiKhoan.Enabled = false;
            this.btnLuuTaiKhoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuuTaiKhoan.Location = new System.Drawing.Point(10, 98);
            this.btnLuuTaiKhoan.Name = "btnLuuTaiKhoan";
            this.btnLuuTaiKhoan.Size = new System.Drawing.Size(97, 23);
            this.btnLuuTaiKhoan.TabIndex = 6;
            this.btnLuuTaiKhoan.Text = "Lưu/Thêm";
            this.btnLuuTaiKhoan.UseVisualStyleBackColor = true;
            this.btnLuuTaiKhoan.Click += new System.EventHandler(this.btnLuuTaiKhoan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pass:";
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(61, 71);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(156, 20);
            this.txbServer.TabIndex = 5;
            this.txbServer.Text = "http://s1.ngoalong4v.com/user";
            this.txbServer.Validating += new System.ComponentModel.CancelEventHandler(this.txbServer_Validating);
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(61, 45);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(156, 20);
            this.txbPass.TabIndex = 3;
            this.txbPass.Validating += new System.ComponentModel.CancelEventHandler(this.txbPass_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AcceptButton = this.btnLuuTaiKhoan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuyLuuTaiKhoan;
            this.ClientSize = new System.Drawing.Size(235, 135);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQuanLyTaiKhoan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tài khoản";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Button btnHuyLuuTaiKhoan;
        private System.Windows.Forms.Button btnLuuTaiKhoan;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnHoTro;
    }
}