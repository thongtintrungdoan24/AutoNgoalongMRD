using KAutoHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoNgoalongMRD
{
    public partial class frmCuaSoAuto : Form
    {
        #region Properties
        private Thread threadChayAuto = null;
        private Thread threadMoRuong = null;
        //Chọn tiêu phí = vàng full
        private bool kiemTraTieuPhiVang = false;
        public WebBrowser WC;
        private bool dangMoRuong = false;
        private static classThongTinNguoiDung user = new classThongTinNguoiDung();
        private IntPtr hWnd = IntPtr.Zero;
        private IntPtr hw = IntPtr.Zero;
        Bitmap picMain;

        Bitmap picSub;
        #endregion
        public frmCuaSoAuto()
        {
            InitializeComponent();
            LoadWebcontrol("");

        }
        public frmCuaSoAuto(classThongTinNguoiDung _user)
        {
            InitializeComponent();
            user = _user;
            LoadWebcontrol(user.Server);
        }
        private void LoadWebcontrol(string server)
        {
            WC = new WebBrowser();
            WC.Dock = DockStyle.Fill;   
            WC.ScriptErrorsSuppressed = true;
            WC.ScrollBarsEnabled = false;
            WC.Navigate(server);
            tblPanelCuaSoAuto.Controls.Add(WC, 0, 1);
            WC.DocumentCompleted += WC_DocumentCompleted;
        }

        private void WC_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Tìm đối tượng
            var u = WC.Document.GetElementById("u");

            var p = WC.Document.GetElementById("p");
            //Đặt giá trị
            u.InnerText = user.User;

            p.InnerText = user.Pass;

            p.Focus();

            SendKeys.Send("{TAB}");
            //Nhấn nút đăng nhập
            SendKeys.Send("{ENTER}");
        }

        private void chayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            threadChayAuto = new Thread(new ThreadStart(RunAutoNgoaLong));
            threadChayAuto.IsBackground = true;
            threadChayAuto.Start();
        }

        private void dungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            threadChayAuto.Abort();
        }
        private void RunAutoNgoaLong()
        {
            KiemTraCaiDatTieuPhiVang();
            FarmChuaCong(user.CaiDat.farmVoKhoiThap, user.CaiDat.farmVoKhoiThap_SoLan);
            FarmThamBao(user.CaiDat.farmThamBao, user.CaiDat.farmThamBao_SoLan);
            FarmNgoc_PhaiTrangBi(user.CaiDat.phaiNgocDucTrangBi, user.CaiDat.phaiNgocDucTrangBi_SoLan);
            farmTinhTu(user.CaiDat.farmTinhTu, user.CaiDat.farmTinhTu_SoLan);
            farmThapThiLuyen(user.CaiDat.farmThapThiLuyen, user.CaiDat.farmThapThiLuyen_SoLan);

        }
        private void KiemTraCaiDatTieuPhiVang()
        {
            if (!kiemTraTieuPhiVang)
            {
                LoadHandle();

                ClickInto(hw, ToaDo.thanhChinh_Main, 10);
                Thread.Sleep(1000);
                ClickInto(hw, ToaDo.caiDat_Main);
                Thread.Sleep(1000);

                ClickInto(hw, ToaDo.caiDat_ChonHetTieuPhi);
                Thread.Sleep(100);

                //ClickVao(hw, ToaDo.tinhTu_Main_KhongHoatDong, 1, 2000);
                ClickInto(hw, ToaDo.thanhChinh_Main);
                AutoControl.SendKeyPress(KeyCode.ESC);

                //AutoControl.SendTextKeyBoard();
                //AutoControl.SendKeyPress(KeyCode.KEY_L);
                Thread.Sleep(50);

                ClickInto(hw, ToaDo.caiDat_AnKhungChat, 1, 300, 300);

                ClickInto(hw, ToaDo.caiDat_NhacNhoTuuQuan, 3, 300);

                ClickInto(hw, ToaDo.caiDat_NhiemVuNgayChuTuyen, 1, 200);
                
                kiemTraTieuPhiVang = true;
            }
        }
        //Click vào tọa độ mong muốn
        public static void ClickInto(IntPtr handle, Point diemClickVao, int soLanClick = 1, int delayAfterclick = 30, int delayBeforeClick = 0)
        {
            for (int i = 0; i < soLanClick; i++)
            {
                if (delayBeforeClick != 0)
                {
                    Thread.Sleep(delayBeforeClick);
                }
                AutoControl.SendClickOnPosition(handle, diemClickVao.X, diemClickVao.Y);
                Thread.Sleep(delayAfterclick);
            }
        }
        private void FarmChuaCong(bool chkStatus, int runTime)
        {
            if (chkStatus == true)
            {
                LoadHandle();
                for (int i = 0; i < runTime; i++)
                {

                    ClickInto(hw, ToaDo.theGioi_Main, 5);
                    Thread.Sleep(2000);
                    ClickInto(hw, ToaDo.theGioi_VoKhoiThap);//Vị trí tháp
                    Thread.Sleep(2000);
                    ClickInto(hw, ToaDo.voKhoiThap_MaxCapBoss, 10);

                    ClickInto(hw, ToaDo.voKhoiThap_TanCong,1, 1000);
                    //AutoControl.SendClickOnPosition(hw, 502, 503);//Nút tấn công
                    Thread.Sleep(2000);
                    ClickInto(hw, ToaDo.voKhoiThap_LapDoi);
                    Thread.Sleep(2000);
                    ClickInto(hw, ToaDo.voKhoiThap_KhaiChien);
                    Thread.Sleep(2000);
                    ClickInto(hw, ToaDo.voKhoiThap_XuatChien);
                    Thread.Sleep(12000);
                    ClickInto(hw, ToaDo.voKhoiThap_XacNhan);
                    Thread.Sleep(1000);
                    ClickInto(hw, ToaDo.voKhoiThap_Thoat);
                    Thread.Sleep(1000);
                    AutoControl.SendKeyBoardDown(hw, VKeys.VK_ESCAPE);

                }
                return;
            }
        }


        private void FarmThamBao(bool chkStatus, int runTime)
        {
            if (chkStatus == true)
            {
                LoadHandle();

                //Tọa độ "Thế giới"
                ClickInto(hw, ToaDo.thanhChinh_Main, 10);
                Thread.Sleep(1000);
                ClickInto(hw, ToaDo.thamBao_Main);
                Thread.Sleep(2000);

                for (int i = 0; i < runTime; i++)
                {
                    ClickInto(hw, ToaDo.thamBao_DeLang, 5);
                    Thread.Sleep(2000);
                    ClickInto(hw, ToaDo.thamBao_CanQuet);
                    Thread.Sleep(1000);
                    ClickInto(hw, ToaDo.thamBao_CanQuet);
                    Thread.Sleep(2000);
                    ClickInto(hw, ToaDo.thamBao_CanQuetNhanh);
                    Thread.Sleep(2000);
                    for (int j = 0; j < 10; j++)
                    {
                        ClickInto(hw, ToaDo.thamBao_TuChoiMuaCuaHang);
                        Thread.Sleep(250);
                        ClickInto(hw, ToaDo.thamBao_TuChoiTanCongNguoiChoi);
                        Thread.Sleep(250);
                        ClickInto(hw, ToaDo.thamBao_SuaCuaCuoiDeLang);
                        Thread.Sleep(250);
                        ClickInto(hw, ToaDo.thamBao_HuyThoatThamBao);
                        Thread.Sleep(250);
                    }
                    Thread.Sleep(1000);
                    ClickInto(hw, ToaDo.thamBao_NhanThuong);
                    Thread.Sleep(1000);


                }
                //Tắt tính năng thám bảo
                ClickInto(hw, ToaDo.thamBao_TatThamBao, 1, 1000);
                return;
            }
        }
       

        private void FarmNgoc_PhaiTrangBi(bool chkStatus, int runTime)
        {
            if (chkStatus == true)
            {
                LoadHandle();
                ClickInto(hw, ToaDo.thanhChinh_Main, 10);

                ClickInto(hw, ToaDo.trangBi_Main, 1, 1000);

                ClickInto(hw, ToaDo.trangBi_Phai, 1, 500);

                ClickInto(hw, ToaDo.trangBi_Phai10Lan_Truoc, 1, 500);

                for (int i = 0; i < runTime; i++)
                {
                    
                    ClickInto(hw, ToaDo.trangBi_Phai10Lan_Tiep, 1, 5100);
                }

                ClickInto(hw, ToaDo.trangBi_XacNhanPhaiXong, 1, 1000, 2000);

                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                //ClickVao(hw, ToaDo.tinhTu_DongCuaSo, 1);
                return;
            }
        }
        private void farmTinhTu(bool chkStatus, int runTime)
        {
            if (chkStatus == true)
            {
                LoadHandle();
                //ClickVao(hw, ToaDo.tinhTu_Main_KhongHoatDong);
                //for (int i = 0; i < runTime; i++)
                //{
                //    ClickVao(hw, ToaDo.tinhTu_TuMo, 1, 1);
                //    ClickVao(hw, ToaDo.tinhTu_XacNhanMua_TuMo, 1, 1);
                //}
                

                //Point P = new Point();

                //P = CheckImageUntilFound(RetakePicMain(), TakePicSub("TinhTu.png"));

                ClickInto(hw, CheckImageUntilFound(RetakePicMain(), TakePicSub(HinhAnh.TinhTu)), 1, 300);

                for (int i = 0; i < runTime; i++)
                {
                    ClickInto(hw, ToaDo.tinhTu_TuMo, 1, 1);
                    ClickInto(hw, ToaDo.tinhTu_XacNhanMua_TuMo, 1, 1);
                    ClickInto(hw, ToaDo.tinhTu_XacNhanKhongDuRuong, 1, 1);
                }

                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);

            }
        }
        private void farmThapThiLuyen(bool chkStatus, int runTime)
        {
            if (chkStatus == true)
            {
                LoadHandle();
                
                //ofSet của TTL_Thắng thoát 130, 235
                ClickInto(hw, CheckImageUntilFound(RetakePicMain(), TakePicSub(HinhAnh.TTL_Main), 20, 20), 1, 400);

                ClickInto(hw, ToaDo.thapThiLuyen_VaoTrongThap, 1, 2000);

                
                for (int i = 0; i < runTime; i++)
                {
                    
                    ClickInto(hw, ToaDo.thapThiLuyen_1, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_2, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_3, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_4, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_5, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_6, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_7, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_8, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_9, 1, 100);
                    ClickInto(hw, ToaDo.thapThiLuyen_10, 1, 100);

                    ClickInto(hw, ToaDo.thapThiLuyen_Next, 1, 100);

                    ClickInto(hw, ToaDo.thapThiLuyen_VuotThap, 1, 100);

                    ClickInto(hw, ToaDo.thapThiLuyen_XacNhanVuot, 1, 100);

                    ClickInto(hw, ToaDo.thapThiLuyen_TuTanCong, 1, 100);

                    ClickInto(hw, CheckImageUntilFound(RetakePicMain(), TakePicSub(HinhAnh.TTL_TanCongNPC), 30), 3, 200);

                    ClickInto(hw, CheckImageUntilFound(RetakePicMain(), TakePicSub(HinhAnh.TTL_Win), 130, 235));
                }

                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);
                AutoControl.SendKeyBoardPress(hw, VKeys.VK_ESCAPE);

            }
        }

        private Point CheckImageUntilFound(Bitmap _main, Bitmap _sub, int _ofsetX = 7, int _ofsetY = 7)
        {
            try
            {
                Point p = (Point)ImageScanOpenCV.FindOutPoint(_main, _sub);
                p.X += _ofsetX;
                p.Y += _ofsetY;
                return p;
            }
            catch (Exception)
            {
                Thread.Sleep(300);
                
                return CheckImageUntilFound(RetakePicMain(), _sub, _ofsetX, _ofsetY);
            }
        }

        private Bitmap RetakePicMain()
        {
            
            return new Bitmap(CaptureHelper.CaptureWindow(hw));
        }
        private Bitmap TakePicSub(string _fileName)
        {
            try
            {
                return new Bitmap(Application.StartupPath+ @"\Images\" + _fileName);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid: " + _fileName);
                return null;
            }
        }

        private void LoadHandle()
        {
            if(hWnd == IntPtr.Zero)
            {
                hWnd = AutoControl.FindWindowHandle(null, this.Text);

                if(hw == IntPtr.Zero)
                    hw = AutoControl.FindHandle(hWnd, "MacromediaFlashPlayerActiveX", "MacromediaFlashPlayerActiveX");
            }
        }

        private void reSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WC.Refresh();
        }
        private void MoRuong()
        {
            IntPtr hWnd = IntPtr.Zero;
            hWnd = AutoControl.FindWindowHandle(null, this.Text);

            var hw = AutoControl.FindHandle(hWnd, "MacromediaFlashPlayerActiveX", "MacromediaFlashPlayerActivX");
            while (!dangMoRuong)
            {
                ClickInto(hw, ToaDo.tinhTu_TuMo, 1, 1);
                ClickInto(hw, ToaDo.tinhTu_XacNhanMua_TuMo, 1, 1);
            }
        }

        private void thongTinTacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cùi văn mía", "JustForFun");
        }

        private void fanpageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/autongoalong4v/");
        }

        private void loadLaiCaiDatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (var item in frmMain.dsNguoiDung)
            {
                if (item.User == user.User)
                {
                    user = item;
                }
            }
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
