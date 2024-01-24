<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Conversion.aspx.cs" Inherits="ApiSOAP.CSU.Conversion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Numero:
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnLetras" runat="server" Height="20px" OnClick="btnLetras_Click" Text="A letras" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDolar" runat="server" Height="20px" OnClick="btnDolar_Click" Text="A Dolar" Width="81px" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Resultado:
            <asp:TextBox ID="txtResultado" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
