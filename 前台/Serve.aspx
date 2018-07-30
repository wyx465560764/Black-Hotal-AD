<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Serve.aspx.cs" Inherits="Serve" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link rel="stylesheet" type="text/css" href="css/reset.css"/>
<link rel="stylesheet" type="text/css" href="css/common.css"/>
<title>酒店服务</title>

</head>
<body>
	<div class="public-header0">
         <div class="public-container">
            <div class="name-pic"></div>
            <div class="header-name"><span class="name">Black Hotel   服务</span></div>
         </div>
    </div>
	<div class="public-header">
        
        <div class="public-container">
             <a href="Main.aspx"><div class="div-item"><span class="item">&nbsp;&nbsp;&nbsp;&nbsp;首页</span></div></a>
             <a href=""><div class="div-item"><span class="item">酒店介绍</span></div></a>
             <a href="Food.aspx"><div class="div-item"><span class="item">餐饮美食</span></div></a>
             <a href=""><div class="div-item"><span class="item">新闻动态</span></div></a>
             <a href="Serve.aspx"><div class="div-item"><span class="item">客房服务</span></div></a>
             <a href=""><div class="div-item"><span class="item">在线留言</span></div></a>
        </div>
	</div>
<div class="order-bg">
<div class="public-container0">
<div class="public-container1">
<form class="form1" runat="server">
<div class="order-text1">
      <span class="text-number">01</span><span class="text-type">&nbsp;客房服务</span>   <hr style="width: 900px;"> 
</div>
 
      <div class="house-number">
         <label for="house-number">客房号:&nbsp;</label>
         <input type="text"  name="house-number"  value="" />
      </div>
    <div class="house-serve">
        <label for="house-serve">服务内容:&nbsp;</label>
        <textarea cols="50" rows="10" name="house-serve">在这里输入内容...</textarea>
        <asp:ImageButton ID="Imagebutton3" runat="server" Width="100px" Height="22px" value="提交"
    OnClick="Imagebutton_Click3"></asp:ImageButton>
           
    </div>
   
</form>  
</div>
</div>
</div>
</body>
</html>
