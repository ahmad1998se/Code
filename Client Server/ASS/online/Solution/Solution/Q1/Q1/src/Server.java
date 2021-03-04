/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package server;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
//import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;


 
public class Server {

   
     
    public static void main(String[] args) {
        try {
           
            ServerSocket soket=new ServerSocket(3005);
            
            int result = 0; 
            
            Socket c1=soket.accept();
            
            DataInputStream in = new DataInputStream(c1.getInputStream()); 
            
            DataOutputStream out = new DataOutputStream(c1.getOutputStream()); 
            
            boolean running =true;
            while (running){
            int numbers=in.read();
             
            if (numbers==1)
            {
               
                
             int num1=in.read();
             
             int num2=in.read();
             
            String operation = in.readUTF();
            
            if (operation.equalsIgnoreCase("+")){
                  
            result = num1 + num2;
           
            }
            else if (operation.equalsIgnoreCase("-")){
                result = num1 - num2;}
            
              else if (operation.equalsIgnoreCase("*")){
                result = num1 * num2;}
              
                else if (operation.equalsIgnoreCase("/")){
                result = num1 / num2;
                }

            
            out.write(result); 
            
            }
            else if (numbers==2)
            {
                
             int num1=in.read();
             
            String operation = in.readUTF();
            
             if (operation.equalsIgnoreCase("sqr")){
            result = num1*num1 ;}
             
             else if ( operation.equalsIgnoreCase("sqrroot")){
                   result=(int)Math.sqrt(num1);}
            
            out.write(result); 
            
            }
            
           running=in.readBoolean();
            }
        in.close();out.close();c1.close();soket.close();
            }
        
                   
       catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }
      
    }
}

    

