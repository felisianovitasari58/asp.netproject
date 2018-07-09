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

namespace mhsAPP.control
{
    public class TAWebCtrl
    {
        MAHASISWATableAdapter mhs = new MAHASISWATableAdapter();
        PENGAJUAN_TATableAdapter ta = new PENGAJUAN_TATableAdapter();
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
    }
}
