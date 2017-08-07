using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;

namespace RideXpress_StarterKit
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Script/jquery-1.11.3.min.js",
                DebugPath = "~/Script/jquery-1.11.3.js",
                CdnPath = "https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js",
                CdnDebugPath = "https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"
            });
            ScriptManager.ScriptResourceMapping.AddDefinition("bootstrap", new ScriptResourceDefinition
            {
                Path = "~/Script/bootstrap.min.js",
                DebugPath = "~/Script/bootstrap.js",
                CdnPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js",
                CdnDebugPath = "https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"
            });
        }
    }
}