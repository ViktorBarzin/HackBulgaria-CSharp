<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClickCounter.aspx.cs" Inherits="AspNetWebFormsProblems.ClickCounter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWelcomeMessage" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Click" runat="server" Text="Click" OnClick="Click_Click" />
            <br />
            <asp:Label ID="lblCurrentClicksText" runat="server" Text=""></asp:Label>
             
            <asp:Label ID="lblCurrentUserClicks" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lblAllUserClicks" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
