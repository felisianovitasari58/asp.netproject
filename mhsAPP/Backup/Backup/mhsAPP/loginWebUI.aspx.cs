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
    public partial class _loginWebUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButtonWeb_Click(object sender, EventArgs e)
        {
            loginWebCtrl LWC = new loginWebCtrl();
            if (LWC.cekLoginWeb(int.Parse(txtUserWeb.Text), txtPassWeb.Text) == true)
            {
                int roleMhs = LWC.getRoleMhs(int.Parse(txtUserWeb.Text), txtPassWeb.Text);
                if (roleMhs == 2)
                {
                    MahasiswaWeb M = new MahasiswaWeb(int.Parse(txtUserWeb.Text), txtPassWeb.Text, roleMhs);
                    Session["mhs"] = null;
                    Session.Add("mhs", M);
                    Response.Redirect("HomeWebUI.aspx");
                }
                else
                {
                    MessageBox.Show("Data login salah");
                }
            }
            else
            {
                MessageBox.Show("Data login salah");
            }
        }

    }
}
