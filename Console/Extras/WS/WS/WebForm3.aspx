<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="EH1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <em>
    
        <br />
        </em>
       <b><em>User</em></b>
        <em>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Label"></asp:Label>
        </em>&nbsp<b><em>Has Been Successfully Created</em><br />
        <br />
        </b> &nbsp;</div>
        <em><strong>
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="False" Font-Underline="True" ForeColor="Blue" NavigateUrl="WebForm1.aspx">Click Here To Login to your account</asp:HyperLink>
        </strong></em>
    </form>
</body>
</html>
