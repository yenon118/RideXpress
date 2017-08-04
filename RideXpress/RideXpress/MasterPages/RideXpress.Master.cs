using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideXpress_StarterKit.MasterPages
{
    public partial class RideXpress : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //This is the Page_Load event for the Master page
            //Stores the URL and uses the .ToLower() method of the String object
            //and uses the .Contains() method
            string url = Request.Url.ToString().ToLower();
            //Check to see if the URL contains either Trainee, Workout, or the About page
            //Adds the "active" attribute, which highlights the selected option Yellow
            //on the top Menu bar
            if (url.Contains("car"))
            {
                traineeMenu.Attributes.Add("class", "active");
            }
            else if (url.Contains("/about.aspx"))
            {
                aboutMenu.Attributes.Add("class", "active");
            }
            else if (url.Contains("report"))
            {
                reportMenu.Attributes.Add("class", "active");
            }
        }
    }
}