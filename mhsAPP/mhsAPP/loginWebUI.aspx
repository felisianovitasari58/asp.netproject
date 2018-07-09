<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginWebUI.aspx.cs" Inherits="mhsAPP._loginWebUI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Web Page Maker : Make your own web page easy!</title>
<style type="text/css">
/*----------font Styles----------*/
.font11 {font-size: 11px;}
.font12 {font-size: 12px;}
.font15 {font-size: 15px;}
.font16 {font-size: 16px;}
.allfont {font-size: 13px;font-family: Arial,Helvetica,Sans-Serif;font-style: normal;font-weight: normal;}
/*----------Para Styles----------*/
DIV,UL,OL /* Left */
{
 margin-top: 0px;
 margin-bottom: 0px;
}
</style>

<style type="text/css">
a.style2:link{color:#FF6600;text-decoration: none;}
a.style2:visited{color:#FF6600;text-decoration: none;}
a.style2:hover{color:#99CC00;background:#ECFFEC;text-decoration: none;}
a.style2:active{text-decoration: none;}
a.style1:link{color:#333399;text-decoration: none;}
a.style1:visited{color:#333399;text-decoration: none;}
a.style1:hover{color:#333399;text-decoration: none;}
a.style1:active{color:#333399;text-decoration: none;}
a.style3:link{color:#FF6600;text-decoration: none;}
a.style3:visited{color:#FF6600;text-decoration: none;}
a.style3:hover{color:#99CC00;background:#ECFFEC;text-decoration: none;}
a.style3:active{text-decoration: none;}
</style>
<style type="text/css">
div#container
{
	position:relative;
	width: 783px;
	margin-top: 0px;
	margin-left: auto;
	margin-right: auto;
	text-align:left; 
}
body {text-align:center;margin:0}
</style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="container" style="height: 575px; left: 0px; top: 0px;">
                <div id="g_image3" style="position:absolute; overflow:hidden; left:204px; top:143px; width:28px; height:47px; z-index:0"><img src="images/topmenu_img1.gif" alt="" title="" border=0 width=28 height=47/></div>
                <div id="g_image5" style="position:absolute; overflow:hidden; left:18px; top:190px; width:187px; height:85px; z-index:1"><img src="images/new_releases_bg.gif" alt="" title="" border=0 height=204 style="width: 189px"/></div>
                <div id="g_image2" style="position:absolute; overflow:hidden; left:18px; top:143px; width:187px; height:47px; z-index:2"><img src="images/users_feedback_s.gif" alt="" title="" border=0 width=187 height=47/></div>
                <div id="g_image9" style="position:absolute; overflow:hidden; left:231px; top:475px; width:536px; height:47px; z-index:3"><img src="images/botmenu_bg.gif" alt="" title="" border=0 width=536 height=47 id="IMG2"/></div>
                <div id="g_image10" style="position:absolute; overflow:hidden; left:16px; top:475px; width:187px; height:47px; z-index:4"><img src="images/bot1.gif" alt="" title="" border=0 width=187 height=47 id="IMG3"/></div>
                <div id="g_image8" style="position:absolute; overflow:hidden; left:203px; top:475px; width:28px; height:47px; z-index:5"><img src="images/bot2.gif" alt="" title="" border=0 width=28 height=47 id="IMG4"/></div>
                <div id="g_image4" style="position:absolute; overflow:hidden; left:231px; top:143px; width:534px; height:47px; z-index:6"><img src="images/products_b.gif" alt="" title="" border=0 width=535 height=47></div>
                
<div id="g_shape1" style="position:absolute; overflow:hidden; left:16px; top:525px; width:751px; height:15px; z-index:9"><img border=0 width="100%" height="100%" alt="" src="images/shape6501497.gif"/></div>
                <div id="g_text4" style="position:absolute; overflow:hidden; left:35px; top:159px; width:159px; height:298px; z-index:15">
                    <div class="allfont">
                        <div><font class="font12" color="#666699"><B>How to Login?<br />
                            <br />
                            Jika anda pertama kali mengunjungi situs ini,<br />
                            silahkan login dengan menggunakan NPM sebagai username dan tanggal lahir dengan
                            format DD/MM/YYYY sebagai password. segera ganti password anda demi menjaga keamanan
                            data anda.</B></font></div>
                    </div>
                </div>
                <div id="g_image1" style="position:absolute; overflow:hidden; left:18px; top:1px; width:745px; height:141px; z-index:16"><img src="images/b001main_right.jpg" alt="" title="" border=0 height=144 id="IMG1" onclick="return IMG1_onclick()" style="width: 746px"></div>
                <div id="g_text1" style="position:absolute; overflow:hidden; left:451px; top:31px; width:272px; height:87px; z-index:18">
                    <div class="allfont">
                        <div><font class="font15" color="#FFFFFF" face="Tahoma"><B><I>Sistem Informasi Tata Usaha
                            <br />
                            Fakultas Teknologi Industri</I></B></font></div>
                    </div>
                </div>
                <div id="g_text3" style="position:absolute; overflow:hidden; left:604px; top:525px; width:175px; height:30px; z-index:19">
                    <div class="allfont">
                        <div><font class="font11" face="Tahoma">Copyright </font><font class="font11">&copy;</font><font class="font11" face="Tahoma"> 2013/2014 SITUFTI</font></div>
                    </div>
                </div>
            </div>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="141px" Style="left: 538px; position: absolute;
            top: 244px; z-index: 99; background-color: #cccccc;" Width="267px" BackColor="#FFE0C0">
            <asp:Label ID="Label3" runat="server" BackColor="Tan" Style="left: 0px; vertical-align: middle;
                position: absolute; top: 7px; text-align: center" Text="Log In" Width="267px"></asp:Label>
            <asp:TextBox ID="txtUserWeb" runat="server" style="left: 91px; position: absolute; top: 39px; z-index: 102;"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="left: 10px; position: absolute; top: 41px; z-index: 103;">User Name:</asp:Label>
            <asp:Label ID="Label2" runat="server" style="left: 10px; position: absolute; top: 68px; z-index: 104;">Password:</asp:Label>
            <asp:TextBox ID="txtPassWeb" runat="server" TextMode="Password" style="left: 91px; position: absolute; top: 65px; z-index: 105;" Width="149px"></asp:TextBox>
            <asp:Button ID="LoginButtonWeb" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login" OnClick="LoginButtonWeb_Click" style="left: 190px; position: absolute; top: 100px; z-index: 106;" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserWeb"
                ErrorMessage="*" Style="left: 247px; position: absolute; top: 42px" ToolTip="Username tidak valid"
                ValidationGroup="Login"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassWeb"
                ErrorMessage="*" Style="left: 246px; position: absolute; top: 64px" ToolTip="Password tidak valid"
                ValidationGroup="Login"></asp:RequiredFieldValidator>
        </asp:Panel>
</form>
</body>
</html>