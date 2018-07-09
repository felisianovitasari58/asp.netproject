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
    public class MKPilWeb
    {
        private int idTA;
        private string mkpilihan, nilai;
        public MKPilWeb(int idTA, string mkpilihan, string nilai)
        {
            this.idTA = idTA;
            this.mkpilihan = mkpilihan;
            this.nilai = nilai;
        }
        public int Idta
        {
            get { return idTA; }
            set { idTA = value; }
        }
        public string Mkpil
        {
            get { return mkpilihan; }
            set { mkpilihan = value; }
        }
        public string Nilai
        {
            get { return nilai; }
            set { nilai = value; }
        }
    }
}
