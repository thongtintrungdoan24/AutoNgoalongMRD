using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoNgoalongMRD
{
    
    [Serializable()]
    public class classCaiDatNguoiDung : ISerializable
    {
        public classCaiDatNguoiDung()
        {
            farmVoKhoiThap = true;
            farmVoKhoiThap_SoLan = 30;
            farmThamBao = true;
            farmThamBao_SoLan = 30;
            phaiNgocDucTrangBi = true;
            phaiNgocDucTrangBi_SoLan = 50;
            farmTinhTu = false;
            farmTinhTu_SoLan = 1000;
            farmThapThiLuyen = true;
            farmThapThiLuyen_SoLan = 1000;
        }
        
        public classCaiDatNguoiDung(classCaiDatNguoiDung tempCaiDat)
        {
            farmVoKhoiThap = tempCaiDat.farmVoKhoiThap;
            farmVoKhoiThap_SoLan = tempCaiDat.farmVoKhoiThap_SoLan;
            farmThamBao = tempCaiDat.farmThamBao;
            farmThamBao_SoLan = tempCaiDat.farmThamBao_SoLan;
            phaiNgocDucTrangBi = tempCaiDat.phaiNgocDucTrangBi;
            phaiNgocDucTrangBi_SoLan = tempCaiDat.phaiNgocDucTrangBi_SoLan;
            farmThapThiLuyen = tempCaiDat.farmThapThiLuyen;
            farmThapThiLuyen_SoLan = tempCaiDat.farmThapThiLuyen_SoLan;
        }
        public bool farmVoKhoiThap { get; set; }
        public int farmVoKhoiThap_SoLan { get; set; }
        public bool farmThamBao { get; set; }
        public int farmThamBao_SoLan { get; set; }
        public bool phaiNgocDucTrangBi { get; set; }
        public int phaiNgocDucTrangBi_SoLan { get; set; }

        public bool farmTinhTu { get; set; }
        public int farmTinhTu_SoLan { get; set; }

        public bool farmThapThiLuyen { get; set; }
        public int farmThapThiLuyen_SoLan { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("farmVoKhoiThap", farmVoKhoiThap);
            info.AddValue("farmVoKhoiThap_SoLan", farmVoKhoiThap_SoLan);
            info.AddValue("farmThamBao", farmThamBao);
            info.AddValue("farmThamBao_SoLan", farmThamBao_SoLan);
            info.AddValue("phaiNgocDucTrangBi", phaiNgocDucTrangBi);
            info.AddValue("phaiNgocDucTrangBi_SoLan", phaiNgocDucTrangBi_SoLan);
            info.AddValue("farmTinhTu", farmTinhTu);
            info.AddValue("farmTinhTu_SoLan", farmTinhTu_SoLan);
            info.AddValue("farmThapThiLuyen", farmThapThiLuyen);
            info.AddValue("farmThapThiLuyen_SoLan", farmThapThiLuyen_SoLan);
        }
        public classCaiDatNguoiDung(SerializationInfo info, StreamingContext context)
        {
            farmVoKhoiThap = (bool)info.GetValue("farmVoKhoiThap", typeof(bool));
            farmVoKhoiThap_SoLan = (int)info.GetValue("farmVoKhoiThap_SoLan", typeof(int));
            farmThamBao = (bool)info.GetValue("farmThamBao", typeof(bool));
            farmThamBao_SoLan = (int)info.GetValue("farmThamBao_SoLan", typeof(int));
            phaiNgocDucTrangBi = (bool)info.GetValue("phaiNgocDucTrangBi", typeof(bool));
            phaiNgocDucTrangBi_SoLan = (int)info.GetValue("phaiNgocDucTrangBi_SoLan", typeof(int));
            farmTinhTu = (bool)info.GetValue("farmTinhTu", typeof(bool));
            farmTinhTu_SoLan = (int)info.GetValue("farmTinhTu_SoLan", typeof(int));
            farmThapThiLuyen = (bool)info.GetValue("farmThapThiLuyen", typeof(bool));
            farmThapThiLuyen_SoLan = (int)info.GetValue("farmThapThiLuyen_SoLan", typeof(int));
        }
    }
}
