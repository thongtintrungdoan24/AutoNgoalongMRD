using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AutoNgoalongMRD
{
    [Serializable()]
    public class classThongTinNguoiDung : ISerializable
    {
        public classThongTinNguoiDung()
        {

        }
        public classThongTinNguoiDung(string _user, string _pass, string _server, classCaiDatNguoiDung _caidat)
        {
            User = _user;
            Pass = _pass;
            Server = _server;
            CaiDat = _caidat;
        }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Server { get; set; }
        public classCaiDatNguoiDung CaiDat { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("User",User);
            info.AddValue("Pass", Pass);
            info.AddValue("Server", Server);
            info.AddValue("CaiDat", CaiDat);
        }
        public classThongTinNguoiDung(SerializationInfo info, StreamingContext context)
        {
            User = (string)info.GetValue("User", typeof(string));
            Pass = (string)info.GetValue("Pass", typeof(string));
            Server = (string)info.GetValue("Server", typeof(string));
            CaiDat = (classCaiDatNguoiDung)info.GetValue("CaiDat", typeof(classCaiDatNguoiDung));
        }

        public override string ToString()
        {
            return this.User + "-->" + this.Server;
        }

    }
}
