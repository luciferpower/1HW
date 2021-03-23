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
            string answer = "";
            int i = 22;
            for (int i_Ct = 2; i_Ct < 22; i_Ct++) { 
                if (i % i_Ct == 0) {
                    answer = "NO";
                    break;
                }
                else
                {
                    answer = "YES";
                }

            }
            Response.Write(answer);
        }
    }
}