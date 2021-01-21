using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SystemLogin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcesso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.BorderColor = Color.Red;
                lbResultUser.Text = "* Informe seu usuário";
                lbResultUser.ForeColor = Color.Red;
                lbResultUser.Visible = true;
            }
            else
            {
                txtUsuario.BorderColor = Color.Black;
                lbResultUser.Visible = false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.BorderColor = Color.Red;
                lbResultPass.Text = "*Informe sua senha";
                lbResultPass.ForeColor = Color.Red;
                lbResultPass.Visible = true;
            }
            else
            {
                txtSenha.BorderColor = Color.Black;
                lbResultPass.Visible = false;

            }

            //Consultar Banco de Dados

            tabUsuario valid = new tabUsuario();
            
            using(iValidUserEntities ctx = new iValidUserEntities())
            {
                valid = ctx.tabUsuario.Where(c => c.Email == txtUsuario.Text && c.Senha == txtSenha.Text).FirstOrDefault();
                if (valid != null)
                {
                    Response.Redirect("home.aspx");
                }
                else
                {
                    lbResultado.Text = "Usuário e senha inválidos!";
                }
            }

            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                Response.Redirect("home.aspx");
            }
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastro.aspx");
        }
    }
}