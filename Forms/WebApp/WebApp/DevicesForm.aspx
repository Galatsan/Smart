<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevicesForm.aspx.cs" Inherits="WebSmartHouse.DevicesForm" %>

<%@ Import Namespace="WebSmartHouse" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        body {
            background-color: azure;
        }

        .layer1 {
            margin: 25px;
            float: left;
            width: 439px;
        }
        #form1 {
            width: 1010px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="layer1">
            <% allDevices = (Dictionary<string, List<IDevice>>)Session["allDevices"];
               foreach (KeyValuePair<string, List<IDevice>> listDev in allDevices)
               {
                   foreach (IDevice i in listDev.Value)
                   {
                       Response.Write(i.ToString() + "<br/><br/>");
                   }
               }%>
        </div>
        <div class="layer1">
            <asp:DropDownList ID="DropDownListDevice" runat="server"></asp:DropDownList><br />
            <asp:Button ID="OnOff" runat="server" Text="Вкл/Выкл" OnClick="OnOff_Click" /><br />
            <asp:Button ID="Delete" runat="server" Text="Удалить" OnClick="Delete_Click" />
            <br />
            <asp:Button ID="Edit" runat="server" Text="Именить" OnClick="Edit_Click" />
            <br />
            <br />
            Добавить. Введить имя и выберите тип устройства<br />
            <asp:TextBox ID="TextBoxAddDeviceName" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButtonList ID="RadioButtonListDevice" runat="server">
                <asp:ListItem Selected="True">Обогреватель</asp:ListItem>
                <asp:ListItem>Светильник</asp:ListItem>
                <asp:ListItem>Телевизор</asp:ListItem>
                <asp:ListItem>Жалюзи</asp:ListItem>
                <asp:ListItem>Бойлер</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Add" runat="server" Text="Добавить" OnClick="Add_Click" />

        </div>
    </form>
</body>
</html>
