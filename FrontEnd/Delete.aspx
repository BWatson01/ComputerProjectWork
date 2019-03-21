<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="FrontEnd.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #666666">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 46px; top: 73px; position: absolute; width: 472px; height: 27px; margin-top: 2px;" Text="Are you sure you want to delete this page ?" Font-Bold="True" Font-Size="Larger"></asp:Label>
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 192px; top: 142px; position: absolute; width: 99px; height: 29px; margin-top: 0px;" Text="No" OnClick="btnNo_Click" BackColor="Red" />
        <asp:Button ID="btnYes" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 48px; top: 143px; position: absolute; width: 99px; height: 29px;" Text="Yes" BackColor="#66FFCC" />
    </form>
</body>
</html>
