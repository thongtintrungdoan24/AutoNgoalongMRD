using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutoNgoalongMRD.frmMain;

namespace AutoNgoalongMRD
{
    public partial class frmQuanLyTaiKhoan : Form
    {

        #region Properties
        public AddNguoiDungVaoDanhSach AddNguoiDung;
        private classThongTinNguoiDung thongTinNguoiDungTamThoi;
        public classThongTinNguoiDung ThongTinNguoiDungTamThoi
        {
            get { return thongTinNguoiDungTamThoi; }
            set { thongTinNguoiDungTamThoi = value; }

        } 
        #endregion
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        //Contructor nhận truyền delegate truyền thông tin giữa 2 form.
        public frmQuanLyTaiKhoan(AddNguoiDungVaoDanhSach sender)
        {
            InitializeComponent();
            this.AddNguoiDung = sender;
        }
        public frmQuanLyTaiKhoan(AddNguoiDungVaoDanhSach sender, classThongTinNguoiDung user)
        {
            InitializeComponent();
            this.AddNguoiDung = sender;

            thongTinNguoiDungTamThoi = user;
            txbUser.Text = user.User;
            txbPass.Text = user.Pass;
            txbServer.Text = user.Server;
        }
        //public frmQuanLyTaiKhoan(classThongTinNguoiDung user)
        //{
        //    InitializeComponent();
        //    thongTinNguoiDungTamThoi = new classThongTinNguoiDung();
        //    thongTinNguoiDungTamThoi = user;
        //    txbUser.Text = user.User;
        //    txbPass.Text = user.Pass;
        //    txbServer.Text = user.Server;
        //}
        private void btnHuyLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (thongTinNguoiDungTamThoi == null)
            {
                thongTinNguoiDungTamThoi = new classThongTinNguoiDung();
                thongTinNguoiDungTamThoi.User = txbUser.Text;
                thongTinNguoiDungTamThoi.Pass = txbPass.Text;
                thongTinNguoiDungTamThoi.Server = txbServer.Text;
                thongTinNguoiDungTamThoi.CaiDat = new classCaiDatNguoiDung();
            }
            else
            {
                thongTinNguoiDungTamThoi.User = txbUser.Text;
                thongTinNguoiDungTamThoi.Pass = txbPass.Text;
                thongTinNguoiDungTamThoi.Server = txbServer.Text;
            }


            this.AddNguoiDung(thongTinNguoiDungTamThoi);
            Close();
        }
        #region Validate dữ liệu nhập vào Sử dụng errorProvider
        private void txbUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbUser.Text))
            {
                e.Cancel = true;
                txbUser.Focus();
                errorProvider.SetError(txbUser, "Thím chưa nhập User!");
            } else 
            {
                errorProvider.SetError(txbUser, null);
            }
           
        }

        private void txbPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbPass.Text))
            {
                e.Cancel = true;
                txbPass.Focus();
                errorProvider.SetError(txbPass, "Thím chưa nhập Pass, mật khẩu để em tự đoán hả!");
            }
            else
            {
                errorProvider.SetError(txbUser, null);
            }
        }

        private void txbServer_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbServer.Text))
            {
                e.Cancel = true;
                txbServer.Focus();
                errorProvider.SetError(txbServer, "Thím chưa nhập User!");
            }
            else if (!txbServer.Text.Contains("ngoalong4v.com"))
            {
                errorProvider.SetError(txbServer, "Auto hiện tại chỉ hỗ trợ lưu tài khoản của ngoalong4v.com");
            } else
            {

                errorProvider.SetError(txbUser, null);
                btnLuuTaiKhoan.Enabled = true;
            }

        }

        public static implicit operator frmQuanLyTaiKhoan(FormCollection v)
        {
            throw new NotImplementedException();
        }
        #endregion

        private void btnHoTro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập đầy đủ thông tin, nhấn TAB:" + Environment.NewLine +"+ Nút Lưu/ Thêm chỉ hiện ra khi server là của ngoalong4v.com", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
