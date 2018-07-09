using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace mhsAPP.entity
{
    public class UjTAWeb
    {
        private int idTA,idDos1,idDos2;
        private string  fasilitas;
        private DateTime waktu;
        public UjTAWeb(int idTA,int idDos1,int idDos2,DateTime waktu, string fasilitas)
        {
            this.idTA = idTA;
            this.idDos1 = idDos1;
            this.idDos2 = idDos2;
            this.waktu = waktu;
            this.fasilitas = fasilitas;
        }
        public int Idta
        {
            get { return idTA; }
            set { idTA = value; }
        }
        public int Iddos1
        {
            get { return idDos1; }
            set { idDos1 = value; }
        }
        public int Iddos2
        {
            get { return idDos2; }
            set { idDos2 = value; }
        }
        public string Fasilitas
        {
            get { return fasilitas; }
            set { fasilitas = value; }
        }
        public DateTime Waktu
        {
            get { return waktu; }
            set { waktu = value; }
        }
    }
}
