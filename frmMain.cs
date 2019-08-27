using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoNgoalongMRD
{
    public partial class frmMain : Form
    {
        #region Properties
        //Khai báo Danh sách người dùng để chứa dữ liệu.
        public static List<classThongTinNguoiDung> dsNguoiDung = new List<classThongTinNguoiDung>();
        private string dataFile = "data.dat";

        //Khai báo delegate để truyền thông tin giữa 2 form.
        public delegate void AddNguoiDungVaoDanhSach(classThongTinNguoiDung nguoiDung);

        #endregion
        public frmMain()
        {
            InitializeComponent();
            
        }
        
        #region Method & Event
        /// <summary>
        /// Phương thức để truyền dữ liệu sử dụng delegate
        /// </summary>
        /// <param name="nguoidung"></param>
        public void AddNguoiDung(classThongTinNguoiDung nguoidung)
        {
            //Thêm người dùng vào danh sách.
            dsNguoiDung.Add(nguoidung);

            //Xóa trắng listview
            //lsvDSTaiKhoan.Items.Clear();
            lsbTaiKhoan.Items.Clear();
            
            //xét danh sách load vào lisview 
            foreach (classThongTinNguoiDung nd in dsNguoiDung)
            {
                lsbTaiKhoan.Items.Add(nd);
            }
        }


        private void toolStrip_btnTroGiup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/autongoalong4v");
        }

        private void toolStrip_btnThem_Click(object sender, EventArgs e)
        {
            //Tạo form quản lý tài khoản đồng thời truyền vào delegate addNguoiDungVaoDanhSach. truyền vào hàm
            frmQuanLyTaiKhoan fTaiKhoan = new frmQuanLyTaiKhoan(AddNguoiDung);
            fTaiKhoan.ShowDialog();
        }
        

        private void linkFanpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/autongoalong4v");
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCCLZ-YzTqomU2yii8xd8bdQ");
        }

        private void linkSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.howkteam.vn/");
            System.Diagnostics.Process.Start("https://docs.microsoft.com/en-us/dotnet/csharp/");
        }
        private void linkDonation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Momo của tác giả: Hiện chưa có :D");
        }

        private void toolStrip_btnXoa_Click(object sender, EventArgs e)
        {
            

            if (lsbTaiKhoan.SelectedItem != null)
            {
                if (MessageBox.Show("Chắc chắn muốn xóa"+lsbTaiKhoan.SelectedItem.ToString()+" chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    classThongTinNguoiDung user = lsbTaiKhoan.SelectedItem as classThongTinNguoiDung;
                    lsbTaiKhoan.Items.Remove(user);
                    dsNguoiDung.Remove(user);
                }
            }
        }

        private void toolStrip_btnSua_Click(object sender, EventArgs e)
        {
            if (lsbTaiKhoan.SelectedItem != null)
            {
                classThongTinNguoiDung user = lsbTaiKhoan.SelectedItem as classThongTinNguoiDung;

                lsbTaiKhoan.Items.Remove(user);
                dsNguoiDung.Remove(user);
                frmQuanLyTaiKhoan fQuanly = new frmQuanLyTaiKhoan(AddNguoiDung, user);
                fQuanly.ShowDialog();
            }

        }

        private void toolStrip_btnChayAuto_Click(object sender, EventArgs e)
        {
            if (lsbTaiKhoan.SelectedItem != null)
            {
                if (Application.OpenForms.Count >= 2)
                {
                    MessageBox.Show("Do tác giả còn cùi mía, mới chỉ chạy đươc 1 cửa sổ auto 1 thời điểm. Vui lòng thông cảm cho tác giả. XIN CẢM ƠN!", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    classThongTinNguoiDung user = lsbTaiKhoan.SelectedItem as classThongTinNguoiDung;
                    try
                    {
                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.Text == (user.User + user.Server))
                            {
                                MessageBox.Show("Đã chạy auto đối với: " + user.User + "-" + user.Server + " rồi" + Environment.NewLine + "Có thể đang bị ẩn, nhấn Đúp chuột vào tên account để hiện lên.", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                        }
                    }
                    catch (Exception)
                    {

                    }
                    //Thread tempThread = new Thread(TaoFormMoi);
                    //tempThread.IsBackground = true;

                    ////tempThread.SetApartmentState(ApartmentState.STA);
                    //tempThread.Start(user);
                    frmCuaSoAuto fAuto = new frmCuaSoAuto(user);
                    fAuto.Text = user.User + user.Server;
                    fAuto.Show();
                }
            }
        }

        //private void TaoFormMoi(object _user)
        //{
        //    classThongTinNguoiDung user = (classThongTinNguoiDung)_user;
        //    frmCuaSoAuto fAuto = new frmCuaSoAuto(user);
        //    fAuto.Text = user.User + user.Server;
        //    fAuto.Show();
        //}

        private void toolStrip_btnDungAuto_Click(object sender, EventArgs e)
        {
            if (lsbTaiKhoan.SelectedItem != null)
            {
                
                
                classThongTinNguoiDung user = lsbTaiKhoan.SelectedItem as classThongTinNguoiDung;
                try
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == user.User)
                        {
                           
                            //MessageBox.Show("có tìm thấy form");
                            if(MessageBox.Show("Chắc chắn đóng cửa sổ auto của: " + user.User, "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                f.Close();
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void toolStrip_btnAnAuto_Click(object sender, EventArgs e)
        {
            if (lsbTaiKhoan.SelectedItem != null)
            {

                classThongTinNguoiDung user = lsbTaiKhoan.SelectedItem as classThongTinNguoiDung;
                try
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == (user.User+user.Server))
                        {
                            f.Visible = (f.Visible == false) ? true : false;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        #endregion

        private void lsbTaiKhoan_DoubleClick(object sender, EventArgs e)
        {
            toolStrip_btnAnAuto.PerformClick();
        }

        private void lsbTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbTaiKhoan.SelectedItem != null)
            {
                btnLuuCaiDat.Enabled = true;
                classThongTinNguoiDung user = lsbTaiKhoan.SelectedItem as classThongTinNguoiDung;
                LoadCaiDatLen(user);
            } else
            {
                btnLuuCaiDat.Enabled = false;
            }
        }

        private void btnLuuCaiDat_Click(object sender, EventArgs e)
        {
            if (lsbTaiKhoan.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn tài khoản làm sao lưu được cài đặt hả thím?", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                classThongTinNguoiDung user = lsbTaiKhoan.SelectedItem as classThongTinNguoiDung;
                LuuCaiDatNguoiDung(user);
                classSerializeData.Serialize2File(dsNguoiDung, dataFile, classSerializeData.Formatter.Binary);
                if (Application.OpenForms.Count > 0)
                {
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Text == (user.User+user.Server))
                        {
                            frmCuaSoAuto ff = f as frmCuaSoAuto;
                            ff.loadLaiCaiDatToolStripMenuItem1.PerformClick();
                        }
                        //f.loadLaiCaiDatToolStripMenuItem1.PerformClick();
                    }
                }
            }
            
           
            //Lệnh cần thực hiện khi lưu tài khoản ở đây.
        }

        private void LuuCaiDatNguoiDung(classThongTinNguoiDung user)
        {
            foreach (classThongTinNguoiDung userInDS in dsNguoiDung)
            {
                if ((user.User == userInDS.User) && (user.Server == userInDS.Server))
                {
                    userInDS.CaiDat.farmVoKhoiThap = (ckbVoKhoiThap.CheckState == CheckState.Checked) ? true : false;
                    userInDS.CaiDat.farmVoKhoiThap_SoLan = (int)numVoKhoiThap.Value;
                    userInDS.CaiDat.farmThamBao = (ckbThamBao.CheckState == CheckState.Checked) ? true : false;
                    userInDS.CaiDat.farmThamBao_SoLan = (int)numThamBao.Value;
                    userInDS.CaiDat.phaiNgocDucTrangBi = (ckbPhaiTrangBi.CheckState == CheckState.Checked) ? true : false;
                    userInDS.CaiDat.phaiNgocDucTrangBi_SoLan = (int)numPhaiTrangBi.Value;
                    userInDS.CaiDat.farmTinhTu = (ckbTinhTu.CheckState == CheckState.Checked) ? true : false;
                    userInDS.CaiDat.farmTinhTu_SoLan = (int)numTinhTu.Value;
                    userInDS.CaiDat.farmThapThiLuyen = (ckbThapThiLuyen.CheckState == CheckState.Checked) ? true : false;
                    userInDS.CaiDat.farmThapThiLuyen_SoLan = (int)numThapThiLuyen.Value;
                }
            }
        }

        private void LoadCaiDatLen(classThongTinNguoiDung user)
        {
            ckbVoKhoiThap.CheckState = (user.CaiDat.farmVoKhoiThap == true ? CheckState.Checked : CheckState.Unchecked);
            numVoKhoiThap.Value = user.CaiDat.farmVoKhoiThap_SoLan;
            ckbThamBao.CheckState = (user.CaiDat.farmThamBao == true ? CheckState.Checked : CheckState.Unchecked);
            numThamBao.Value = user.CaiDat.farmThamBao_SoLan;
            ckbPhaiTrangBi.CheckState = (user.CaiDat.phaiNgocDucTrangBi == true ? CheckState.Checked : CheckState.Unchecked);
            numPhaiTrangBi.Value = user.CaiDat.phaiNgocDucTrangBi_SoLan;
            ckbTinhTu.CheckState = (user.CaiDat.farmTinhTu == true ? CheckState.Checked : CheckState.Unchecked);
            numTinhTu.Value = user.CaiDat.farmTinhTu_SoLan;
            ckbThapThiLuyen.CheckState = (user.CaiDat.farmThapThiLuyen == true ? CheckState.Checked : CheckState.Unchecked);
            numThapThiLuyen.Value = user.CaiDat.farmThapThiLuyen_SoLan;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(dataFile))
            {
                dsNguoiDung = classSerializeData.DeSerializeFromFile<List<classThongTinNguoiDung>>(dataFile, classSerializeData.Formatter.Binary);
            }

            foreach (classThongTinNguoiDung user in dsNguoiDung)
            {
                lsbTaiKhoan.Items.Add(user);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                classSerializeData.Serialize2File(dsNguoiDung, dataFile, classSerializeData.Formatter.Binary);
            
            
        }
    }
}
