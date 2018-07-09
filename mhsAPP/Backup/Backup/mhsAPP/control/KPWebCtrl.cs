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
using mhsAPP.entity;

namespace mhsAPP.control
{
    public class KPWebCtrl
    {
        PENGAJUAN_KPTableAdapter kp = new PENGAJUAN_KPTableAdapter();
        MAHASISWATableAdapter mhs = new MAHASISWATableAdapter();
        public int countRowValid(int id)
        {
            return kp.cekRowKPValid(id).Value;
        }
        public int countRowBlmValid(int id)
        {
            return kp.cekRowKPblmValid(id).Value;
        }
        public int countRowNotValid(int id)
        {
            return kp.cekRowKPNotValid(id).Value;
        }
        public void addKP(KPWeb ent)
        {
            kp.addNewKP(ent.IDMhs,ent.NODok, ent.NamaPerusahaan, ent.AlamatPerusahaan,ent.BdnHkm, ent.TglMulai, ent.TglAkhir, ent.NamaCP, ent.JabatanCP, ent.NoHPCp);
        }
        public int getIDMhs(int NPM)
        {
            return mhs.getIDMhs(NPM).Value;
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
        public void editEmail(int id, string email)
        {
            mhs.editEmail(email, id);
        }
        public void editHP(int id, int hp)
        {
            mhs.editHP(hp, id);
        }
        public int countRow(string nodok)
        {
            return kp.countRowNodok(nodok).Value;
        }
    }
}
