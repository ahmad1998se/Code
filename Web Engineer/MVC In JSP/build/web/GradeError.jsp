<%-- 
    Document   : GradeError
    Created on : Dec 24, 2020, 7:05:54 PM
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
            h2 { color: #FF0000; }
        </style>
    </head>
    <body>
        <h1>You Enter Wrong value in Mark Field </h1>
        <h2 color:Red>
            <%
                Grade grade = (Grade) request.getAttribute("grade");
                out.print(grade.getSymbol());
            %>  
        </h2>
    </body>
</html>
