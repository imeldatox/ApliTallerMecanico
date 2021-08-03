using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using ClassEquipos;

namespace WebEquiposComp
{
    public partial class index : System.Web.UI.Page
    {
        LogNegocios ob2 = new LogNegocios();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = LogNegocios.LOGEO(txtUsuario.Text, txtContraseña.Text);
            if (tabla.Rows.Count == 0)
            {
                TextBox4.Text = "No existe el usuario" + "Sistema Login";//, Response.Write.OK, MessageBoxIcon.Error);   
            }
            else
            {
                Response.Redirect("Menu.aspx");
                TextBox4.Text = "Correcta";
                //se obtiene el tipo de acceso del usuario, puse mas restricciones por si quieren asegurar mas su contraseña
                //obj.tipoUser = tabla.Rows[0][3].ToString();
                //obj.nombre = tabla.Rows[0][1].ToString();
                //obj.ShowDialog();
                //this.Hide();
            }
        }

    }
}