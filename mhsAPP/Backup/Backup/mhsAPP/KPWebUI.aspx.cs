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
    public partial class KPWebUI : System.Web.UI.Page
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
                setPage();
            }
        }
        protected void btnEditEmail_Click(object sender, EventArgs e)
        {
            if (txtEmailWKP.Enabled == false)
                txtEmailWKP.Enabled = true;
            else
            {
                kc.editEmail(idMhs, txtEmailWKP.Text);
                txtEmailWKP.Enabled = false;
            }
        }

        protected void btnEdHpWKP_Click(object sender, EventArgs e)
        {
            if (txthpmhsWKP.Enabled == false)
                txthpmhsWKP.Enabled = true;
            else
            {
                kc.editHP(idMhs, int.Parse(txthpmhsWKP.Text));
                txthpmhsWKP.Enabled = false;
            }
        }
        protected void setPage()
        {
            txtNamaMhsWKP.Text = kc.getNama(idMhs);
            txtNPMWKP.Text = kc.getNPM(idMhs).ToString();
            txtProdiWKP.Text = kc.getProdi(idMhs);
            txtEmailWKP.Text = kc.getEmail(idMhs);
            txthpmhsWKP.Text = kc.getHp(idMhs).ToString();
        }

        protected void btndaftarKP_Click(object sender, EventArgs e)
        {
            Response.Redirect("daftarKPWebUI.aspx");
        }

        protected void btndftrujKP_Click(object sender, EventArgs e)
        {
            Response.Redirect("daftarUjianKPWebUI.aspx");
        }
    }
}
