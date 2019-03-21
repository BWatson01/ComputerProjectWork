<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="FrontEnd.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 597px; top: 313px; position: absolute; height: 29px; width: 301px"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 597px; top: 379px; position: absolute; height: 30px; width: 130px" Text="Yes" BackColor="Red" BorderColor="Red" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 749px; top: 379px; position: absolute; height: 30px; width: 130px" Text="No" BackColor="#99FF99" OnClick="btnNo_Click" />
    </form>
</body>
</html>
