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
            <%-- VALIDATION SUMMARY --%>
            <asp:ValidationSummary ID="ValidationSummary" runat="server" HeaderText="Fel inträffade! Åtgärda felen och försök igen." DisplayMode="BulletList" />

            <%-- CONTROL FOR START TEMP --%>
            <div class="formItems">
                <p>Starttemperatur:</p>
                <asp:TextBox ID="StartTempTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorStart" runat="server" ErrorMessage="Fyll i en starttemperatur." Display="Dynamic" Text="*" ControlToValidate="StartTempTextBox"></asp:RequiredFieldValidator>
            </div>

             <%-- CONTROL FOR END TEMP --%>
            <div class="formItems">
                <p>Sluttemperatur:</p>
                <asp:TextBox ID="EndTempTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEnd" runat="server" ErrorMessage="Fyll i en sluttemperatur." Display="Dynamic" Text="*" ControlToValidate="EndTempTextBox"></asp:RequiredFieldValidator>
            </div>

             <%-- CONTROL FOR SCALE-RATE --%>
            <div class="formItems">
                <p>Temperatursteg:</p>
                <asp:TextBox ID="TempScaleTextBox" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorScale" runat="server" ErrorMessage="Fyll i ett temperaturssteg." Display="Dynamic" Text="*" ControlToValidate="TempScaleTextBox"></asp:RequiredFieldValidator>
            </div>

            <%-- RADIO BUTTON CONROLS --%>
            <div class="formItems">
                <p>Typ av konvertering</p>
                <p class="radio"><asp:RadioButton ID="CF_RadioButton" runat="server" Checked="True" />Celcius till Fahrenheit</p>
                <p class="radio"><asp:RadioButton ID="FC_RadioButton" runat="server"  Checked="False" />Fahrenheit till Celcius</p>
            </div>

            <%-- POST BUTTON --%>
            <div class="formItems">
                <asp:Button ID="ConvertButton" runat="server" Text="Konvertera" OnClick="ConvertButton_Click" />
            </div>
        </form>
    </div>
</body>
</html>
