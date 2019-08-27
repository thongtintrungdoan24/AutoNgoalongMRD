namespace AutoNgoalongMRD
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grbDanhSachTaiKhoan = new System.Windows.Forms.GroupBox();
            this.lsbTaiKhoan = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStrip_btnThem = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_btnSua = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_btnTroGiup = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip_btnAnAuto = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_btnDungAuto = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_btnChayAuto = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_lblDangChay = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip_lblDangAn = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuCaiDat = new System.Windows.Forms.Button();
            this.numThapThiLuyen = new System.Windows.Forms.NumericUpDown();
            this.numTinhTu = new System.Windows.Forms.NumericUpDown();
            this.numPhaiTrangBi = new System.Windows.Forms.NumericUpDown();
            this.numThamBao = new System.Windows.Forms.NumericUpDown();
            this.numVoKhoiThap = new System.Windows.Forms.NumericUpDown();
            this.ckbThapThiLuyen = new System.Windows.Forms.CheckBox();
            this.ckbTinhTu = new System.Windows.Forms.CheckBox();
            this.ckbPhaiTrangBi = new System.Windows.Forms.CheckBox();
            this.ckbThamBao = new System.Windows.Forms.CheckBox();
            this.ckbVoKhoiThap = new System.Windows.Forms.CheckBox();
            this.grpTacGia = new System.Windows.Forms.GroupBox();
            this.linkDonation = new System.Windows.Forms.LinkLabel();
            this.linkSource = new System.Windows.Forms.LinkLabel();
            this.linkFanpage = new System.Windows.Forms.LinkLabel();
            this.grbDanhSachTaiKhoan.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThapThiLuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTinhTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhaiTrangBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThamBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoKhoiThap)).BeginInit();
            this.grpTacGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhSachTaiKhoan
            // 
            this.grbDanhSachTaiKhoan.Controls.Add(this.lsbTaiKhoan);
            this.grbDanhSachTaiKhoan.Controls.Add(this.toolStrip);
            this.grbDanhSachTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhSachTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhSachTaiKhoan.Location = new System.Drawing.Point(1, 2);
            this.grbDanhSachTaiKhoan.Name = "grbDanhSachTaiKhoan";
            this.grbDanhSachTaiKhoan.Size = new System.Drawing.Size(236, 146);
            this.grbDanhSachTaiKhoan.TabIndex = 0;
            this.grbDanhSachTaiKhoan.TabStop = false;
            this.grbDanhSachTaiKhoan.Text = "Danh sách tài khoản";
            // 
            // lsbTaiKhoan
            // 
            this.lsbTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbTaiKhoan.FormattingEnabled = true;
            this.lsbTaiKhoan.Location = new System.Drawing.Point(3, 18);
            this.lsbTaiKhoan.Name = "lsbTaiKhoan";
            this.lsbTaiKhoan.Size = new System.Drawing.Size(230, 100);
            this.lsbTaiKhoan.TabIndex = 2;
            this.lsbTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.lsbTaiKhoan_SelectedIndexChanged);
            this.lsbTaiKhoan.DoubleClick += new System.EventHandler(this.lsbTaiKhoan_DoubleClick);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.CanOverflow = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_btnThem,
            this.toolStrip_btnSua,
            this.toolStrip_btnXoa,
            this.toolStripSeparator1,
            this.toolStrip_btnTroGiup,
            this.toolStripSeparator2,
            this.toolStrip_btnAnAuto,
            this.toolStrip_btnDungAuto,
            this.toolStrip_btnChayAuto,
            this.toolStrip_lblDangChay,
            this.toolStrip_lblDangAn});
            this.toolStrip.Location = new System.Drawing.Point(3, 118);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip.Size = new System.Drawing.Size(230, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStrip_btnThem
            // 
            this.toolStrip_btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btnThem.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btnThem.Image")));
            this.toolStrip_btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btnThem.Name = "toolStrip_btnThem";
            this.toolStrip_btnThem.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_btnThem.Text = "toolStripButton1";
            this.toolStrip_btnThem.ToolTipText = "Thêm tài khoản game";
            this.toolStrip_btnThem.Click += new System.EventHandler(this.toolStrip_btnThem_Click);
            // 
            // toolStrip_btnSua
            // 
            this.toolStrip_btnSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btnSua.Enabled = false;
            this.toolStrip_btnSua.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btnSua.Image")));
            this.toolStrip_btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btnSua.Name = "toolStrip_btnSua";
            this.toolStrip_btnSua.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_btnSua.Text = "toolStripButton2";
            this.toolStrip_btnSua.ToolTipText = "Tính năng này đang cập nhật|Sửa tài khoản game";
            this.toolStrip_btnSua.Click += new System.EventHandler(this.toolStrip_btnSua_Click);
            // 
            // toolStrip_btnXoa
            // 
            this.toolStrip_btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btnXoa.ForeColor = System.Drawing.Color.Red;
            this.toolStrip_btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btnXoa.Image")));
            this.toolStrip_btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btnXoa.Name = "toolStrip_btnXoa";
            this.toolStrip_btnXoa.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_btnXoa.Text = "toolStripButton3";
            this.toolStrip_btnXoa.ToolTipText = "Xóa tài khoản game";
            this.toolStrip_btnXoa.Click += new System.EventHandler(this.toolStrip_btnXoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_btnTroGiup
            // 
            this.toolStrip_btnTroGiup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btnTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btnTroGiup.Image")));
            this.toolStrip_btnTroGiup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btnTroGiup.Name = "toolStrip_btnTroGiup";
            this.toolStrip_btnTroGiup.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_btnTroGiup.Text = "toolStripButton1";
            this.toolStrip_btnTroGiup.ToolTipText = "Di chuyển chuột lên các button để biết tính năng chi tiết.";
            this.toolStrip_btnTroGiup.Click += new System.EventHandler(this.toolStrip_btnTroGiup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStrip_btnAnAuto
            // 
            this.toolStrip_btnAnAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btnAnAuto.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btnAnAuto.Image")));
            this.toolStrip_btnAnAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btnAnAuto.Name = "toolStrip_btnAnAuto";
            this.toolStrip_btnAnAuto.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_btnAnAuto.Text = "toolStripButton1";
            this.toolStrip_btnAnAuto.ToolTipText = "Ẩn auto với account đã được chọn";
            this.toolStrip_btnAnAuto.Click += new System.EventHandler(this.toolStrip_btnAnAuto_Click);
            // 
            // toolStrip_btnDungAuto
            // 
            this.toolStrip_btnDungAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btnDungAuto.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btnDungAuto.Image")));
            this.toolStrip_btnDungAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btnDungAuto.Name = "toolStrip_btnDungAuto";
            this.toolStrip_btnDungAuto.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_btnDungAuto.Text = "toolStripButton2";
            this.toolStrip_btnDungAuto.ToolTipText = "Dừng auto với account đã được chọn";
            this.toolStrip_btnDungAuto.Click += new System.EventHandler(this.toolStrip_btnDungAuto_Click);
            // 
            // toolStrip_btnChayAuto
            // 
            this.toolStrip_btnChayAuto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btnChayAuto.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_btnChayAuto.Image")));
            this.toolStrip_btnChayAuto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btnChayAuto.Name = "toolStrip_btnChayAuto";
            this.toolStrip_btnChayAuto.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_btnChayAuto.Text = "toolStripButton3";
            this.toolStrip_btnChayAuto.ToolTipText = "Chạy auto đối với account đã được chọn";
            this.toolStrip_btnChayAuto.Click += new System.EventHandler(this.toolStrip_btnChayAuto_Click);
            // 
            // toolStrip_lblDangChay
            // 
            this.toolStrip_lblDangChay.ForeColor = System.Drawing.Color.Red;
            this.toolStrip_lblDangChay.Name = "toolStrip_lblDangChay";
            this.toolStrip_lblDangChay.Size = new System.Drawing.Size(14, 22);
            this.toolStrip_lblDangChay.Text = "R";
            // 
            // toolStrip_lblDangAn
            // 
            this.toolStrip_lblDangAn.ForeColor = System.Drawing.Color.Red;
            this.toolStrip_lblDangAn.Name = "toolStrip_lblDangAn";
            this.toolStrip_lblDangAn.Size = new System.Drawing.Size(16, 22);
            this.toolStrip_lblDangAn.Text = "H";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLuuCaiDat);
            this.groupBox1.Controls.Add(this.numThapThiLuyen);
            this.groupBox1.Controls.Add(this.numTinhTu);
            this.groupBox1.Controls.Add(this.numPhaiTrangBi);
            this.groupBox1.Controls.Add(this.numThamBao);
            this.groupBox1.Controls.Add(this.numVoKhoiThap);
            this.groupBox1.Controls.Add(this.ckbThapThiLuyen);
            this.groupBox1.Controls.Add(this.ckbTinhTu);
            this.groupBox1.Controls.Add(this.ckbPhaiTrangBi);
            this.groupBox1.Controls.Add(this.ckbThamBao);
            this.groupBox1.Controls.Add(this.ckbVoKhoiThap);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(1, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các tính năng auto";
            // 
            // btnLuuCaiDat
            // 
            this.btnLuuCaiDat.Enabled = false;
            this.btnLuuCaiDat.Location = new System.Drawing.Point(161, 218);
            this.btnLuuCaiDat.Name = "btnLuuCaiDat";
            this.btnLuuCaiDat.Size = new System.Drawing.Size(75, 23);
            this.btnLuuCaiDat.TabIndex = 2;
            this.btnLuuCaiDat.Text = "Lưu cài đặt";
            this.btnLuuCaiDat.UseVisualStyleBackColor = true;
            this.btnLuuCaiDat.Click += new System.EventHandler(this.btnLuuCaiDat_Click);
            // 
            // numThapThiLuyen
            // 
            this.numThapThiLuyen.Location = new System.Drawing.Point(140, 112);
            this.numThapThiLuyen.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numThapThiLuyen.Name = "numThapThiLuyen";
            this.numThapThiLuyen.Size = new System.Drawing.Size(58, 22);
            this.numThapThiLuyen.TabIndex = 1;
            this.numThapThiLuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numTinhTu
            // 
            this.numTinhTu.Enabled = false;
            this.numTinhTu.Location = new System.Drawing.Point(140, 89);
            this.numTinhTu.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTinhTu.Name = "numTinhTu";
            this.numTinhTu.Size = new System.Drawing.Size(58, 22);
            this.numTinhTu.TabIndex = 1;
            this.numTinhTu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numPhaiTrangBi
            // 
            this.numPhaiTrangBi.Location = new System.Drawing.Point(140, 66);
            this.numPhaiTrangBi.Name = "numPhaiTrangBi";
            this.numPhaiTrangBi.Size = new System.Drawing.Size(58, 22);
            this.numPhaiTrangBi.TabIndex = 1;
            this.numPhaiTrangBi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numThamBao
            // 
            this.numThamBao.Location = new System.Drawing.Point(140, 43);
            this.numThamBao.Name = "numThamBao";
            this.numThamBao.Size = new System.Drawing.Size(58, 22);
            this.numThamBao.TabIndex = 1;
            this.numThamBao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numVoKhoiThap
            // 
            this.numVoKhoiThap.Location = new System.Drawing.Point(140, 20);
            this.numVoKhoiThap.Name = "numVoKhoiThap";
            this.numVoKhoiThap.Size = new System.Drawing.Size(58, 22);
            this.numVoKhoiThap.TabIndex = 1;
            this.numVoKhoiThap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbThapThiLuyen
            // 
            this.ckbThapThiLuyen.AutoSize = true;
            this.ckbThapThiLuyen.Location = new System.Drawing.Point(25, 115);
            this.ckbThapThiLuyen.Name = "ckbThapThiLuyen";
            this.ckbThapThiLuyen.Size = new System.Drawing.Size(99, 17);
            this.ckbThapThiLuyen.TabIndex = 0;
            this.ckbThapThiLuyen.Text = "Tháp thí luyện";
            this.ckbThapThiLuyen.UseVisualStyleBackColor = true;
            // 
            // ckbTinhTu
            // 
            this.ckbTinhTu.AutoSize = true;
            this.ckbTinhTu.Enabled = false;
            this.ckbTinhTu.Location = new System.Drawing.Point(25, 92);
            this.ckbTinhTu.Name = "ckbTinhTu";
            this.ckbTinhTu.Size = new System.Drawing.Size(62, 17);
            this.ckbTinhTu.TabIndex = 0;
            this.ckbTinhTu.Text = "Tinh tú";
            this.ckbTinhTu.UseVisualStyleBackColor = true;
            // 
            // ckbPhaiTrangBi
            // 
            this.ckbPhaiTrangBi.AutoSize = true;
            this.ckbPhaiTrangBi.Location = new System.Drawing.Point(25, 69);
            this.ckbPhaiTrangBi.Name = "ckbPhaiTrangBi";
            this.ckbPhaiTrangBi.Size = new System.Drawing.Size(92, 17);
            this.ckbPhaiTrangBi.TabIndex = 0;
            this.ckbPhaiTrangBi.Text = "Phái trang bị";
            this.ckbPhaiTrangBi.UseVisualStyleBackColor = true;
            // 
            // ckbThamBao
            // 
            this.ckbThamBao.AutoSize = true;
            this.ckbThamBao.Location = new System.Drawing.Point(25, 46);
            this.ckbThamBao.Name = "ckbThamBao";
            this.ckbThamBao.Size = new System.Drawing.Size(76, 17);
            this.ckbThamBao.TabIndex = 0;
            this.ckbThamBao.Text = "Thám bảo";
            this.ckbThamBao.UseVisualStyleBackColor = true;
            // 
            // ckbVoKhoiThap
            // 
            this.ckbVoKhoiThap.AutoSize = true;
            this.ckbVoKhoiThap.Location = new System.Drawing.Point(25, 23);
            this.ckbVoKhoiThap.Name = "ckbVoKhoiThap";
            this.ckbVoKhoiThap.Size = new System.Drawing.Size(92, 17);
            this.ckbVoKhoiThap.TabIndex = 0;
            this.ckbVoKhoiThap.Text = "Võ khôi tháp";
            this.ckbVoKhoiThap.UseVisualStyleBackColor = true;
            // 
            // grpTacGia
            // 
            this.grpTacGia.Controls.Add(this.linkDonation);
            this.grpTacGia.Controls.Add(this.linkSource);
            this.grpTacGia.Controls.Add(this.linkFanpage);
            this.grpTacGia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTacGia.ForeColor = System.Drawing.Color.Blue;
            this.grpTacGia.Location = new System.Drawing.Point(1, 398);
            this.grpTacGia.Name = "grpTacGia";
            this.grpTacGia.Size = new System.Drawing.Size(236, 58);
            this.grpTacGia.TabIndex = 0;
            this.grpTacGia.TabStop = false;
            this.grpTacGia.Text = "Góc tác giả";
            // 
            // linkDonation
            // 
            this.linkDonation.AutoSize = true;
            this.linkDonation.Location = new System.Drawing.Point(164, 24);
            this.linkDonation.Name = "linkDonation";
            this.linkDonation.Size = new System.Drawing.Size(56, 13);
            this.linkDonation.TabIndex = 1;
            this.linkDonation.TabStop = true;
            this.linkDonation.Text = "Donation";
            this.linkDonation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDonation_LinkClicked);
            // 
            // linkSource
            // 
            this.linkSource.AutoSize = true;
            this.linkSource.Location = new System.Drawing.Point(94, 24);
            this.linkSource.Name = "linkSource";
            this.linkSource.Size = new System.Drawing.Size(42, 13);
            this.linkSource.TabIndex = 1;
            this.linkSource.TabStop = true;
            this.linkSource.Text = "Source";
            this.linkSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSource_LinkClicked);
            // 
            // linkFanpage
            // 
            this.linkFanpage.AutoSize = true;
            this.linkFanpage.Location = new System.Drawing.Point(16, 24);
            this.linkFanpage.Name = "linkFanpage";
            this.linkFanpage.Size = new System.Drawing.Size(52, 13);
            this.linkFanpage.TabIndex = 0;
            this.linkFanpage.TabStop = true;
            this.linkFanpage.Text = "Fanpage";
            this.linkFanpage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFanpage_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpTacGia);
            this.Controls.Add(this.grbDanhSachTaiKhoan);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1050, 0);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AUTO_MRD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbDanhSachTaiKhoan.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThapThiLuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTinhTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhaiTrangBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThamBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoKhoiThap)).EndInit();
            this.grpTacGia.ResumeLayout(false);
            this.grpTacGia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStrip_btnThem;
        private System.Windows.Forms.ToolStripButton toolStrip_btnSua;
        private System.Windows.Forms.ToolStripButton toolStrip_btnXoa;
        private System.Windows.Forms.GroupBox grpTacGia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStrip_btnTroGiup;
        private System.Windows.Forms.ListBox lsbTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStrip_btnAnAuto;
        private System.Windows.Forms.ToolStripButton toolStrip_btnDungAuto;
        private System.Windows.Forms.ToolStripButton toolStrip_btnChayAuto;
        private System.Windows.Forms.ToolStripLabel toolStrip_lblDangChay;
        private System.Windows.Forms.LinkLabel linkFanpage;
        private System.Windows.Forms.LinkLabel linkSource;
        private System.Windows.Forms.LinkLabel linkDonation;
        private System.Windows.Forms.ToolStripLabel toolStrip_lblDangAn;
        private System.Windows.Forms.Button btnLuuCaiDat;
        public System.Windows.Forms.NumericUpDown numVoKhoiThap;
        public System.Windows.Forms.CheckBox ckbVoKhoiThap;
        public System.Windows.Forms.NumericUpDown numPhaiTrangBi;
        public System.Windows.Forms.NumericUpDown numThamBao;
        public System.Windows.Forms.CheckBox ckbPhaiTrangBi;
        public System.Windows.Forms.CheckBox ckbThamBao;
        public System.Windows.Forms.NumericUpDown numTinhTu;
        public System.Windows.Forms.CheckBox ckbTinhTu;
        public System.Windows.Forms.NumericUpDown numThapThiLuyen;
        public System.Windows.Forms.CheckBox ckbThapThiLuyen;
    }
}

