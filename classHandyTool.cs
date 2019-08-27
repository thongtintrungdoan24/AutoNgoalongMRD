using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KAutoHelper;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace AutoNgoalongMRD
{
    public static class classHandyTool
    {
        /// <summary>
        /// Tìm tọa độ của ảnh
        /// </summary>
        /// <param name="_main">Ảnh gốc</param>
        /// <param name="_sub">Ảnh cần tìm</param>
        /// <param name="p">xuất ra tọa độ khi tìm thấy, nếu không thấy thì trả về 0,0</param>
        /// <returns>Trả về bool, out point</returns>
        public static bool FindImageOutPoint(Bitmap _main, Bitmap _sub, out Point p)
        {
            p = new Point();
            try
            {
                p = (Point)ImageScanOpenCV.FindOutPoint(_main, _sub);
                return true;
            }
            catch (Exception ex)
            {
                p = Point.Empty;
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        
        /// <summary>
        /// Click vào vị trí mong muốn dựa trên Handle
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="pointToClick"></param>
        /// <param name="clickTime"></param>
        /// <param name="delayAfterClick"></param>
        /// <param name="delayBeforeClick"></param>
        public static void ClickOnWindowPosition(IntPtr handle, Point pointToClick, int clickTime = 1, int delayAfterClick = 1, int delayBeforeClick = 0)
        {
            for (int i = 0; i < clickTime; i++)
            {
                if (delayBeforeClick != 0)
                {
                    Thread.Sleep(delayBeforeClick);
                }
                AutoControl.SendClickOnPosition(handle, pointToClick.X, pointToClick.Y);
                Thread.Sleep(delayAfterClick);
            }
        }
    }
    
}
