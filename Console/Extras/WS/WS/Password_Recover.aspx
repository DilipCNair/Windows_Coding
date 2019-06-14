<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Password_Recover.aspx.cs" Inherits="EH1.Password_Recover" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 440px;
        }
    </style>
</head>
<body>
        <hr />
        <form id="form1" runat="server">
            <center>
                <h2><strong class="auto-style1"><em>Password Recovery&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Italic="True" Font-Size="Medium" OnClick="LinkButton1_Click">Go Back and login again</asp:LinkButton>
                    </em></strong></h2></center>
    <div>
    
    </div>
        <hr />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="Maroon" Text="Enter your email address" Font-Size="Larger"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" BorderColor="Blue" BorderStyle="Solid" Height="20px" Width="185px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="Blue" Font-Bold="True" Font-Italic="True" ForeColor="White" OnClick="Button1_Click" Text="Submit" Width="150px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
        <hr />
        </body>
</html>
