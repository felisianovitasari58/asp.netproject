using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using mhsAPP.dataset.DataSetKPWebTableAdapters;
using mhsAPP.dataset.DataSetMahasiswaWebTableAdapters;
using mhsAPP.dataset.DataSetUjianKPWebTableAdapters;
using mhsAPP.entity;

namespace mhsAPP.control
{
    public class UjKPWebCtrl
    {
        PENGAJUAN_KPTableAdapter kp = new PENGAJUAN_KPTableAdapter();
        MAHASISWATableAdapter mhs = new MAHASISWATableAdapter();
        UJIAN_KPTableAdapter ukp= new UJIAN_KPTableAdapter();
        public int getIDMhs(int NPM)
        {
            return mhs.getIDMhs(NPM).Value;
        }
        public string getNamaPer(int id)
        {
            return kp.getNmPer(id).ToString();
        }
        public string getAlmtPer(int id)
        {
            return kp.getAlamatPer(id).ToString();
        }
        public string getDosen(int id)
        {
            return kp.getDosenPem(id).ToString();
        }
        public string getNama(int id)
        {
            return mhs.getNamaByID(id).ToString();
        }
        public string getProdi(int id)
        {
            return mhs.getProdiByID(id).ToString();
        }
        public string getEmail(int id)
        {
            return mhs.getEmailByID(id).ToString();
        }
        public int getNPM(int id)
        {
            return mhs.getNPMByID(id).Value;
        }
        public int getHp(int id)
        {
            return mhs.getHPByID(id).Value;
        }
        public int getNodok(int id)
        {
            return kp.getNodok(id).Value;
        }
        public void addUjianKP(UjKPWeb ent)
        {
            ukp.addUjKP(ent.Nodok, ent.Judul, ent.Waktu, ent.Fasilitas);
        }
    }
}
