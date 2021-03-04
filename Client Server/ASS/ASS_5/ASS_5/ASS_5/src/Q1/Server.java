/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Q1;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Server {

    public static double Sum(double a, double b) {
        return (a + b);
    }

    public static double Sub(double a, double b) {
        return (a - b);
    }

    public static double Mul(double a, double b) {
        return (a * b);
    }

    public static double Div(double a, double b) {
        return (a / b);
    }

    public static double Square(double a) {
        return (Math.pow(a, 2));
    }

    public static double SquareRoot(double a) {
        return (Math.sqrt(a));
    }

    public static void main(String[] args) {

        try {
            ServerSocket serverSock = new ServerSocket(3222);
            Socket c1 = serverSock.accept();
            DataOutputStream out = new DataOutputStream(c1.getOutputStream());
            DataInputStream in = new DataInputStream(c1.getInputStream());

            boolean flag = true;
            double n1, n2;

            while (flag && !c1.isClosed()) {
                out.writeUTF("Please Enter The Opreation You Want \n (+)=>sum (-)=>Sub (*)=>Mul (/)=>Div (s)=>sqr (r)=>sqrt \n (e)=>exit ");
                
                switch (in.readUTF()) {
                    case "+":

                        out.writeUTF("Please Enter Two value To Sum ");
                        n1 = in.readDouble();
                        n2 = in.readDouble();
                        out.writeDouble(Sum(n1, n2));

                        break;
                    case "-":

                        out.writeUTF("Please Enter Two value To Sub ");
                        n1 = in.readDouble();
                        n2 = in.readDouble();
                        out.writeDouble(Sub(n1, n2));

                        break;
                    case "*":

                        out.writeUTF("Please Enter Two value To Mul ");
                        n1 = in.readDouble();
                        n2 = in.readDouble();
                         out.writeDouble(Mul(n1, n2));
                        break;
                    case "/":

                        out.writeUTF("Please Enter Two value To Div ");
                        n1 = in.readDouble();
                        n2 = in.readDouble();
                        out.writeDouble(Div(n1, n2));

                        break;
                    case "s":

                        out.writeUTF("Please Enter Two value To square ");
                        n1 = in.readDouble();                        
                        out.writeDouble(Square(n1));

                        break;
                    case "r":

                        out.writeUTF("Please Enter Two value To square root");
                        n1 = in.readDouble();                        
                        out.writeDouble( SquareRoot(n1) );

                        break;
                    case "e":
                        out.writeUTF("Good Bye");
                        flag = false;

                        break;

                    default:
                        out.writeUTF("Please Enter The write character  ");

                }

            }
            out.close();          
           in.close();
           c1.close();          
           serverSock.close();

        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
