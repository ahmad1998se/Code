<%-- 
    Document   : index
    Created on : Jan 6, 2021, 11:13:27 AM
    Author     : Ahmad
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <style>
        .div-1 {
            background-color: gray;
        }

    </style>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <form action="index.jsp">
            UserName : <input type="text" name="UserName"  /><br>
            Password : <input type="password" name="Password" /><br>
            <input type="submit" value="Sign in "/>
            <div class="div-1">The True UserName:Ahmad2016<br> Password:Ahmad2016</div>
        </form>




        <%-- start web service invocation --%><hr/>
        <%
        try {
            login.WS1_Service service = new login.WS1_Service();
            login.WS1 port = service.getWS1Port();
             // TODO initialize WS operation arguments here
            java.lang.String userName = request.getParameter("UserName");
            java.lang.String password = request.getParameter("Password");
            // TODO process result here
            java.lang.String result = port.authentication(userName, password);
            out.println("Result = "+result);
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        %>
        <%-- end web service invocation --%><hr/>
    </body>
</html>
