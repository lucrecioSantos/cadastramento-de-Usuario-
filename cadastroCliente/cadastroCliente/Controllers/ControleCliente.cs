using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace cadastroCliente.Controllers
{
    public class ControleCliente
    {
        Model.acessoDados acesso = new Model.acessoDados();
        //Propriedades
        #region Properties 
        private double cpf = 0;
        public double txtCpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }
        private double data = 0;
        public double txtData
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        private double telefone = 0;
        public double txtTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }
        private string nome = "";
        public string txtNome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }





        public SqlCommand cmd { get; private set; }


        #endregion Properties
        //Métodos
        #region Methods
        public bool cadastrar()
        {   //Duas formas de implementar: 1 - montando o comando sql em uma string na classe de negócio, podendo fazer regras para escrita dinâmica do sql ainda na camada de controle (negócio)

            try
            {
                string SqlCommand = "INSERT INTO tbCliente(cpf,nome,telefone,data) VALUES (@cpf,@nome,@telefone,@data)";
                //cmd = new SqlCommand(="INSERT INTO tbCliente(cpf,nome,codPerfil,dddtelefone,telefone,endereco,email,senha) VALUES (@cpf,@nome,@Codperfil,@dddtelefone,@telefone,@endereco,@email,@senha)", con);
                //strSQL.Replace("INSERT", "BBB");
                SqlCommand = SqlCommand.Replace("@cpf", txtCpf.ToString());
                SqlCommand = SqlCommand.Replace("@data", txtData.ToString());
                SqlCommand = SqlCommand.Replace("@telefone", txtTelefone.ToString());
                SqlCommand = SqlCommand.Replace("@nome", "'" + txtNome + "'");
                if (acesso.cadastrar(SqlCommand))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //2. Passar o objeto inteiro para a classe acesso a dados e lá é montado o sql.

        }
        public bool excluir()
        {
            try
            {

                string SqlCommand = "DELETE FROM tbCliente  WHERE (cpf = @cpf)";
                SqlCommand = SqlCommand.Replace("@cpf", txtCpf.ToString());
                if (acesso.cadastrar(SqlCommand))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool alterar()
        {
            try
            {
                string SqlCommand = "UPDATE tbCliente SET nome=@nome, telefone=@telefone, @data WHERE cpf=@cpf";
                //  SqlCommand adoCmd = new SqlCommand("UPDATE tbCliente SET nome=@nome, codPerfil=@codperfil, endereco=@endereco, dddtelefone=@dddtelefone, telefone=@telefone, email=@email, senha=@senha WHERE cpf=@cpf", con);

                SqlCommand = SqlCommand.Replace("@cpf", txtCpf.ToString());
                SqlCommand = SqlCommand.Replace("@telefone", txtTelefone.ToString());
                SqlCommand = SqlCommand.Replace("@nome", "'" + txtNome + "'");
                SqlCommand = SqlCommand.Replace("@data", txtData.ToString());
                if (acesso.cadastrar(SqlCommand))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion Methods
    }
}