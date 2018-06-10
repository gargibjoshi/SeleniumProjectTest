using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AutoScriptGenerator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Parse_Click(object sender, EventArgs e)
    {
        HTMLParser hTMLParser = new HTMLParser();
        hTMLParser.Parse("TestHtml.html");
        txtArea_UIElement.Value = hTMLParser.uiElement;
        txtArea_UIUsage.Value = hTMLParser.uiUsage;
        txtArea_Action.Value = hTMLParser.uiAction;
    }
}