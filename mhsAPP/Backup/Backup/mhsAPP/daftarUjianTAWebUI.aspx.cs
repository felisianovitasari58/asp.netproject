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
    public partial class daftarUjianTAWebUI : System.Web.UI.Page
    {
        private static int idMhs;
        UjTAWebCtrl utc = new UjTAWebCtrl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mhs"] == null)
            {
                Response.Redirect("loginWebUI.aspx");
            }
            else
            {
                MahasiswaWeb Mhs = Session["mhs"] as MahasiswaWeb;
                idMhs = utc.getIDMhs(Mhs.NPM);
                setPage();
            }
        }

        protected void setPage()
        {
            txtNamaMhsWTA.Text = utc.getNama(idMhs);
            txtNPMWTA.Text = utc.getNPM(idMhs).ToString();
            txtProdiWTA.Text = utc.getProdi(idMhs);
            txthpmhsWTA.Text = utc.getHp(idMhs).ToString();
            txtDosen1.Text = utc.getDos1(idMhs);
            txtDosen2.Text = utc.getDos2(idMhs);
            txtJudulTA.Text = utc.getJudul(idMhs);
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int IdTA = utc.getIDta(txtJudulTA.Text, idMhs);
            string fasilitas = txtFasilitas.Text;
            string swaktu = txtTgl.Text + " " + dropWaktu.Text;
            DateTime waktu = DateTime.Parse(swaktu);
            int idDos1=utc.getIddos(txtDosen1.Text);
            int idDos2=utc.getIddos(txtDosen2.Text);
            UjTAWeb ta = new UjTAWeb(IdTA, idDos1, idDos2, waktu, fasilitas);
            utc.addPend(ta);
        }
    }
}
