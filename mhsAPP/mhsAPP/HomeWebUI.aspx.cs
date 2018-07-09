using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using mhsAPP.entity;
using mhsAPP.control;

namespace mhsAPP
{
    public partial class HomeWebUI : System.Web.UI.Page
    {
        KPWebCtrl kc = new KPWebCtrl();
        private static int idMhs;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mhs"] == null)
            {
                Response.Redirect("loginWebUI.aspx");
            }
            else
            {
                MahasiswaWeb Mhs = Session["mhs"] as MahasiswaWeb;
                idMhs = kc.getIDMhs(Mhs.NPM);
                initPage();
            }
        }
        public void initPage()
        {
            if (kc.countRowBlmValid(idMhs) == 1)
                lbStatusKP.Text = "Data kerja praktek anda masih dalam proses validasi";
            else if (kc.countRowValid(idMhs) == 1)
                lbStatusKP.Text = "Data kerja praktek anda telah disetujui. Surat pengantar kerja praktek dapat diamb il di tata usaha";
            else if (kc.countRowNotValid(idMhs) == 1)
                lbStatusKP.Text = "Data kerja praktek anda ditolak. Silahkan menghubungi bagian tata usaha";
            else
                lbStatusKP.Text = "none";
        }
    }
}
