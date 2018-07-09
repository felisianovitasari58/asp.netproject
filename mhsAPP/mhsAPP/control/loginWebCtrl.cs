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

namespace mhsAPP.control
{
    public class loginWebCtrl
    {
        MAHASISWATableAdapter mhs = new MAHASISWATableAdapter();
        public bool cekLoginWeb(int npm, string passmhs)
        {
            bool cek = false;
            try
            {
                if (mhs.getNPM(npm, passmhs).ToString() != "")
                    cek = true;
            }
            catch (Exception ex)
            {
                cek = false;
            }
            return cek;
        }

        public int getRoleMhs(int npm, string passmhs)
        {
            int role = 0;
            try
            {
                role = int.Parse(mhs.getRoleMhs(npm, passmhs).ToString());
            }
            catch (Exception ex)
            {
                role = 0;
            }
            return role;
        }
    }
}
