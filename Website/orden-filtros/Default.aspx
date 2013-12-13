<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website.orden_filtros.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <thead>
                <tr>
                    <th><a href="#" data-bind="click: sort" data-property="nombre" data-order="">Nombre</a></th>
                    <th><a href="#" data-bind="click: sort" data-property="apellido" data-order="">Apellido</a></th>
                    <th><a href="#" data-bind="click: sort" data-property="fechaNacimiento" data-order="">Fecha nacimiento</a></th>
                    <th><a href="#" data-bind="click: sort" data-property="estaActivo" data-order="">Activo</a></th>
                </tr>
            </thead>
            <tbody data-bind="foreach: items">
                <tr>
                    <td data-bind="text: nombre"></td>
                    <td data-bind="text: apellido"></td>
                    <td data-bind="text: fechaNacimientoConFormato"></td>
                    <td data-bind="text: estaActivoConFormato"></td>
                </tr>
            </tbody>
        </table>
    </form>
    
    <script src="/scripts/jquery-1.8.3.min.js"></script>
    <script src="/scripts/knockout-2.2.1.js"></script>
    <script src="scripts/ordenfiltros.js"></script>
</body>
</html>
