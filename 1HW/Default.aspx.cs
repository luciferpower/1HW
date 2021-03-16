using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 31;
            string answer = "";
            if (i % 1 == i || i % i == 1)
            {
                answer = "NO";
            }
            else
            {
                answer = "YES";
            }
            Response.Write(answer);
        }
    }
}