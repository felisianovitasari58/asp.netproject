using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace mhsAPP.entity
{
    public class TAWeb
    {
        private int nodok, idpmb1, idpmb2, idmhs;
        private string konsentrasi, judulTA,nd1,nd2;
        private float ipk;
        public TAWeb(int nodok, int idmhs, string konsentrasi, float ipk, string judulTA, int idpmb1, int idpmb2,string nd1,string nd2)
        {
            this.nodok = nodok;
            this.idmhs = idmhs;
            this.konsentrasi = konsentrasi;
            this.ipk = ipk;
            this.judulTA = judulTA;
            this.idpmb1 = idpmb1;
            this.idpmb2 = idpmb2;
            this.nd1 = nd1;
            this.nd2 = nd2;
        }
        public int IDMhs
        {
            get { return idmhs; }
            set { idmhs = value; }
        }
        public int Nodok
        {
            get { return nodok; }
            set { nodok = value; }
        }
        public int Idpmb1
        {
            get { return idpmb1; }
            set { idpmb1 = value; }
        }
        public int Idpmb2
        {
            get { return idpmb2; }
            set { idpmb2 = value; }
        }
        public string Nd1
        {
            get { return nd1; }
            set { nd1 = value; }
        }
        public string Nd2
        {
            get { return nd2; }
            set { nd2 = value; }
        }
        public string Konsentrasi
        {
            get { return konsentrasi; }
            set { konsentrasi = value; }
        }
        public string JudulTA
        {
            get { return judulTA; }
            set { judulTA = value; }
        }
        public float IPK
        {
            get { return ipk; }
            set { ipk = value; }
        }
    }
}
