using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebFormsProblems
{
    using System.Text;

    public partial class ClickCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblWelcomeMessage.Text = "Welcome " + Session["username"];
            this.lblCurrentClicksText.Text = "Current clicks: ";
        }

        protected void Click_Click(object sender, EventArgs e)
        {
            lblCurrentUserClicks.Text = ((int)this.Application[Session["username"].ToString()] + 1).ToString();

            this.Application[Session["username"].ToString()] = int.Parse(lblCurrentUserClicks.Text);

            StringBuilder allUsers = new StringBuilder();
            foreach (var key in Application.Keys)
            {
                allUsers.Append(string.Format("{0}:{1}", key.ToString(), Application[key.ToString()])).Append("<br/>");
            }

            lblAllUserClicks.Text = allUsers.ToString().Replace(Environment.NewLine, "<br />"); ;
        }
    }
}