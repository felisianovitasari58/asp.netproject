<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="printDaftarKPWebUI.aspx.cs" Inherits="mhsAPP.printDaftarKPWebUI" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=10.2.3600.0, Culture=neutral, PublicKeyToken=692fbea5521e1304"
    Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    
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
a.style4:hover{color:#000066;}
a.style4:active{color:#000066;background-image:url(images/nav38633020i.gif)}
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
div.CRKP {
background:#ffffff none repeat scroll 0 0;
border:3px solid #666666;
margin:5px;
padding:5px;
position:relative;
width:740px;
height:300px;
overflow:auto;
}
body {text-align:center;margin:0}
</style>
<script language="javascript" type="text/javascript">
// <!CDATA[

// ]]>
</script>

    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/CSs/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/CSs/default.css"
        rel="stylesheet" type="text/css" />
    <link href="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/CSs/default.css"
        rel="stylesheet" type="text/css" />
        
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="container" style="height: 795px; left: 0px; top: 0px;">
                <div id="g_image3" style="position:absolute; overflow:hidden; left:204px; top:143px; width:28px; height:47px; z-index:0"><img src="images/topmenu_img1.gif" alt="" title="" border="0px" width="28px" height="47px"/></div>
                <div id="g_image5" style="position:absolute; overflow:hidden; left:18px; top:190px; width:187px; height:85px; z-index:1"><img src="images/new_releases_bg.gif" alt="" title="" border="0px" height="204px" style="width: 189px"/></div>
                <div id="g_image2" style="position:absolute; overflow:hidden; left:18px; top:143px; width:187px; height:47px; z-index:2"><img src="images/users_feedback_s.gif" alt="" title="" border="0px" width="187px" height="47px"/></div>
                <div id="g_image9" style="position:absolute; overflow:hidden; left:231px; top:700px; width:536px; height:47px; z-index:3"><img src="images/botmenu_bg.gif" alt="" title="" border="0px" width="536px" height="47px"/></div>
                <div id="g_image10" style="position:absolute; overflow:hidden; left:16px; top:700px; width:187px; height:47px; z-index:4"><img src="images/bot1.gif" alt="" title="" border="0px" width="187px" height="47px"/></div>
                <div id="g_image8" style="position:absolute; overflow:hidden; left:203px; top:700px; width:28px; height:47px; z-index:5"><img src="images/bot2.gif" alt="" title="" border="0px" width="28px" height="47px"/></div>
                <div id="g_image4" style="position:absolute; overflow:hidden; left:231px; top:143px; width:534px; height:47px; z-index:6"><img src="images/products_b.gif" alt="" title="" border="0px" width="535px" height="47px"/></div>
                
<div id="g_shape1" style="position:absolute; overflow:hidden; left:16px; top:750px; width:751px; height:15px; z-index:9"><img border="0px" width="100%" height="100%" alt="" src="images/shape6501497.gif"></div>
<div id="g_text4" style="position:absolute; overflow:hidden; left:35px; top:159px; width:159px; height:298px; z-index:15">
                    <div class="allfont">
                        <div><font class="font12" color="#666699"><B>What's NEW?</B></font></div>
                        <div><font class="font12" color="#666699"><B><br/></B></font></div>
                        <div>
                        <div><font class="font12" color="#666699"></font></div>
                        <font class="font12" color="#666699">
                            <div><font class="font12" color="#666699"><B>*Kerja Praktek</B></font></div><asp:Label ID="lbStatusKP" runat="server" Height="69px" Width="155px"></asp:Label><br />
                            <BR/></font></div>
                        <div><font class="font12" color="#666699">
                            <div><font class="font12" color="#666699"><B>*Tugas Akhir</B></font></div><asp:Label ID="lblStatusTA" runat="server" Height="69px" Width="155px"></asp:Label><br />
                            <br />
                            <div><font class="font12" color="#666699"><B>*Rekrutmen Asisten Dosen</B></font></div><asp:Label ID="lblStatusAsdos" runat="server" Height="69px" Width="155px"></asp:Label></font>&nbsp;</div>
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
                <div id="g_text3" style="position:absolute; overflow:hidden; left:604px; top:750px; width:175px; height:30px; z-index:19">
                    <div class="allfont">
                        <div><font class="font11" face="Tahoma">Copyright </font><font class="font11">&copy;</font><font class="font11" face="Tahoma"> 2013/2014 SITUFTI</font></div>
                    </div>
                </div>
                <div id="g_text2" style="position:absolute; overflow:hidden; left:244px; top:160px; width:519px; height:20px; z-index:20">
                    <div class="allfont">
                        <div><font face="Tahoma"><B><a href="HomeWebUI.aspx" class="style1">Beranda</a></b></font><font color="#333333" face="Tahoma"><B>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</B></font><font face="Tahoma"><B><a href="KPWebUI.aspx" class="style1">Perihal Kerja Praktek</B></font><font color="#333333" face="Tahoma"><B>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</B></font><font face="Tahoma"><B><a href="TAWebUI.aspx" class="style1">Perihal Tugas Akhir</B></font><font color="#333333" face="Tahoma"><B>&nbsp;&nbsp;&nbsp;&nbsp;</B></font><font face="Tahoma"><B><a href="mailto:support@webpage-maker.com" class="style1">Pendaftaran AsDos</a></B></font></div>
        </div>
                </div>
                <div class ="CRKP" style="left: 204px; width: 540px; top: 192px; height: 478px; position: absolute;">
                    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" GroupTreeImagesFolderUrl="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/Images/Tree/" ToolbarImagesFolderUrl="/aspnet_client/System_Web/2_0_50727/CrystalReportWebFormViewer3/Images/Toolbar/" DisplayGroupTree="False" />
                </div>
    <script type="text/javascript">
    $("div.CRKP").scrollTop(300);
    </script>
            </div>
        </div>
    </form>
</body>
</html>

