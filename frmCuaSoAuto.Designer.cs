namespace AutoNgoalongMRD
{
    partial class frmCuaSoAuto
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
            this.tblPanelCuaSoAuto = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripCuaSoAuto = new System.Windows.Forms.MenuStrip();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reFreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhNăngBổTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinTacGiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fanpageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLaiCaiDatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tblPanelCuaSoAuto.SuspendLayout();
            this.menuStripCuaSoAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanelCuaSoAuto
            // 
            this.tblPanelCuaSoAuto.ColumnCount = 1;
            this.tblPanelCuaSoAuto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelCuaSoAuto.Controls.Add(this.menuStripCuaSoAuto, 0, 0);
            this.tblPanelCuaSoAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelCuaSoAuto.Location = new System.Drawing.Point(0, 0);
            this.tblPanelCuaSoAuto.Name = "tblPanelCuaSoAuto";
            this.tblPanelCuaSoAuto.RowCount = 2;
            this.tblPanelCuaSoAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblPanelCuaSoAuto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelCuaSoAuto.Size = new System.Drawing.Size(1034, 676);
            this.tblPanelCuaSoAuto.TabIndex = 0;
            // 
            // menuStripCuaSoAuto
            // 
            this.menuStripCuaSoAuto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem,
            this.tínhNăngBổTrợToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem,
            this.loadLaiCaiDatToolStripMenuItem1});
            this.menuStripCuaSoAuto.Location = new System.Drawing.Point(0, 0);
            this.menuStripCuaSoAuto.Name = "menuStripCuaSoAuto";
            this.menuStripCuaSoAuto.Size = new System.Drawing.Size(1034, 24);
            this.menuStripCuaSoAuto.TabIndex = 0;
            this.menuStripCuaSoAuto.Text = "menuStrip1";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chayToolStripMenuItem,
            this.dungToolStripMenuItem,
            this.reFreshToolStripMenuItem});
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.autoToolStripMenuItem.Text = "&Auto";
            // 
            // chayToolStripMenuItem
            // 
            this.chayToolStripMenuItem.Name = "chayToolStripMenuItem";
            this.chayToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.chayToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.chayToolStripMenuItem.Text = "&Chạy";
            this.chayToolStripMenuItem.Click += new System.EventHandler(this.chayToolStripMenuItem_Click);
            // 
            // dungToolStripMenuItem
            // 
            this.dungToolStripMenuItem.Name = "dungToolStripMenuItem";
            this.dungToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.dungToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.dungToolStripMenuItem.Text = "&Dừng";
            this.dungToolStripMenuItem.Click += new System.EventHandler(this.dungToolStripMenuItem_Click);
            // 
            // reFreshToolStripMenuItem
            // 
            this.reFreshToolStripMenuItem.Name = "reFreshToolStripMenuItem";
            this.reFreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.reFreshToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.reFreshToolStripMenuItem.Text = "&Refresh";
            this.reFreshToolStripMenuItem.ToolTipText = "Mất kết nối thì nhấn vào đây để load lại nhanh";
            this.reFreshToolStripMenuItem.Click += new System.EventHandler(this.reSettingsToolStripMenuItem_Click);
            // 
            // tínhNăngBổTrợToolStripMenuItem
            // 
            this.tínhNăngBổTrợToolStripMenuItem.Name = "tínhNăngBổTrợToolStripMenuItem";
            this.tínhNăngBổTrợToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.tínhNăngBổTrợToolStripMenuItem.Text = "&Tính năng bổ trợ";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongTinTacGiaToolStripMenuItem,
            this.fanpageToolStripMenuItem});
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.giớiThiệuToolStripMenuItem.Text = "&Giới thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // thongTinTacGiaToolStripMenuItem
            // 
            this.thongTinTacGiaToolStripMenuItem.Name = "thongTinTacGiaToolStripMenuItem";
            this.thongTinTacGiaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thongTinTacGiaToolStripMenuItem.Text = "&Thông tin Tác giả";
            this.thongTinTacGiaToolStripMenuItem.Click += new System.EventHandler(this.thongTinTacGiaToolStripMenuItem_Click);
            // 
            // fanpageToolStripMenuItem
            // 
            this.fanpageToolStripMenuItem.Name = "fanpageToolStripMenuItem";
            this.fanpageToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fanpageToolStripMenuItem.Text = "&Fanpage --> Hỗ trợ";
            this.fanpageToolStripMenuItem.Click += new System.EventHandler(this.fanpageToolStripMenuItem_Click);
            // 
            // loadLaiCaiDatToolStripMenuItem1
            // 
            this.loadLaiCaiDatToolStripMenuItem1.Name = "loadLaiCaiDatToolStripMenuItem1";
            this.loadLaiCaiDatToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
            this.loadLaiCaiDatToolStripMenuItem1.Text = "&Load lại cài đặt";
            this.loadLaiCaiDatToolStripMenuItem1.ToolTipText = "Load cài đặt sau khi nhấn lưu bên Giao diện chính";
            this.loadLaiCaiDatToolStripMenuItem1.Visible = false;
            this.loadLaiCaiDatToolStripMenuItem1.Click += new System.EventHandler(this.loadLaiCaiDatToolStripMenuItem1_Click);
            // 
            // frmCuaSoAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 676);
            this.Controls.Add(this.tblPanelCuaSoAuto);
            this.MainMenuStrip = this.menuStripCuaSoAuto;
            this.Name = "frmCuaSoAuto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tblPanelCuaSoAuto.ResumeLayout(false);
            this.tblPanelCuaSoAuto.PerformLayout();
            this.menuStripCuaSoAuto.ResumeLayout(false);
            this.menuStripCuaSoAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelCuaSoAuto;
        private System.Windows.Forms.MenuStrip menuStripCuaSoAuto;
        private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhNăngBổTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinTacGiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanpageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reFreshToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem loadLaiCaiDatToolStripMenuItem1;
    }
}