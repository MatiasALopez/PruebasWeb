<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Website.CustomAttributes.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Validar CUIT</h1>

        <div>
            CUIT: <asp:TextBox runat="server" ID="txtCUIT" />
        </div>
        <asp:Button runat="server" ID="btnValidar" Text="Validar" OnClick="btnValidar_Click" />
        <div>
            <asp:Label runat="server" ID="lblMensaje" />
        </div>
    </form>
</body>
</html>
