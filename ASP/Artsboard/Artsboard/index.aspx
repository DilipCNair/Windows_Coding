<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Artsboard.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Amazing Sketches</title>
    <link type ="text/css" rel="stylesheet" href="index.css" /> 
</head>
<body>
</body>
</html>
<html xmlns="http://www.w3.org/1999/xhtml">
<body>
    <form id="form2" runat="server">
        <div id ="Top_above"> 
            
        <br />
        <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Menu" CssClass="mlbl"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Artsboard" CssClass="lbl" ForeColor="White"></asp:Label>
        <asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White" Font-Underline="false" CssClass="Login">LOGIN</asp:LinkButton>
        <asp:LinkButton ID="LinkButton3" runat="server" ForeColor="White"  Font-Underline="False" CssClass="Sign_up">SIGNUP</asp:LinkButton>
        <br />
            <br />
        <br />
    </div>
        <div id ="Top_below"> 
            <br />
            <br />
    </div>
        <div id="bgpic">
            <p class="doc">

                Art is a diverse range of human activities in creating visual, auditory or performing artifacts,
                artworks, expressing the author's imaginative or technical skill, intended to be appreciated for their beauty or emotional power.

            </p>
           

           <div id="box"></div>

             <asp:Button ID="Button1" runat="server" Text="Submit" cssclass="btn" BackColor="#215702" BorderColor="#215702" ForeColor="White" Width="333px" BorderStyle="Solid"/>
            <asp:Label ID="Label4" runat="server" Text="user login" CssClass="lbl3"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Enter Username :" cssclass="lbl1"></asp:Label>
           
            <asp:TextBox ID="TextBox1" runat="server" CssClass="txtbox1" BorderColor="#215702" BorderStyle="Solid" Font-Size="X-Large" Height="40px" Width="335px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="txtbox2" BorderColor="#215702" BorderStyle="Solid" Font-Size="X-Large" Height="40px" TextMode="Password" Width="335px"></asp:TextBox>
            
            <p class="text">

                 In their most general form these activities include the production of works of art, the criticism of art, 
                the study of the history of art, and the aesthetic dissemination of art. Architecture is often included as one of the visual arts.
            
            </p>
           
            <br /> <br /><br />
            <asp:Label ID="Label3" runat="server" Text="Enter Password :" CssClass="lbl2"></asp:Label>
            <br /><br /><br /><br /><br /><br /><br /><br /><br />
            
            <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
 </div>
        
        <div id ="Bottom_above"> 
            <br />
    </div>
        <div id ="Bottom_below"> 
            <br />
            <br />
    </div>
    </form>
</body>
</html>
