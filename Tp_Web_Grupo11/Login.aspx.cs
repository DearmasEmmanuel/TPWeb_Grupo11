﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_Web_Grupo11
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string admin = "admin";
            string contrasena = "1234";

            if(admin == txtUsuario.Text && contrasena == TxtContraseña.Text)
            {
                Response.Redirect("admin.aspx");
                
            }
       

        }
    }
}