<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="cadastroCliente.Views.CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>

    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/jquery.maskedinput.min.js"></script>


    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sistema de cadastro</title>
    <script type="text/javascript">
        var txtCpf = $("#txtCpf").val().length;

        if (txtCpf < 11) {
            $("#txtCpf").mask("999.999.999-99");
            $("#txtCpf").mask("999.999.999-99");
        } else {
            $("#txtCpf").mask("99.999.999/9999-99");
        }
	//$(document).ready(function(){	
		//$("#txtCpf").mask("99.999.999/9999-99");
	//});
    </script>
</head>
<body>

    <form id="form1" runat="server" action="/action_page.php">
        <a href="menuCliente.aspx" target="_self">"Voltar ao menu"</a>
        <div class="form-group">
            <h1>Cadatro Cliente</h1>
            <h2>Seja Bem-vindo ao seu primeiro acesso, aqui informe seus dados.</h2>
        </div>
        <div class="form-group">
            <ul>
                <li>Informe seus dados.
                </li>
            </ul>
        </div>
        <div class="form-group">
            Nome:
            <asp:TextBox ID="txtNome" runat="server" class="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:RadioButtonList ID="rdbLista" runat="server">
                <asp:ListItem>Pessoa Fisica</asp:ListItem>
                <asp:ListItem>Pessoa Juridica</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            CPF/CNPJ:&nbsp;
            <asp:TextBox type="text/javascript" ID="txtCpf" runat="server" MaxLength="15" placeholder="000.000.000.-00" class="form-control"></asp:TextBox>

        </div>
        <div class="form-group">
            Telefone:
        <asp:TextBox ID="txtTelefone" runat="server" data-mask="(00) 0000-0000" data-mask-selectonfocus="true" class="form-control" ></asp:TextBox>
            <br />

        </div>
        <div class="form-group">
            Data do Cadastral:<asp:TextBox ID="txtData" runat="server" class="form-control"></asp:TextBox>
        </div>
        <br />
        <div class="form-group">


            <p>
                <asp:Button ID="btnCadastrar" runat="server" OnClick="btnCadastrar_Click" Text="Cadastrar" />

                <asp:Button ID="bntExcluir" runat="server" Text="Excluir" OnClick="bntExcluir_Click" />

                <asp:Button ID="bntEditar" runat="server" OnClick="bntEditar_Click" Text="Editar" />

            </p>
            <p>
                <asp:Label ID="lblResultado" runat="server"></asp:Label>
            </p>
          
        </div>
    </form>
</body>
</html>
