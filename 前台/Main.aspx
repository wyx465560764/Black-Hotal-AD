<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
	<meta charset="UTF-8">
	<title>Document</title>
	<link rel="stylesheet" type="text/css" href="css/reset.css"/>
	<link rel="stylesheet" type="text/css" href="css/common.css"/>
	<link rel="stylesheet" type="text/css" href="css/index.css"/>
    <script type="text/javascript" src="js/one.js"></script>
<link rel="stylesheet" type="text/css" href="css/lrtk.css">
<script src="js/jquery1.42.min.js" type="text/javascript"></script>
<script src="js/jquery.superslide.2.1.1.js" type="text/javascript"></script>
</head>

<body>
    <div class="public-header0">
         <div class="public-container">
            <div class="name-pic"></div>
            <div class="header-name"><span class="name">Black Hotel   预订</span></div>
         </div>
    </div>
	<div class="public-header">
        
        <div class="public-container">
             <a href="test.html"><div class="div-item"><span class="item">&nbsp;&nbsp;&nbsp;&nbsp;首页</span></div></a>
             <a href=""><div class="div-item"><span class="item">酒店介绍</span></div></a>
             <a href="Food.aspx"><div class="div-item"><span class="item">餐饮美食</span></div></a>
             <a href=""><div class="div-item"><span class="item">新闻动态</span></div></a>
             <a href="Serve.aspx"><div class="div-item"><span class="item">客房服务</span></div></a>
             <a href=""><div class="div-item"><span class="item">在线留言</span></div></a>
        </div>
	</div>
<div class="index-banner-bg">
        <div class="public-container">
            <div class="index-banner-text">
             <span class="banner-span">欢迎入住酒店</span>
            </div>
            <a href="User.aspx"><div class="banner-button" ><span class="order-text">立即预定</span></div></a></div>
        <div class="www51buycom">
    <ul class="51buypic">
        <li><a href="User.aspx" target="_blank"><img src="image/单间1.jpg" /></a></li>
        <li><a href="User.aspx" target="_blank"><img src="image/单间2.jpg" /></a></li>
        <li><a href="User.aspx" target="_blank"><img src="image/单间3.jpg" /></a></li>
        <li><a href="User.aspx" target="_blank"><img src="image/单间4.jpg" /></a></li>
        <li><a href="User.aspx" target="_blank"><img src="image/单间5.jpg" /></a></li>
        <li><a href="User.aspx" target="_blank"><img src="image/单间6.jpg" /></a></li>
        <li><a href="User.aspx" target="_blank"><img src="image/单间7.jpg" /></a></li>
    </ul>
    <a class="prev" href="javascript:void(0)"></a>
    <a class="next" href="javascript:void(0)"></a>
    <div class="num">
        <ul></ul>
    </div>
</div>

</div>

	<div class="index-introduct">
    <div class="public-container">
        <div class="hotel-pic">
        <p class="introduct-a">公司介绍</p>
        <p class="introduct-b">Company Profile</p>
        <div class="introduct-3"><p class="introduct-c">&nbsp;&nbsp;&nbsp;
        南京思之泉自动化科技有限公司总部位于六朝古都--南京，自2010年成立以来专业从事恒温恒湿、生物安全、理化检测等实验室<br>
整体规划设计、安装和运行，产品标准严格尊循于国家标准及国际标准，根据客户需求融合现代国际最超前实验室设计理念及技术，结合在实验室领域积累的专业知识和工程施工售后经验，得到了客户的一致好评，为团队施工经验增添了新的源泉，思之泉公司为应对国外实验室技术发展需求，于2014年开始与国际接轨，成功的在越南建设恒温恒湿实验室，精湛的施工技术，优良的工艺得到客户的一致好评，也为了进军海外实验室市场奠定了基础，经过数年的努力，合作客户遍及各地，服务网辐射所有沿海经济发达地区。
</p></div>
     </div>
    </div>
    </div>
	<div class="index-panel1">
    <div class="public-container">
        <a href=""><div class="panel1-1"></div></a>
        <a href=""><div class="panel1-2"></div></a>
        <a href=""><div class="panel1-3"></div></a>
     </div>
    </div>

	<div class="public-footer">
	     <div class="public-container">
	     <div class="header-nav">
             <a href=""><div class="div-item0"><span class="item0">&nbsp;&nbsp;&nbsp;&nbsp;首页</span></div></a>
             <a href=""><div class="div-item0"><span class="item0">酒店介绍</span></div></a>
             <a href=""><div class="div-item0"><span class="item0">餐饮美食</span></div></a>
             <a href=""><div class="div-item0"><span class="item0">新闻动态</span></div></a>
             <a href=""><div class="div-item0"><span class="item0">客房服务</span></div></a>
             <a href=""><div class="div-item0"><span class="item0">在线留言</span></div></a>
        </div>
        <div class="last1"><p>xx酒店 版权所有</p></div>
        <p class="last2">渝信息产业部备案管理系统：www.hotel.edu.cn</p>
	     </div>
	</div>
    <script>
        /*鼠标移过，左右按钮显示*/
        $(".www51buycom").hover(function () {
            $(this).find(".prev,.next").fadeTo("show", 0.1);
        }, function () {
            $(this).find(".prev,.next").hide();
        })
        /*鼠标移过某个按钮 高亮显示*/
        $(".prev,.next").hover(function () {
            $(this).fadeTo("show", 0.7);
        }, function () {
            $(this).fadeTo("show", 0.1);
        })
        $(".www51buycom").slide({ titCell: ".num ul", mainCell: ".51buypic", effect: "fold", autoPlay: true, delayTime: 700, autoPage: true });
</script>
</body>
</html>