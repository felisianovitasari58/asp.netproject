using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using mhsAPP.dataset.DataSetMahasiswaWebTableAdapters;
using mhsAPP.entity;
using mhsAPP.dataset.DataSetTAWebTableAdapters;
using mhsAPP.dataset.DataSetDosenTableAdapters;
using mhsAPP.dataset.DataSetUjianTAWebTableAdapters;

namespace mhsAPP.control
{
    public class UjTAWebCtrl
    {
        MAHASISWATableAdapter mhs = new MAHASISWATableAdapter();
        PENGAJUAN_TATableAdapter ta = new PENGAJUAN_TATableAdapter();
        DOSENTableAdapter dos = new DOSENTableAdapter();
        UJIAN_PENDADARANTableAdapter pnd = new UJIAN_PENDADARANTableAdapter();
        public void addPend(UjTAWeb ent)
        {
            pnd.addNewUTA(ent.Idta, ent.Iddos1, ent.Iddos2, ent.Waktu, ent.Fasilitas);
        }
        public int getIDta(string judul, int idm)
        {
            return ta.getIDTA(idm, judul).Value;
        }
        public string getJudul(int idm)
        {
            return ta.getJudulTA(idm).ToString();
        }
        public int getIddos(string nama)
        {
            return dos.getIDDosen(nama).Value;
        }
        public string getDos1(int idm)
        {
            return ta.getDosen1(idm).ToString();
        }
        public string getDos2(int idm)
        {
            return ta.getDosen2(idm).ToString();
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
    }
}
