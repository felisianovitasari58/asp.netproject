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
    public class UjKPWeb
    {
        private int nodok;
        private string judul, fasilitas;
        private DateTime waktu;
        public UjKPWeb(int nodok, string judul, DateTime waktu, string fasilitas)
        {
            this.nodok = nodok;
            this.judul = judul;
            this.waktu = waktu;
            this.fasilitas = fasilitas;
        }
        public int Nodok
        {
            get { return nodok; }
            set { nodok = value; }
        }
        public string Judul
        {
            get { return judul; }
            set { judul = value; }
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
