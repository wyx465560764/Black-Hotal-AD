<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<link rel="stylesheet" type="text/css" href="css/reset.css"/>
	<link rel="stylesheet" type="text/css" href="css/common.css"/>
	<script type="text/javascript" src="js/one.js"></script>
	<title>酒店预定页面</title>
</head>
<body>
      <form id="form1" runat="server">
 <div class="public-header0">
         <div class="public-container">
            <div class="name-pic"></div>
            <div class="header-name"><span class="name">Black Hotel   个人信息</span></div>
         </div>
    </div>
	<div class="public-header">
        
        <div class="public-container">
             <a href="Main.aspx""><div class="div-item"><span class="item">&nbsp;&nbsp;&nbsp;&nbsp;首页</span></div></a>
             <a href=""><div class="div-item"><span class="item">酒店介绍</span></div></a>
             <a href=""><div class="div-item"><span class="item">餐饮美食</span></div></a>
             <a href=""><div class="div-item"><span class="item">新闻动态</span></div></a>
             <a href="Serve.aspx"><div class="div-item"><span class="item">客房服务</span></div></a>
             <a href=""><div class="div-item"><span class="item">在线留言</span></div></a>
        </div>
	</div>
<div class="order-bg">
<div class="public-container0">
<div class="public-container1">
<div class="order-text1">     
      <span class="text-number">01</span><span class="text-type">&nbsp;客房选择</span>   <hr style="width: 900px;"> 
<div class="choo">
      <label for="choo">客房选择:&nbsp;</label>
      <select name="cHouse" >
      <option value="请选择">请选择</option>
      <option value="标准间">标准间</option>
      <option value="单间">单间</option>
      <option value="豪华套间">豪华套间</option>
      <option value="总统套房">总统套房</option>
      </select>
  </div>
</div>
    <div class="order-text2">
      <span class="text-number">02</span><span class="text-type">&nbsp;信息填写</span>   <hr style="width: 900px;"> 
   </div>

      <div class="username">
         <label for="username">姓名:&nbsp;</label>
         
           <asp:TextBox ID="txtXM" runat="server" Width="200px" ></asp:TextBox>
            </div>
   
      <div class="telnumber">
      <label for="telnumber">电话:&nbsp;</label>
      
          <asp:TextBox ID="txtDH" runat="server" Width="200px"></asp:TextBox>  
      </div>
      <div class="order-text3">
            <span class="text-number">03</span><span class="text-type">&nbsp;订单填写</span>   <hr style="width: 900px;"> 
      </div>
      <div class="intime">
       <label for="intime1">入住天数:&nbsp;</label>
       <asp:TextBox ID="txtDC" runat="server" Width="128px"></asp:TextBox>
      </div> 
      <div class="refer">   

  <asp:ImageButton ID="Imagebutton" runat="server" Width="100px" Height="22px" value="提交订单"
    OnClick="Imagebutton_Click"></asp:ImageButton>
       <asp:ImageButton ID="Imagebutton2" runat="server" Width="100px" Height="22px"  value="取消订单"
    OnClick="Imagebutton_Click1"></asp:ImageButton>


</div>
</div>
</div>
</div>
</div>
</form>
    
</body>
</html>