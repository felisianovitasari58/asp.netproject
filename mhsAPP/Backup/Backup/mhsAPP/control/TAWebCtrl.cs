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
using mhsAPP.dataset.DataSetTAWebTableAdapters;
using mhsAPP.entity;
using mhsAPP.dataset.DataSetDosenTableAdapters;

namespace mhsAPP.control
{
    public class TAWebCtrl
    {
        DOSENTableAdapter dsn = new DOSENTableAdapter();
        MAHASISWATableAdapter mhs = new MAHASISWATableAdapter();
        PENGAJUAN_TATableAdapter ta = new PENGAJUAN_TATableAdapter();
        MKPILIHANTableAdapter mk = new MKPILIHANTableAdapter();
        public void addMK(MKPilWeb ent)
        {
            mk.addMkPil(ent.Idta, ent.Mkpil, ent.Nilai);
        }
        public int getIDTA(string judul, int idm)
        {
            return ta.getIDTA(idm, judul).Value;
        }
        public int getIdDosen(string nama)
        {
            return dsn.getIDDosen(nama).Value;
        }
        public int rownodok(string nodok)
        {
            return ta.countRownodok(nodok).Value;
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
        public int getIdProdi(int id)
        {
            return mhs.getIdProdi(id).Value;
        }
        public void addTA(TAWeb ent)
        {
            ta.addNewTA(ent.Nodok, ent.IDMhs, ent.IPK, ent.Konsentrasi, ent.JudulTA, ent.Idpmb1,ent.Nd1, ent.Idpmb2,ent.Nd2);
        }
    }
}
