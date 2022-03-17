<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="payRollWebForm.aspx.cs" Inherits="PayRollWebForm.payRollWebForm" %>

<DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payroll Calculator App</title>
    <link href="BootstrapTemp.css" rel="stylesheet" />
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <div class ="container-fluid bg-primary">
        <h1 class ="container">Payroll Calculator</h1>
    </div>
    <form id="form1" runat="server" class ="container">
        <div class ="container">
            <img src ="img/fc RX-7.jpg"/>
            <table>
                <tr>
                    <td>Hours Worked:</td>
                    <td>
                        <asp:TextBox ID ="txtHours" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator 
                            ID="RequiredFieldValidator1" 
                            runat="server" 
                            ErrorMessage="Hours is required" 
                            ControlToValidate="txtHours"
                            CssClass ="validator" 
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        
                        <asp:RangeValidator 
                            ID="RangeValidator2" 
                            runat="server" 
                            ErrorMessage="Hours has to be a number 0 - 120" Type="Double"
                            ControlToValidate="txtHours"
                            CssClass ="validator" 
                            MaximumValue="120" 
                            MinimumValue="0"
                            Display="Dynamic">
                        </asp:RangeValidator>
                    </td>
                </tr>

                <tr>
                    <td>Hours Rate:</td>
                    <td>
                        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="RequiredFieldValidator2" 
                            runat="server" 
                            ErrorMessage="Rate is required" 
                            ControlToValidate="txtRate"
                            CssClass ="validator"
                            Display ="Dynamic">>
                        </asp:RequiredFieldValidator>

                        <asp:RangeValidator 
                            ID="RangeValidator1" 
                            runat="server" 
                            ErrorMessage="Rate has to be a number 0 - 500"
                            ControlToValidate="txtRate" 
                            Type="Double" 
                            MinimumValue="0" 
                            MaximumValue="500"
                            CssClass ="validator"
                            Display ="Dynamic">
                        </asp:RangeValidator>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="Calculate" runat="server" Text="Calculate" OnClick="Calculate_Click" />
                        <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" />
                    </td>
                </tr>
                <tr>
                    <td>Pay Amount:</td>
                    <td>
                        <asp:Label ID="lblPay" runat="server" Text="Pay Amount"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
