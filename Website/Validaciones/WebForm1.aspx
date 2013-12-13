<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Website.Validaciones.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .name { width: 150px; text-align: right; }
        .value { width: 400px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView runat="server" ID="fvPersona" 
            DataKeyNames="Id" ItemType="Website.Validaciones.Persona" DefaultMode="Insert"
            InsertMethod="fvPersona_InsertItem">
            <InsertItemTemplate>
                <div>
                    <span class="name">Nombre:</span>
                    <span class="value">
                        <asp:TextBox runat="server" ID="txtNombre" Text="<%# BindItem.Nombre %>" />
                    </span>
                </div>
                <div>
                    <span class="name">Apellido:</span>
                    <span class="value">
                        <asp:TextBox runat="server" ID="txtApellido" Text="<%# BindItem.Apellido %>" />
                    </span>
                </div>
                <div>
                    <span class="name">Fecha nacimiento:</span>
                    <span class="value">
                        <asp:TextBox runat="server" ID="txtFechaNacimiento" Text="<%# BindItem.FechaNacimiento %>" />
                    </span>
                </div>
                <div>
                    <span class="name">Nivel:</span>
                    <span class="value">
                        <asp:TextBox runat="server" ID="txtNivel" Text="<%# BindItem.Nivel %>" />
                    </span>
                </div>
                <div>
                    <span class="name"></span>
                    <span class="value">
                        <asp:CheckBox runat="server" ID="chkEstaActivo" Text="Activo" Checked="<%# BindItem.EstaActivo %>" />
                    </span>
                </div>
                <div>
                    <asp:Button runat="server" ID="btnAgregar" Text="Agregar" CommandName="Insert"  />
                </div>
            </InsertItemTemplate>
        </asp:FormView>
        <asp:ValidationSummary runat="server" ID="summary" ShowValidationErrors="true" ShowModelStateErrors="true" />
    </form>
</body>
</html>
