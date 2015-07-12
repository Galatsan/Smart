<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditDevice.aspx.cs" Inherits="WebSmartHouse.EditDevice" %>

<%@ Import Namespace="WebSmartHouse" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <% d = (IDevice)Session["EditDevice"];
               Response.Write(d.ToString() + "<br />");
               %><asp:Button ID="OnOff" runat="server" Text="Вкл/Выкл" OnClick="OnOFF" /><br /><%
               if (d is IHeating)
               {%>
            <asp:Button ID="AddTempHeat" runat="server" Text="+" OnClick="HeatClick"></asp:Button><br />
            <asp:Button ID="SubTempHeat" runat="server" Text="-" OnClick="HeatClick"></asp:Button><br />
            <%}
               if (d is ITV)
               {%>
            Переключить Канал
            <asp:Button ID="Button1" runat="server" Text="<-" OnClick="TVClick" />
            <asp:Button ID="Button2" runat="server" Text="->" OnClick="TVClick"></asp:Button><br />
            <asp:Button ID="Button3" runat="server" Text="Громкость+" OnClick="TVClick"></asp:Button>
            <asp:Button ID="Button4" runat="server" Text="Громкость-" OnClick="TVClick"></asp:Button><br />
            <asp:Button ID="Button5" runat="server" Text="Контраст+" OnClick="TVClick"></asp:Button>
            <asp:Button ID="Button6" runat="server" Text="Контраст-" OnClick="TVClick"></asp:Button><br />
            <asp:Button ID="Button7" runat="server" Text="Резкость+" OnClick="TVClick"></asp:Button>
            <asp:Button ID="Button8" runat="server" Text="Резкость-" OnClick="TVClick"></asp:Button><br />
            <%}
               if (d is ILouvers)
               {%>
            <asp:Button ID="Button11" runat="server" Text="Угол+" OnClick="LouversClick" />
            <asp:Button ID="Button12" runat="server" Text="Угол" OnClick="LouversClick" />
            <asp:Button ID="Button13" runat="server" Text="Поднять/Опустить" OnClick="LouversClick" />
            <% }
               if (d is IBoiler)
               {%>
            <asp:Button ID="Button15" runat="server" Text="Наполнить" OnClick="BoilerClick"/>
            <asp:Button ID="Button16" runat="server" Text="Закипетить" OnClick="BoilerClick" />
            <asp:Button ID="Button17" runat="server" Text="Слить Воду" OnClick="BoilerClick" />
            <%} %>
        </div>
        <asp:LinkButton runat="server" PostBackUrl="~/DevicesForm.aspx">Назад</asp:LinkButton>
    </form>
</body>

</html>
