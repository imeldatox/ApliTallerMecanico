using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebEquiposComp
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarCliente.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarCliente.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarCliente.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertarCliente.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}