<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnManufacturer.aspx.cs" Inherits="FrontEnd.AnManufacturer1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 11px;
        }
    </style>
</head>
<body style="height: 8px; margin-bottom: 0px; background-color: #666666;">
    <form id="form1" runat="server">
        <div>
            <p style="margin-bottom: 2px">
                <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 7px; top: 134px; position: absolute; width: 128px; right: 1350px" Text="Address" Font-Bold="True"></asp:Label>
            </p>
        </div>
        <asp:TextBox ID="txtManufacturerName" runat="server" style="z-index: 1; left: 190px; top: 78px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 189px; top: 121px; position: absolute; height: 54px; width: 263px; margin-bottom: 3px"></asp:TextBox>
        <asp:TextBox ID="txtTelephone" runat="server" style="z-index: 1; left: 190px; top: 207px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 190px; top: 260px; position: absolute; width: 168px"></asp:TextBox>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 8px; top: 265px; position: absolute" Text="EmailAddress" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblTelephone" runat="server" style="z-index: 1; left: 8px; top: 208px; position: absolute" Text="Telephone" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblManufacturerName" runat="server" style="z-index: 1; left: 4px; position: absolute; top: 79px; bottom: 649px; margin-bottom: 1px" Text="Manufacturer Name" Font-Bold="True"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 339px; position: absolute" Text="lblError" ForeColor="#FF3300"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 335px; top: 386px; position: absolute; width: 90px; height: 29px;" Text="Cancel" OnClick="Button2_Click" BackColor="#CC00FF" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 186px; top: 386px; position: absolute; width: 90px; height: 29px;" Text="OK" BackColor="#FF9900" />
    </form>
</body>
</html>
