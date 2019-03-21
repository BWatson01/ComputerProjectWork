<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnOrder.aspx.cs" Inherits="FrontEnd.AnOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #993366">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblComputerNo" runat="server" style="z-index: 1; left: 149px; top: 125px; position: absolute" Text="ComputerNo"></asp:Label>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 149px; top: 185px; position: absolute" Text="CustomerNo"></asp:Label>
        <asp:Label ID="lblItemName" runat="server" style="z-index: 1; left: 149px; top: 246px; position: absolute" Text="ItemName"></asp:Label>
        <asp:Label ID="lblCustomerName" runat="server" style="z-index: 1; left: 147px; top: 303px; position: absolute" Text="CustomerName"></asp:Label>
        <asp:Label ID="lblInvoice" runat="server" style="z-index: 1; left: 148px; top: 359px; position: absolute" Text="Invoice"></asp:Label>
        <asp:Label ID="lblDeliveryDate" runat="server" style="z-index: 1; left: 146px; top: 422px; position: absolute" Text="DeliveryDate"></asp:Label>
        <asp:Label ID="lblOrderDate" runat="server" style="z-index: 1; left: 145px; top: 492px; position: absolute" Text="OrderDate"></asp:Label>
        <asp:Label ID="lblStatus" runat="server" style="z-index: 1; left: 145px; top: 547px; position: absolute" Text="Status"></asp:Label>
        <asp:TextBox ID="txtComputerNo" runat="server" style="z-index: 1; left: 280px; top: 123px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 280px; top: 186px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtItemName" runat="server" style="z-index: 1; left: 280px; top: 247px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 279px; top: 304px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtInvoice" runat="server" style="z-index: 1; left: 279px; top: 360px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDeliveryDate" runat="server" style="z-index: 1; left: 279px; top: 422px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtOrderDate" runat="server" style="z-index: 1; left: 278px; top: 493px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlStatus" runat="server" style="z-index: 1; left: 281px; top: 545px; position: absolute">
            <asp:ListItem>Processing</asp:ListItem>
            <asp:ListItem>Delivered</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 146px; top: 617px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 541px; top: 605px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 634px; top: 604px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
