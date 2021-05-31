<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 402px">
            <asp:TextBox ID="TextBox1" runat="server" Width="146px"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="148px"></asp:TextBox>
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" BorderStyle="Ridge" OnClick="Button1_Click" Text="+" Width="139px" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" BorderStyle="Ridge" OnClick="Button2_Click" Text="-" Width="140px" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" BorderStyle="Ridge" OnClick="Button3_Click" Text="*" Width="138px" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Результат"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
