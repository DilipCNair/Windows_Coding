<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="EH1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            width: 237px;
        }
        .auto-style4 {
            height: 23px;
            width: 237px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <hr />
        <p>
            <strong><em>Welcome
            <asp:Label ID="Label1" runat="server"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </em></strong>
        </p>
        <p>
            <strong><em>
            <asp:Label ID="Label2" runat="server" Text="Please Enter Your Remaining Details"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#CC0000" BorderStyle="Solid" Font-Italic="True" ForeColor="White" Height="35px" OnClick="Button2_Click" Text="Sign Out" Width="106px" />
            </em></strong>
        </p>
        <hr />
        <p>
            &nbsp;</p>
        <table align="center" class="auto-style1">
            <tr>
                <td class="auto-style3">
            <strong><em>
            <asp:Label ID="Label3" runat="server" Text="First Name :"></asp:Label>
            </em></strong>
                </td>
                <td>             
                      <asp:TextBox ID="TextBox1" runat="server" BorderColor="Blue" BorderStyle="Solid" CssClass="textbox" Width="180px"></asp:TextBox>         
                              </td>
            </tr>
            <tr>
                <td class="auto-style4">
            <strong><em>
            <asp:Label ID="Label4" runat="server" Text="Middle Name :"></asp:Label>
            </em></strong>
                </td>
                <td class="auto-style2">             
                      <asp:TextBox ID="TextBox2" runat="server" BorderColor="Blue" BorderStyle="Solid" CssClass="textbox" Width="180px"></asp:TextBox>         
                              </td>
            </tr>
            <tr>
                <td class="auto-style3">
            <strong><em>
            <asp:Label ID="Label5" runat="server" Text="Last Name :"></asp:Label>
            </em></strong>
                </td>
                <td>             
                      <asp:TextBox ID="TextBox3" runat="server" BorderColor="Blue" BorderStyle="Solid" CssClass="textbox" Width="180px"></asp:TextBox>         
                              </td>
            </tr>
            <tr>
                <td class="auto-style3">
            <strong><em>
            <asp:Label ID="Label6" runat="server" Text="email address :"></asp:Label>
            </em></strong>
                </td>
                <td>             
                      <asp:TextBox ID="TextBox4" runat="server" BorderColor="Blue" BorderStyle="Solid" CssClass="textbox" Width="180px"></asp:TextBox>         
                              </td>
            </tr>
            <tr>
                <td class="auto-style3">
            <strong><em>
            <asp:Label ID="Label7" runat="server" Text="Your Occupation :"></asp:Label>
            </em></strong>
                </td>
                <td>             
                      <asp:TextBox ID="TextBox5" runat="server" BorderColor="Blue" BorderStyle="Solid" CssClass="textbox" Width="180px"></asp:TextBox>         
                              </td>
            </tr>
            <tr>
                <td class="auto-style3">
            <strong><em>
            <asp:Label ID="Label8" runat="server" Text="Address for Correspondance :"></asp:Label>
            </em></strong>
                </td>
                <td>             
                      <asp:TextBox ID="TextBox6" runat="server" BorderColor="Blue" BorderStyle="Solid" CssClass="textbox" Height="75px" TextMode="MultiLine" Width="300px"></asp:TextBox>         
                              </td>
            </tr>
        </table>
        <br />
        <hr />
        <p>

      
            <asp:Label ID="Label9" runat="server" Font-Italic="True" ForeColor="Red"></asp:Label>
        </p>

      
            <asp:Button ID="Button1" runat="server" BackColor="Blue" BorderColor="Blue" BorderStyle="Double" BorderWidth="2px" ForeColor="White" Text="Submit" Width="161px" OnClick="Button1_Click" Font-Bold="True" Font-Underline="False" Height="30px" Font-Italic="True" />
    </form>
        <hr />
        </body>
</html>
