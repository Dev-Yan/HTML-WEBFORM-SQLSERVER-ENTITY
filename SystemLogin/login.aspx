<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SystemLogin.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1> <br />
            <label>Usuário</label>
            <br />
            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
            <asp:Label ID="lbResultUser" runat="server" Visible="false"></asp:Label> 
            <br />
            <label>Senha</label> <br />
            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="lbResultPass" runat="server" Visible="false"></asp:Label></asp:Label>
            <br />
            <asp:Label ID="lbResultado" runat="server"></asp:Label>
            <asp:Button ID="btnAcesso" runat="server" Text="Acesse" OnClick="btnAcesso_Click" />
            <br />
            <asp:Button ID="btnCadastro" runat="server" Text="Cadastre-se" OnClick="btnCadastro_Click" />
            
        </div>
    </form>
</body>
</html>
