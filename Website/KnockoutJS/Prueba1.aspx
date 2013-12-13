<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba1.aspx.cs" Inherits="Website.KnockoutJS.Prueba1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ul data-bind="foreach: statusList">
            <li>
                <span data-bind="text: Name" ></span> status: <span data-bind="text: Value" ></span> (<span data-bind="text: Timestamp"></span>)
            </li>
        </ul>
    </form>

    <script type="text/javascript" src="/scripts/jquery-1.8.3.min.js"></script>
    <script type="text/javascript" src="/scripts/knockout-2.2.1.js"></script>
    <script type="text/javascript" src="/scripts/knockout.mapping-latest.js"></script>
    <script type="text/javascript" src="scripts/pages/prueba1.js"></script>
</body>
</html>
