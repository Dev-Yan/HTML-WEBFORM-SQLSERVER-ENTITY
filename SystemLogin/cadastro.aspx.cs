using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace SystemLogin
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoginCadastro_Click(object sender, EventArgs e)
        {
            lbResultado.Visible = false;
            txtEmail.BorderColor = Color.Black;
            txtNome.BorderColor = Color.Black;
            txtSenha.BorderColor = Color.Black;
            txtRepetir.BorderColor = Color.Black;
            string Nome = txtNome.Text;
            string Senha = txtSenha.Text;
            string RepetirSenha = txtRepetir.Text;
            string Email = txtEmail.Text;

            //validar idade

            decimal idade = 0;
            try
            {
                DateTime dataAtual = DateTime.Now;
                DateTime dataNascimento = Convert.ToDateTime(txtDataNasc.Text);
                idade = dataAtual.Subtract(dataNascimento).Days / 365;
            }
            catch
            {
                idade = 0;
            }
            if (idade < 18)
            {
                lbResultado.Text = "Sistema para +18";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(Nome))
            {
                lbResultado.Text = "Insira um nome";
                lbResultado.Visible = true;                        //Validações
                lbResultado.ForeColor = Color.Red;
                txtNome.BorderColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(Email))
            {
                lbResultado.Text = "Insira um E-mail!";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
                txtEmail.BorderColor = Color.Red;
            }
            else if (Senha != RepetirSenha)
            {
                lbResultado.Text = "Senhas diferentes!";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
                txtSenha.BorderColor = Color.Red;
                txtRepetir.BorderColor = Color.Red;
            }
            else if (string.IsNullOrEmpty(Senha))
            {
                lbResultado.Text = "Insira uma senha";
                lbResultado.Visible = true;
                lbResultado.ForeColor = Color.Red;
                txtSenha.BorderColor = Color.Red;
                txtRepetir.BorderColor = Color.Red;
            }
            else
            {
                tabUsuario valid = new tabUsuario();
                valid.dtCadastro = DateTime.Now;
                valid.dtNascimento = Convert.ToDateTime(txtDataNasc.Text);
                valid.Email = txtEmail.Text;
                valid.Nome = txtNome.Text;
                valid.Senha = txtSenha.Text;

                using (iValidUserEntities ctx = new iValidUserEntities())
                {
                    ctx.tabUsuario.Add(valid);
                    ctx.SaveChanges();
                }
                Response.Redirect("login.aspx");

            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }


}
