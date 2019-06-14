<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" validateRequest="True" Inherits="Telephone_Directory.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">


<head runat="server">
    <meta charset="utf-8" />
    <title>Telephone Directory</title>
   <link type ="text/css" rel="stylesheet" href="Login.css" /> 
</head>


<body>
<form id="form1" runat="server">
    <div id="Menu">   
        <br />
        <br />
        <table align="center" class="auto-style2">
            <tr>
                <td class="auto-style7">
        <asp:Label ID="Label5" align="center" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="XX-Large" ForeColor="White" Text="Telephone Directory" CssClass="auto-style1"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
    </div>
    <div id="Bottomofmenu">
        <br />
        <br />    
    </div>
        <br />
        <br />

    <div id="DILIP">
    </div>
  
    <div id="Table">
      

        <center>
        <table class="auto-style1">

            <tr>
                <td class="auto-style3">
                    <asp:Label class="Di" ID="Label3" runat="server" Text="Name :" ForeColor="Black"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server" BorderColor="Blue" BorderStyle="Solid" Height="24px" Width="138px" cssclass="tbox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Number :" ForeColor="Black"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server" BorderColor="Blue" BorderStyle="Solid" Height="24px" Width="138px" cssclass="tbox"></asp:TextBox>
                </td>
            </tr>
           
        </table>
            </center>

        </div>
    
    

<div id="Button">
        <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Italic="True" ForeColor="Red"></asp:Label>
        <br /><br />

        <asp:Button class="but" ID="Button1" runat="server" BackColor="#FDD922" ForeColor="Black" Height="43px" OnClick="Button1_Click" Text="LOGIN" Width="115px" BorderStyle="Solid" BorderColor="#FDD922" Font-Bold="False" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button class="but" ID="Button2" runat="server" BackColor="#FDD922" ForeColor="Black" Height="43px" OnClick="Button2_Click" Text="SIGNUP" Width="115px" BorderStyle="Solid" BorderColor="#FDD922" Font-Bold="False" />
        <br />
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="i accept" />
        <br />
        <br />
        <br />
  
  </div>  
     </form>
   <%-- <div id="Bottom_Menu2">
    </div>--%>

    </body>



</html>
