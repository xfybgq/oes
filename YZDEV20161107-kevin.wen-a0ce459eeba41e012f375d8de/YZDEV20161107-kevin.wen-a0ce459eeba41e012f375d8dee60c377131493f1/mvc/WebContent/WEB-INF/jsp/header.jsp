<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ page import="com.augmentum.oes.model.*" %>
    <div id="header">
        <div class="container">
            <div class="logo"><img src="static/images/LOGO_Web_40x240.png"></div>
            <div class="msg">Online Exam Web System </div>
            <div class="user_dispaly">
               <div class="user_header">
                  <img alt="header-photo" src="static/images/ICN_Web_PersonalInformation_20x20.png" >
                  <label class="name"><%User user = (User)session.getAttribute("user"); out.print(user.getUserName());%></label>
               </div>
               <div class="user_info">
                 <div class="language">中文</div>
                 <div class="logout"><a href="logout.action">Logout</a></div>
               </div>
            </div>
        </div>
    </div>
