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
    public partial class daftarKPWebUI : System.Web.UI.Page
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

        protected void setPage()
        {
            txtNamaMhsWKP.Text = kc.getNama(idMhs);
            txtNPMWKP.Text = kc.getNPM(idMhs).ToString();
            txtProdiWKP.Text = kc.getProdi(idMhs);
            txtEmailWKP.Text = kc.getEmail(idMhs);
            txthpmhsWKP.Text = kc.getHp(idMhs).ToString();
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string tglSkrg = DateTime.Now.ToShortDateString();
            int noDokU = int.Parse(tglSkrg.Substring(8, 2) + tglSkrg.Substring(3, 2));
            int noDokS = kc.countRow(noDokU.ToString()) + 1;
            int noDok = int.Parse(noDokU.ToString() + noDokS.ToString());
            string nmPer = txtNamaPer.Text;
            string almtPer = txtAlamatPer.Text;
            string bdnHkm = dropBdnHkm.Text;
            DateTime tglMulai = DateTime.Parse(txtTglMulai.Text);
            DateTime tglAkhir = DateTime.Parse(txtTglAkhir.Text);
            string nmCP = txtnamaCP.Text;
            string jabCP = txtJabCP.Text;
            int noHp = int.Parse(txtNoHPCP.Text);
            //lampiran
            KPWeb ent = new KPWeb(noDok, tglMulai, tglAkhir, nmPer, almtPer,bdnHkm, nmCP, jabCP, noHp, idMhs);
            kc.addKP(ent);
            Response.Redirect("printDaftarKPWebUI.aspx?nodok="+noDok);
        }

        protected void btndftrujKP_Click(object sender, EventArgs e)
        {
        }
    }
}
