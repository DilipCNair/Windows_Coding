<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Secure Web Application</title>
    
    
</head>
<body style="font-family: Calibri">
    <center>
    <form id="form1" runat="server" allign ="Centre">
    <div>
    
        <br />
    
        <br />
    
        <hr style="margin-top: 26px" />
    
    </div>
        <p>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#009900">Enter Your Credentials</asp:Label>
        </p>
        <hr />
        <p>
            <asp:Label ID="Label2" runat="server" Font-Overline="False" Font-Size="Large" ForeColor="#333333" Font-Bold="True">Username :</asp:Label>
&nbsp;

           <asp:TextBox ID="TextBox1" runat="server" BorderColor="Blue" BorderStyle="Solid" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        &nbsp;<asp:Label ID="Label4" runat="server" Font-Size="Large" ForeColor="#333333" Font-Bold="True">Password : </asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" oncopy="return false" onpaste="return false" oncut="return false" BorderColor="Blue" BorderStyle="Solid" TextMode="Password" style="margin-left: 2px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Font-Italic="True"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Italic="True" OnClick="LinkButton1_Click">Forgot My Password</asp:LinkButton>
        <br />
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="Blue" BorderColor="Blue" BorderStyle="Double" BorderWidth="2px" ForeColor="White" Text="Login" Width="237px" OnClick="Button1_Click" Font-Bold="True" Height="30px" style="margin-left: 0px" Font-Italic="True" />
        </p>
        <p>
            &nbsp;</p>
        <hr />
        <p><br />
        <asp:Label ID="Label5" runat="server" ForeColor="Black" Font-Bold="True" Font-Italic="True" Font-Size="X-Large">----------&gt;Dont&#39;t have an account&lt;----------</asp:Label>
        &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" BackColor="Blue" BorderColor="Blue" BorderStyle="Double" BorderWidth="2px" ForeColor="White" Text="Signup Here" Width="160px" OnClick="Button2_Click" OnClientClick="WebForm2" PostBackUrl="WebForm2" Font-Bold="True" Height="30px" Font-Italic="True" />
        </p>
    </form>
    <hr style="margin-top: 26px" />
        </center>
    <hr style="margin-top: 26px" />
   </body>
</html>
