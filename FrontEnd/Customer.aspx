<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="FrontEnd.Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FF5050">
    <form id="form1" runat="server">
        <asp:ListBox ID="lstCustomer" runat="server" BackColor="#FFFF99" style="z-index: 1; left: 249px; top: 53px; position: absolute; height: 359px; width: 471px"></asp:ListBox>
        <asp:TextBox ID="txtSearchBar" runat="server" style="z-index: 1; left: 307px; top: 481px; position: absolute; height: 19px; width: 251px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" BorderColor="#FFFF66" style="z-index: 1; left: 312px; top: 440px; position: absolute" Text="Please Enter a Customer Name"></asp:Label>
        <div style="height: 10px; background-color: #FF5050; width: 1170px; margin-right: 239px;">
            <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 227px; top: 480px; position: absolute" Text="Search" OnClick="Button1_Click1" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 303px; top: 526px; position: absolute" Text="Display All" OnClick="Button2_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 830px; top: 454px; position: absolute; height: 20px"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 659px; top: 577px; position: absolute; width: 58px; height: 32px;" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnEdit2" runat="server" OnClick="btnEdit2_Click" style="z-index: 1; left: 536px; top: 577px; position: absolute; width: 48px; height: 33px; right: 997px;" Text="Edit" />
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click1" style="z-index: 1; left: 410px; top: 578px; position: absolute; height: 34px; width: 52px" Text="Add" />
        </div>
    </form>
</body>
</html>
