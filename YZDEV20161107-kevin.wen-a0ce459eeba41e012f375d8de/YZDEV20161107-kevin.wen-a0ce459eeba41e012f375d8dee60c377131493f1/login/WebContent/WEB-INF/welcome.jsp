<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>
<%@ page import="com.augmentum.login.model.*" %>
<%@ page import="com.augmentum.login.*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
  <head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <title>Login</title>
  </head>
  <script type="text/javascript">
  function login(){
      var formObj = document.getElementById("loginForm");
      formObj.submit();
  }
  </script>
  <body>  
  <%
  User user =null; 
  if(request.getSession().getAttribute("user") != null) {
     user = (User)request.getSession().getAttribute(Constants.USER);
  }
  %>
  <h2>welcome <%=user.getUserName() %></h2>
  </body>
</html>