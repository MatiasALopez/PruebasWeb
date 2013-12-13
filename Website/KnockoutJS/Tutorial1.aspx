<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tutorial1.aspx.cs" Inherits="Website.KnockoutJS.Tutorial1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <h3>Tasks</h3>

    <form data-bind="submit: addTask">
        Add task: <input data-bind="value: newTaskText" placeholder="What needs to be done?" />
        <button type="submit">Add</button>
    </form>

    <ul data-bind="foreach: tasks, visible: tasks().length > 0">
        <li>
            <input type="checkbox" data-bind="checked: isDone" />
            <input data-bind="value: title, disable: isDone" />
            <a href="#" data-bind="click: $parent.removeTask">Delete</a>
        </li> 
    </ul>

    You have <b data-bind="text: incompleteTasks().length">&nbsp;</b> incomplete task(s)
    <span data-bind="visible: incompleteTasks().length == 0"> - it's beer time!</span>

    <button data-bind="click: save">Save</button>
    
    <script type="text/javascript" src="/scripts/jquery-1.8.3.min.js"></script>
    <script type="text/javascript" src="/scripts/knockout-2.2.1.js"></script>
    <script type="text/javascript" src="scripts/pages/tutorial1.js"></script>
    
</body>
</html>
