using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebFormsProblems
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            this.Session["username"] = this.txtUsername.Text;
            if (!String.IsNullOrEmpty(this.txtUsername.Text))
            {
                this.Application[this.txtUsername.Text] = 0;
                Response.Redirect("ClickCounter.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Username cannot be empty!');", true);
                //Response.Write("Username can not be empty!");
            }
        }
    }
}