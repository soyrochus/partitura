using System;
using System.ComponentModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace Skitr.partitura
{
    [ToolboxItemAttribute(false)]
    public class WebPartitura : WebPart
    {
        protected override void CreateChildControls()
        {
        }

        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write("<div>Booh!<div>");
            base.Render(writer);
        }
    }
}
