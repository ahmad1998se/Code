<%-- 
    Document   : GradeSymbol
    Created on : Dec 24, 2020, 7:05:41 PM
    Author     : Ahmad
--%>
<%@page import="pack.Grade"%>  

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<jsp:useBean id="student" class="pack.Grade"/>

<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <style>
   h2 { color: blue; }
        </style>
    </head>
    <body>
        <h1>You Redirect To The True Webpage </h1>
        <h2 >Your Mark In Symbol Is : 
       <%  
    Grade grade=(Grade)request.getAttribute("grade");  
    out.print(grade.getSymbol());  
        %>  
        </h2>
    </body>
</html>
