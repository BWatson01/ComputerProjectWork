<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnCustomer.aspx.cs" Inherits="FrontEnd.AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 29px;
            width: 1172px;
            margin-top: 0px;
            background-color: #FF5050;
        }
    </style>
</head>
<body style="background-color: #FF5050">
    <form id="form1" runat="server">
        &nbsp;<asp:Button ID="btnOk" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 45px; top: 486px; position: absolute; " Text="OK" />
        <asp:TextBox ID="txtCustomerName" runat="server" style="z-index: 1; left: 191px; top: 61px; position: absolute; width: 184px"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 191px; top: 131px; position: absolute; height: 20px; width: 188px"></asp:TextBox>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 202px; top: 289px; position: absolute; width: 198px"></asp:TextBox>
        <div style="height: 10px; background-color: #FF5050; width: 1013px; margin-top: 0px;">
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 65px; top: 67px; position: absolute; height: 18px" Text="Customer Name"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 28px; top: 287px; position: absolute" Text="Customer PhoneNumber"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 48px; top: 369px; position: absolute; right: 1362px; height: 17px" Text="Active"></asp:Label>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 44px; top: 136px; position: absolute" Text="Customer PostCode"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 49px; top: 209px; position: absolute; height: 37px; right: 1376px; width: 121px" Text="Customer Address"></asp:Label>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 43px; top: 437px; position: absolute; height: 20px; right: 1348px" Text="[IblError]"></asp:Label>
            <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 191px; top: 207px; position: absolute; width: 192px"></asp:TextBox>
            <asp:CheckBox ID="txtActive" runat="server" style="z-index: 1; left: 94px; top: 367px; position: absolute; height: 26px; width: 40px" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 117px; top: 487px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
