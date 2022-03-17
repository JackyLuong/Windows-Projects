<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="PayrollAsp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Payroll Calculator App</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Payroll Calculator</h1>
            <img src ="img/fc RX-7.jpg"/>
            <table>
                <tr>
                    <td>Hours Worked:</td>
                    <td>
                        <asp:TextBox ID="txtHours" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Hours Rate:</td>
                    <td>
                        <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Hours Rate:</td>
                    <td>
                        <asp:Button ID="Calculate" runat="server" Text="Calculate" />
                        <asp:Button ID="Clear" runat="server" Text="Clear" />
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
