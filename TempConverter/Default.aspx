<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TempConverter.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Konvertera Tempraturer</title>
    <link href="~/Content/style.css" rel="stylesheet" />
</head>
<body>
    <div id="container">
        <header><h1>Konvertera Temperaturer</h1></header>
        <hr />
        <form id="form1" runat="server">
        <div class="formItems">
            <p>Starttemperatur:</p>
            <asp:TextBox ID="StartTempTextBox" runat="server"></asp:TextBox>
        </div>
        <div class="formItems">
            <p>Sluttemperatur:</p>
            <asp:TextBox ID="EndTempTextBox" runat="server"></asp:TextBox>
        </div>
        <div class="formItems">
            <p>Temperatursteg:</p>
            <asp:TextBox ID="TempScaleTextBox" runat="server"></asp:TextBox>
        </div>
        <div class="formItems">
            <p>Typ av konvertering</p>
            <p><asp:RadioButton ID="CF_RadioButton" runat="server" /></p>
            <p><asp:RadioButton ID="FC_RadioButton" runat="server" /></p>
        </div>
        <div class="formItems">
            <asp:Button ID="ConvertButton" runat="server" Text="Konvertera" OnClick="ConvertButton_Click" />
        </div>
        </form>
    </div>
</body>
</html>
