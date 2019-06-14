<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change_Password.aspx.cs" Inherits="EH1.Change_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 520px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 260px;
        }
        .auto-style4 {
            width: 260px;
            height: 50px;
        }
        .auto-style5 {
            height: 50px;
        }
        .auto-style6 {
            margin-left: 1080px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <hr />
    
    </div>
        <div class="auto-style1">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Green" Text="Password Updation"></asp:Label>
        </div>
        <hr />
        <p class="auto-style6">
            <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" Font-Italic="True" OnClick="LinkButton2_Click">Go back and login</asp:LinkButton>
        </p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="Maroon" Text="Enter new password :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBox1" runat="server" oncopy="return false" onpaste="return false" oncut="return false"  BorderColor="#3333FF" BorderStyle="Solid" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="Maroon" Text="Confirm your password :"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" oncopy="return false" onpaste="return false" oncut="return false"  BorderColor="#3333FF" BorderStyle="Solid" TextMode="Password"></asp:TextBox>
                    <br />
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="Button1" runat="server" BackColor="Blue" BorderStyle="Solid" ForeColor="White" Height="34px" OnClick="Button1_Click" Text="Submit" Width="129px" />
        </p>
    </form>
    <hr />
</body>
</html>
