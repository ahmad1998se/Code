<%-- 
    Document   : index
    Created on : Dec 25, 2020, 7:09:38 PM
    Author     : Ahmad
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <style>
            .button {
                background-color: #4CAF50; /* Green */
                border: none;
                color: white;
                padding: 15px 32px;
                text-align: center;
                text-decoration: none;
                display: inline-block;
                font-size: 16px;
            }
        </style>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <form action="ControllerServlet" method="POST">  
            <h2> Enter Your Mark :<input type="text" name="mark" value="90"></h2><br>  

            <input class="button" type="submit" value="Calculate">  
        </form>
    </body>
</html>
