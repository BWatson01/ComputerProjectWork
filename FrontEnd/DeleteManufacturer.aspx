<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteManufacturer.aspx.cs" Inherits="FrontEnd.DeleteManufacturer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 180px; top: 255px; position: absolute; width: 101px" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 348px; top: 251px; position: absolute; height: 28px; width: 110px" Text="No" />
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 104px; top: 176px; position: absolute; width: 390px"></asp:Label>
    </form>
</body>
</html>
