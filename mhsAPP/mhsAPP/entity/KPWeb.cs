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
    public class KPWeb
    {
        private int noDok,nohpCP,idMhs;
        private string namaPerusahaan, alamatPerusahaan, namaCP, jabCP,bdnHkm;
        private DateTime tglmulai, tglakhir;
        public KPWeb(int noDok, DateTime tglmulai, DateTime tglakhir, string namaPerusahaan, string alamatPerusahaan,string bdnHkm, string namaCP, string jabCP, int nohpCP,int idMhs)
        {
            this.noDok = noDok;
            this.tglmulai = tglmulai;
            this.tglakhir = tglakhir;
            this.namaPerusahaan = namaPerusahaan;
            this.alamatPerusahaan = alamatPerusahaan;
            this.bdnHkm = bdnHkm;
            this.namaCP = namaCP;
            this.jabCP = jabCP;
            this.nohpCP = nohpCP;
            this.idMhs = idMhs;
        }
        public int IDMhs
        {
            get { return idMhs; }
            set { idMhs = value; }
        }
        public int NODok
        {
            get { return noDok; }
            set { noDok = value; }
        }
        public int NoHPCp
        {
            get { return nohpCP; }
            set { nohpCP = value; }
        }
        public DateTime TglMulai
        {
            get { return tglmulai; }
            set { tglmulai = value; }
        }
        public DateTime TglAkhir
        {
            get { return tglakhir; }
            set { tglakhir = value; }
        }
        public string NamaPerusahaan
        {
            get { return namaPerusahaan; }
            set { namaPerusahaan = value; }
        }
        public string AlamatPerusahaan
        {
            get { return alamatPerusahaan; }
            set { alamatPerusahaan = value; }
        }
        public string BdnHkm
        {
            get { return bdnHkm; }
            set { bdnHkm = value; }
        }
        public string NamaCP
        {
            get { return namaCP; }
            set { namaCP = value; }
        }
        public string JabatanCP
        {
            get { return jabCP; }
            set { jabCP = value; }
        }
    }
}
