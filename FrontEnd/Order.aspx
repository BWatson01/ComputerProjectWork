<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="FrontEnd.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #336699">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrders" runat="server" style="z-index: 1; left: 469px; top: 44px; position: absolute; height: 314px; width: 514px" BackColor="#993366"></asp:ListBox>
        <asp:Label ID="lblSearchBar" runat="server" style="z-index: 1; left: 471px; top: 383px; position: absolute; width: 314px; height: 20px" Text="Enter Customer Name to see their Orders" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="txtSearchBar" runat="server" style="z-index: 1; left: 470px; top: 410px; position: absolute; height: 30px; width: 246px; right: 761px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 468px; top: 503px; position: absolute; height: 20px; width: 106px"></asp:Label>
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 472px; top: 582px; position: absolute; height: 30px; width: 130px" Text="Add" OnClick="btnAdd_Click" BackColor="#6699FF" />
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 665px; top: 582px; position: absolute; height: 30px; width: 130px" Text="Edit" OnClick="btnEdit_Click" BackColor="Lime" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; top: 582px; position: absolute; left: 856px; height: 30px; width: 130px; right: 499px"  Text="Delete" OnClick="btnDelete_Click" BackColor="#CC3300" />
        <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 856px; top: 410px; position: absolute; height: 30px; width: 130px"  Text="Apply" OnClick="btnApply_Click" BackColor="Yellow" />
        <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; left: 856px; top: 456px; position: absolute; height: 30px; width: 130px" Text="Display All" OnClick="btnDisplayAll_Click" BackColor="Fuchsia" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 472px; top: 686px; position: absolute; width: 514px" Text="Return to Main Menu" />
    </form>
</body>
</html>
