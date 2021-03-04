/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Login;

import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author Ahmad
 */
@WebService(serviceName = "WS1")
public class WS1 {

    /**
     * Web service operation
     */
    @WebMethod(operationName = "Authentication")
    public String Authentication(@WebParam(name = "UserName") String UserName, @WebParam(name = "Password") String Password) {
        //TODO write your implementation code here:

        String TrueUserName = "Ahmad2016";
        String TruePassword = "Ahmad2016";
        if (TrueUserName.equals(UserName) && TruePassword.equals(Password)) {
            return "Login successful";
        } else {
            return "Login failed";
        }
    }

    /**
     * This is a sample web service operation
     */
}
