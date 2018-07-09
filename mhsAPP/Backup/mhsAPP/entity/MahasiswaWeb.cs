using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace mhsAPP.entity
{
    public class MahasiswaWeb
    {
        private string passwordMhs;
        private int rolemhs, npm;
        public MahasiswaWeb() { }
        public MahasiswaWeb(int npm, string passwordMhs, int rolemhs)
        {
            this.npm = npm;
            this.passwordMhs = passwordMhs;
            this.rolemhs = rolemhs;
        }
        public int NPM
        {
            set
            {
                npm = value;
            }
            get
            {
                return npm;
            }
        }
        public string PasswordMhs
        {
            set
            {
                passwordMhs = value;
            }
            get
            {
                return passwordMhs;
            }
        }
        public int Role
        {
            set
            {
                rolemhs = value;
            }
            get
            {
                return rolemhs;
            }
        }
    }
}
