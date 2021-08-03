using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ClassEquipos;

namespace WebEquiposComp
{
    public partial class DiscoDuro : System.Web.UI.Page
    {
        LogNegocios ob2 = new LogNegocios();
        AccesoBD ob1 = new AccesoBD();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           ob2.InsertarRevision(TextBox1.Text,TextBox2.Text, TextBox7.Text,Convert.ToInt32(TextBox8.Text), Convert.ToInt32(TextBox9.Text), Convert.ToInt32(TextBox14.Text), TextBox10.Text, TextBox11.Text, TextBox12.Text, Convert.ToInt32(TextBox13.Text));
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            
        }
    }
}