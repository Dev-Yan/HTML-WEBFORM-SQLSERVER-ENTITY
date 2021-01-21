<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="SystemLogin.cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastre-se</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cadastro</h1>
            <br />
            <label>Nome</label> <br />
            <br />
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <label>E-mail</label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <label>Senha</label>
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <label>Repetir Senha</label>
            <br />
            <asp:TextBox ID="txtRepetir" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <label>Data de Nascimento</label>
            <br />
            <asp:TextBox ID="txtDataNasc" runat="server" TextMode="Date"></asp:TextBox> 
            <br />
            <asp:Label ID="lbResultado" runat="server" Visible="false"></asp:Label>
            <asp:Button ID="btnLoginCadastro" runat="server" Text="Cadastre" OnClick="btnLoginCadastro_Click" />
            <br />
            <asp:Button ID="btnVoltar" runat="server" Text="Voltar para tela inicial" OnClick="btnVoltar_Click" />
        </div>
    </form>
</body>
</html>
