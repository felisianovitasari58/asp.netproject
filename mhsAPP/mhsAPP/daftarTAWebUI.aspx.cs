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
    public partial class daftarTAWebUI : System.Web.UI.Page
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
            idProd.Text = tc.getIdProdi(idMhs).ToString();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            float ipk = float.Parse(txtIPK.Text);
            string konsen = txtKonsentrasi.Text;
            string mk1 = txtmakul1.Text;
            string mk2 = txtmakul2.Text;
            string mk3 = txtmakul3.Text;
            string mk4 = txtmakul4.Text;
            string mk5 = txtmakul5.Text;
            string nmk1 = txtnilaimk1.Text;
            string nmk2 = txtnilaimk2.Text;
            string nmk3 = txtnilaimk3.Text;
            string nmk4 = txtnilaimk4.Text;
            string nmk5 = txtnilaimk5.Text;
            string tglSkrg = DateTime.Now.ToShortDateString();
            int noDok4 = int.Parse(tglSkrg.Substring(8, 2) + tglSkrg.Substring(3, 2));
            string noDokU = "1" + noDok4.ToString();
            int noDokS = tc.rownodok(noDokU) + 1;
            int noDok = int.Parse(noDokU + noDokS.ToString());

        }
    }
}
