<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_008.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            background-color: #008080;
            font-size: large;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            First Value:&nbsp;
            <asp:TextBox ID="inputFirstValue" runat="server"></asp:TextBox>
            <br />
            <br />
            Second Value: <asp:TextBox ID="inputSecondValue" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="additionButton" runat="server" OnClick="Button1_Click" Text="+" />
&nbsp;
            <asp:Button ID="subtractionButton" runat="server" OnClick="subtractionButton_Click" Text="-" />
&nbsp;
            <asp:Button ID="multiplicationButton" runat="server" OnClick="multiplicationButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="divisionButton" runat="server" OnClick="divisionButton_Click" Text="/" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" BackColor="#99CCFF" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
    </form>
</body>
</html>
