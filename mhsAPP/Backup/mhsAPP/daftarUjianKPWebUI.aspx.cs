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
    public partial class daftarUjianKPWebUI : System.Web.UI.Page
    {
        private static int idMhs;
        UjKPWebCtrl ukc = new UjKPWebCtrl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mhs"] == null)
            {
                Response.Redirect("loginWebUI.aspx");
            }
            else
            {
                MahasiswaWeb Mhs = Session["mhs"] as MahasiswaWeb;
                idMhs = ukc.getIDMhs(Mhs.NPM);
                setPage();
            }
        }

        protected void setPage()
        {
            txtNamaMhsWKP.Text = ukc.getNama(idMhs);
            txtNPMWKP.Text = ukc.getNPM(idMhs).ToString();
            txtProdiWKP.Text = ukc.getProdi(idMhs);
            txthpmhsWKP.Text = ukc.getHp(idMhs).ToString();
            txtNamaPer.Text = ukc.getNamaPer(idMhs);
            txtAlamatPer.Text = ukc.getAlmtPer(idMhs);
            txtDosen.Text = ukc.getDosen(idMhs);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int nodokp = ukc.getNodok(idMhs);
            string judul = txtJudulKP.Text;
            string fasilitas = txtFasilitas.Text;
            string swaktu = txtTgl.Text + " " + dropWaktu.Text;
            DateTime waktu = DateTime.Parse(swaktu);
            UjKPWeb ent = new UjKPWeb(nodokp, judul, waktu, fasilitas);
            ukc.addUjianKP(ent);
            Response.Redirect("printDaftarUKPWebUI.aspx?nodok=" + nodokp);
        }

        protected void btnEdHpWKP_Click(object sender, EventArgs e)
        {

        }
    }
}
