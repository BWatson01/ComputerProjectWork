<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Manufacturer.aspx.cs" Inherits="FrontEnd.Manufacturer" Theme="" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 13px;
            margin-bottom: 0px;
        }
        .auto-style1 {
            background-color: #666666;
        }
    </style>
</head>
<body style="height: 11px; width: 999px; background-color: #666666;">
    <form id="form1" runat="server">
        <div>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 30px; top: 414px; position: absolute; width: 435px; height: 25px;" Text="Please Enter a Manufacturer Name" Font-Bold="True" Font-Size="Larger" Font-Strikeout="False"></asp:Label>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            &nbsp;</p>
        <asp:TextBox ID="TextBox" runat="server" style="z-index: 1; left: 29px; top: 455px; position: absolute; width: 197px; height: 23px;" BackColor="White" CssClass="auto-style1"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 160px; top: 526px; position: absolute; width: 90px; height: 29px;" Text="Display All" OnClick="Button2_Click" BackColor="#99FF33" CssClass="auto-style1" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 27px; top: 637px; position: absolute; height: 29px; width: 90px; right: 1368px;" Text="Add" OnClick="Button3_Click" BackColor="#3399FF" CssClass="auto-style1" />
        <asp:ListBox ID="lstManufacturers" runat="server" style="z-index: 1; left: 23px; top: 38px; position: absolute; height: 321px; width: 584px" BackColor="#FF9966" CssClass="auto-style1" Font-Bold="True" Font-Italic="True" Font-Size="Medium" Font-Underline="True" ForeColor="White"></asp:ListBox>
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 296px; top: 633px; position: absolute; width: 90px; height: 29px;" Text="Delete" OnClick="Button6_Click" BackColor="#993399" CssClass="auto-style1" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 370px; position: absolute; height: 20px; margin-top: 4px;" Text="lblError" CssClass="auto-style1" ForeColor="#FF3300"></asp:Label>
        <asp:Button ID="Button6" runat="server" style="z-index: 1; left: 30px; top: 527px; position: absolute; width: 90px; height: 29px" Text="Search" OnClick="Button6_Click1" BackColor="Aqua" CssClass="auto-style1" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 158px; top: 634px; position: absolute; width: 90px; height: 29px; right: 1237px;" Text="Edit" BackColor="Yellow" CssClass="auto-style1" />
    </form>
</body>
</html>
