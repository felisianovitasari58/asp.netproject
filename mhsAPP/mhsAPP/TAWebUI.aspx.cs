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
using mhsAPP.control;
using mhsAPP.entity;

namespace mhsAPP
{
    public partial class TAWebUI : System.Web.UI.Page
    {
        TAWebCtrl tc = new TAWebCtrl();
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
                idMhs = tc.getIDMhs(Mhs.NPM);
                setPage();
            }
        }
        protected void setPage()
        {
            txtNamaMhsWTA.Text = tc.getNama(idMhs);
            txtNPMWTA.Text = tc.getNPM(idMhs).ToString();
            txtProdiWTA.Text = tc.getProdi(idMhs);
            txtEmailWTA.Text = tc.getEmail(idMhs);
            txthpmhsWTA.Text = tc.getHp(idMhs).ToString();
        }

        protected void btndaftarKP_Click(object sender, EventArgs e)
        {
            Response.Redirect("daftarTAWebUI.aspx");
        }

        protected void btnEditEmail_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdHpWKP_Click(object sender, EventArgs e)
        {

        }
    }
}
