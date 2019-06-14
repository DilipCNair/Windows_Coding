<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="EH1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet1" type="text/css" href="mystyle.css" />
    <title>Secure Web Application</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"><style type="text/css"  />
<style>
body {
	background-image: url(Elegant_Background-5.jpg);
}
body,td,th {
	color: #F0F0F0;
}
                                                                       .auto-style5 {
                                                                           width: 57%;
                                                                           height: 151px;
                                                                       }
                                                                       .auto-style6 {
                                                                           width: 376px;
                                                                       }
                                                                       .auto-style7 {
                                                                           width: 357px;
                                                                       }
                                                                       .auto-style8 {
                                                                           font-weight: bold;
                                                                           font-style: italic;
                                                                       }
                                                                   </style></head>
<body style="font-family: Calibri; text-align: justify;">
    
    <form id="form1" runat="server">
    <div>
        <br />
        <hr />
        &nbsp<br />
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;
        &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp;      
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="XX-Large" Text="Creating Account" ForeColor="Green" CssClass="label"></asp:Label>
        <b>
        <em><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink2" runat="server" Font-Bold="False" Font-Underline="True" ForeColor="Blue" NavigateUrl="WebForm1.aspx">Go Back and Login</asp:HyperLink>
        </strong></em>
        <br />
        </b><br /> 
        <hr />
        <br />
      <br /></div>
        <center>
       
                      <table class="auto-style5">

                          <tr>
                              <td class="auto-style6">
                      <asp:Label ID="Label1" runat="server" Font-Bold="False" FFont-Size="Large" Text="Give a Username  : " style="font-family: calibri; font-weight: 700;" ForeColor="Black" Font-Size="Large" CssClass="auto-style8"></asp:Label>     </td>
                              <td class="auto-style7">             
                      <asp:TextBox ID="TextBox1" runat="server" BorderColor="Blue" BorderStyle="Solid" CssClass="textbox"></asp:TextBox>         
                              </td>
                          </tr>
                          <tr>
                              <td class="auto-style6">         
                      <asp:Label ID="Label5" runat="server" Font-Size="Large" Text="Give a Password : " style="font-family: calibri" ForeColor="Black" CssClass="auto-style8"></asp:Label>
                              </td>
                              <td class="auto-style7">
                      <asp:TextBox ID="TextBox2" runat="server" oncopy="return false" onpaste="return false" oncut="return false" BorderColor="Blue" BorderStyle="Solid" TextMode="Password" CssClass="textbox"></asp:TextBox>
                         
                
                              </td>
                          </tr>
                          <tr>
                              <td class="auto-style6">
                         
                
                    <asp:Label ID="Label6" runat="server" Font-Size="Large" Text="Confirm the Password :" ForeColor="Black" CssClass="auto-style8"></asp:Label>
                              </td>
                              <td class="auto-style7">
                    <asp:TextBox ID="TextBox3" runat="server" oncopy="return false" onpaste="return false" oncut="return false"  BorderColor="Blue" BorderStyle="Solid" TextMode="Password"></asp:TextBox>        
               
          
          
                              </td>
                          </tr>
                          <tr>
                              <td class="auto-style6">        
               
          
          
          <asp:Label ID="Label8" runat="server" Font-Size="Large" Text="Enter The Captcha : " ForeColor="Black" CssClass="auto-style8"></asp:Label>
                              </td>
                              <td class="auto-style7">
         <asp:TextBox ID="TextBox4" runat="server" BorderColor="Blue" BorderStyle="Solid"></asp:TextBox>
                              </td>
                          </tr>
                          <tr>
                              <td class="auto-style6">
          <asp:Image ID="imgCaptcha" runat="server" style="margin-left: 80px" />
                              </td>
                              <td class="auto-style7">
          <asp:Button ID="Button2" runat="server" BackColor="Blue" BorderColor="Blue" BorderStyle="Double" BorderWidth="2px" ForeColor="White" Text="Refresh" Width="113px" OnClick="Button1_Click" Font-Bold="True" Font-Underline="False" Height="30px" style="margin-left: 0px" Font-Italic="True" />
          
            
                              </td>
                          </tr>
        </table>
         <br />
                      <asp:CheckBox ID="CheckBox1" runat="server" ForeColor="#000066" Text="I Accept The Terms and Conditions" />
                      <br />
                      <br />
                      <asp:HyperLink ID="HyperLink1" runat="server" Font-Underline="True" ForeColor="Blue" NavigateUrl="TandC.aspx">View Our Terms and Conditions</asp:HyperLink>
                      <br />
                      <br />
&nbsp;<asp:Label ID="Label9" runat="server" ForeColor="Red" Font-Italic="True"></asp:Label>
            <asp:Label ID="Label2" runat="server" ForeColor="Red" Font-Italic="True"></asp:Label>
            <asp:Label ID="Label7" runat="server" ForeColor="Red" Font-Italic="True"></asp:Label>

      
                      <br />

      
            <p>

      
            <asp:Button ID="Button1" runat="server" BackColor="Blue" BorderColor="Blue" BorderStyle="Double" BorderWidth="2px" ForeColor="White" Text="Submit" Width="161px" OnClick="Button1_Click" Font-Bold="True" Font-Underline="False" Height="30px" Font-Italic="True" />
        </p>
    </form>
    <p>
        &nbsp;</p>
    <hr />
    <hr />
    </body>
</html>
