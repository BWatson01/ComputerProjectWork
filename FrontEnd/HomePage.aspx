<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FrontEnd.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FF6666">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" Font-Size="75pt" style="z-index: 1; left: 392px; top: 98px; position: absolute; width: 289px" Text="Mortec"></asp:Label>
        <asp:Button ID="btnOrder" runat="server" Font-Size="40pt" ForeColor="White" OnClick="btnOrder_Click" style="z-index: 1; left: 402px; top: 316px; position: absolute; height: 107px; width: 339px; background-color: #CC99FF" Text="Orders" />
        <asp:Label ID="lblTitle2" runat="server" Font-Size="75pt" style="z-index: 1; left: 700px; top: 98px; position: absolute; width: 443px"  Text="Computers" ForeColor="Aqua"></asp:Label>
        <asp:Button ID="btnCustomer" runat="server" BackColor="Fuchsia" Font-Size="40pt" ForeColor="White" OnClick="btnCustomer_Click" style="z-index: 1; left: 787px; top: 316px; position: absolute; height: 107px; width: 339px" Text="Customers" />
        <asp:Button ID="btnManufacturer" runat="server" BackColor="Lime" Font-Size="40pt" ForeColor="White" OnClick="btnManufacturer_Click" style="z-index: 1; left: 402px; top: 473px; position: absolute; width: 339px; height: 107px" Text="Manufacturers" />
        <asp:Button ID="btnComputers" runat="server" BackColor="Black" Font-Size="40pt" ForeColor="White" style="z-index: 1; left: 787px; top: 473px; position: absolute; height: 107px; width: 339px" Text="Computers" />
    </form>
</body>
</html>
