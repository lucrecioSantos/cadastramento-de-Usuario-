using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace cadastroCliente.Views
{
    public partial class CadastroCliente : System.Web.UI.Page
    {
        Controllers.ControleCliente ctrCliente = new Controllers.ControleCliente();

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        string mensagem = "";
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            string valor = txtCpf.Text;
            if (rdbLista.TabIndex == 1 )
            {
                if (cadastroCliente.Controllers.Validar_CPF.IsCpf(valor))
                {
                    mensagem = "O número é um CNPJ Válido !";
                }
                else
                {
                    mensagem = "O número é um CNPJ Inválido !";
                }
            }
            else if (rdbLista.TabIndex == 0)
            {
                if (cadastroCliente.Controllers.Validar_CPF.IsCpf(valor))
                {
                    mensagem = "O número é um CPF Válido !";
                }
                else
                {
                    mensagem = "O número é um CPF Inválido !";
                }
            }
           
            else
            {
                mensagem = "Informe o número e o seu tipo para validação !";
            }
 
            {
                try
                {
                    ctrCliente.txtCpf = double.Parse(txtCpf.Text);
                    ctrCliente.txtTelefone = double.Parse(txtTelefone.Text);
                    ctrCliente.txtNome = txtNome.Text;
                    ctrCliente.txtTelefone = double.Parse(txtData.Text);
                    if (ctrCliente.cadastrar())
                        lblResultado.Text = "Registro incluído com sucesso...";
                    else
                        lblResultado.Text = "Falha ao cadastrar o registro";

                }
                catch (Exception ex)
                {
                    lblResultado.Text = ex.Message.ToString();
                }
                txtCpf.Text = (" ");
                txtNome.Text = (" ");
                txtTelefone.Text = (" ");
            }
        }
        private void rdb_cnpj_CheckedChanged(object sender, EventArgs e)
        {

            txtCpf.Text = "";
            txtCpf.Text = "00.000.000/0000-00";
         }

        protected void bntExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ctrCliente.txtCpf = double.Parse(txtCpf.Text);
                if (ctrCliente.excluir())
                    lblResultado.Text = "Registro deletado com sucesso...";
                else
                    lblResultado.Text = "Falha ao deletar o registro";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message.ToString();
            }
        }

        protected void bntEditar_Click(object sender, EventArgs e)
        {

            try
            {
                ctrCliente.txtCpf = double.Parse(txtCpf.Text);
                ctrCliente.txtTelefone = double.Parse(txtTelefone.Text);
                ctrCliente.txtNome = txtNome.Text;
                ctrCliente.txtData = double.Parse(txtData.Text);
                if (ctrCliente.alterar())
                    lblResultado.Text = "Registro alterado com sucesso...";
                else
                    lblResultado.Text = "Falha ao alterar o registro";

            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message.ToString();
            }
            txtCpf.Text = (" ");
            txtData.Text = (" ");
            txtNome.Text = (" ");
            txtTelefone.Text = (" ");



        }

        protected void rdbPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtCpf.Text = "";
            txtCpf.Text = "000.000.000-00";
        }
    }
    
}