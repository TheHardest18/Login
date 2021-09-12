<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Login.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
  <div class="form-group">
      <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
      <asp:TextBox ID="txtUsuario" class="form-control" placeholder="Enter email" runat="server"></asp:TextBox>
    </div>
  <div class="form-group">
      <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
      <asp:TextBox ID="txtContraseña" class="form-control" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
  </div>
        <asp:Button ID="Button1"  class="btn btn-primary" runat="server" Text="Iniciar Sesion" OnClick="Button1_Click" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
</form>
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
