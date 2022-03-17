<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateForm2.aspx.cs" Inherits="StateDemo.StateForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> I am Page 2</h1>
            <p>
                <asp:Button ID="btn" runat="server" Text="Click Me" OnClick="btn_Click" />
            </p>
            <p>
                <asp:Label ID="lblCount" runat="server" Text="Nr Clicks"></asp:Label>
            </p>
            <p>
                <asp:Button ID="btnGo" runat="server" Text="Go Back" PostBackUrl="~/StateForm.aspx" />
            </p>
        </div>
    </form>
</body>
</html>
