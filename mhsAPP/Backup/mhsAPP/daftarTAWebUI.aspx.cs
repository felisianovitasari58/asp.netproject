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
            string[] mk=new string [5];
            string[] nmk = new string[5];
            mk[0] = txtmakul1.Text;
            mk[1] = txtmakul2.Text;
            mk[2] = txtmakul3.Text;
            mk[3] = txtmakul4.Text;
            mk[4] = txtmakul5.Text;
            nmk[0] = txtnilaimk1.Text;
            nmk[1] = txtnilaimk2.Text;
            nmk[2] = txtnilaimk3.Text;
            nmk[3] = txtnilaimk4.Text;
            nmk[4] = txtnilaimk5.Text;
            string tglSkrg = DateTime.Now.ToShortDateString();
            int noDok4 = int.Parse(tglSkrg.Substring(8, 2) + tglSkrg.Substring(3, 2));
            string noDokU = "1" + noDok4.ToString();
            int noDokS = tc.rownodok(noDokU) + 1;
            int noDok = int.Parse(noDokU + noDokS.ToString());
            if (txtTopik1.Text != "")
            {
                int iddos1 = tc.getIdDosen(dp11.Text);
                int iddos2 = tc.getIdDosen(dp21.Text);
                TAWeb ent = new TAWeb(noDok, idMhs, konsen, ipk, txtTopik1.Text, iddos1, iddos2,dp11.Text,dp21.Text);
                tc.addTA(ent);
                int idTA = tc.getIDTA(txtTopik1.Text, idMhs);
                for(int i =0;i<5;i++)
                {
                    MKPilWeb entmk = new MKPilWeb(idTA, mk[i], nmk[i]);
                    tc.addMK(entmk);
                }
            }
            if (txtTopik2.Text != "")
            {
                int iddos1 = tc.getIdDosen(dp12.Text);
                int iddos2 = tc.getIdDosen(dp22.Text);
                TAWeb ent = new TAWeb(noDok, idMhs, konsen, ipk, txtTopik2.Text, iddos1, iddos2, dp12.Text, dp22.Text);
                tc.addTA(ent);
            }
            if (txtTopik3.Text != "")
            {
                int iddos1 = tc.getIdDosen(dp13.Text);
                int iddos2 = tc.getIdDosen(dp23.Text);
                TAWeb ent = new TAWeb(noDok, idMhs, konsen, ipk, txtTopik3.Text, iddos1, iddos2, dp13.Text, dp23.Text);
                tc.addTA(ent);
            }
            Response.Redirect("printDaftarTAWebUI.aspx?nodok=" + noDok);
        }
    }
}
