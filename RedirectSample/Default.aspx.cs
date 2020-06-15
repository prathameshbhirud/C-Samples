using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RedirectSample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Response.Redirect("a.aspx", false);
                Server.Transfer("a.aspx");
                int a = 1, b = 0;
                int c = a / b;
            }
            catch (Exception ex)
            {
                //Response.Redirect("b.aspx", false);
                Server.Transfer("b.aspx");
            }
            finally
            {
                //Response.Redirect("c.aspx", false);
                Server.Transfer("c.aspx");
            }
        }
    }
}