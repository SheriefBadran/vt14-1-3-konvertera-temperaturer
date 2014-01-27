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
        <div id ="leftColumn">
            <form id="form1" runat="server">
                <%-- VALIDATION SUMMARY --%>
                <asp:ValidationSummary ID="ValidationSummary" runat="server" HeaderText="Fel inträffade! Åtgärda felen och försök igen." DisplayMode="BulletList" />

                <%-- CONTROL FOR START TEMP --%>
                <div class="formItems">
                    <p>Starttemperatur:</p>
                    <asp:TextBox ID="StartTempTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorStart" runat="server" ErrorMessage="Fyll i en starttemperatur." Text="*" Display="Dynamic" ControlToValidate="StartTempTextBox"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorStart" runat="server" ErrorMessage="Fyll i ett heltal" Text="*" ControlToValidate="StartTempTextBox" Display="Dynamic" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                    <%--<asp:RangeValidator ID="RangeValidatorStart" runat="server" ErrorMessage="" Text="*" Display="Dynamic" ValidationGroup="TempInput" ControlToValidate="StartTempTextBox" ></asp:RangeValidator>--%>
                </div>

                 <%-- CONTROL FOR END TEMP --%>
                <div class="formItems">
                    <p>Sluttemperatur:</p>
                    <asp:TextBox ID="EndTempTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEnd" runat="server" ErrorMessage="Fyll i en sluttemperatur." Text="*" Display="Dynamic" ControlToValidate="EndTempTextBox"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorEnd" runat="server" ErrorMessage="Fyll i ett heltal." Text="*" ControlToValidate="EndTempTextBox" Display="Dynamic" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                    <%--<asp:RangeValidator ID="RangeValidatorEnd" runat="server" ErrorMessage="" Text="*" Display="Dynamic" ControlToValidate="EndTempTextBox"  ></asp:RangeValidator>--%>
                </div>

                 <%-- CONTROL FOR SCALE-RATE --%>
                <div class="formItems">
                    <p>Temperatursteg:</p>
                    <asp:TextBox ID="TempScaleTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorScale" runat="server" ErrorMessage="Fyll i ett temperaturssteg." Text="*" Display="Dynamic" ControlToValidate="TempScaleTextBox"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidatorScale" runat="server" ErrorMessage="Fyll i ett heltal." Text="*" ControlToValidate="TempScaleTextBox" Display="Dynamic" Type="Integer" Operator="DataTypeCheck"></asp:CompareValidator>
                    <%--<asp:RangeValidator ID="RangeValidatorScale" runat="server" ErrorMessage="Temperatursteget måste ligga mellan 1 och 100." Text="*" Display="Dynamic" MinimumValue="1" MaximumValue="100" ControlToValidate="TempScaleTextBox" ></asp:RangeValidator>--%>
                </div>

                <%-- RADIO BUTTON CONROLS --%>
                <div class="formItems">
                    <p>Typ av konvertering</p>
                    <p class="radio"><asp:RadioButton ID="CF_RadioButton" runat="server" GroupName ="convType" Checked="True" />Celcius till Fahrenheit</p>
                    <p class="radio"><asp:RadioButton ID="FC_RadioButton" runat="server" GroupName ="convType" Checked="False" />Fahrenheit till Celcius</p>
                </div>

                <%-- POST BUTTON --%>
                <div class="formItems">
                    <asp:Button ID="ConvertButton" runat="server" Text="Konvertera" OnClick="ConvertButton_Click" />
                </div>
            </form>
        </div>
        <div id="rightColumn">
            <asp:Table ID="TempConvertResultTable" runat="server" Visible="false"></asp:Table>
        </div>
    </div>
</body>
</html>
