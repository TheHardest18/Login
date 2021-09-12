using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Login
{
    public partial class home : System.Web.UI.Page
    {
        loginEntities db = new loginEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           GridView1.DataSource = db.sesion(txtUsuario.Text, txtContraseña.Text);
            DataBind();
            string result = GridView1.Rows[0].Cells[0].Text;
            if (result == "1") {
                Response.Redirect("iniciado.aspx");
            }
            else
            {
                Label1.Text = "No Encontrado";
            }
        }
    }
}