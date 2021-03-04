
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;
//without Thread
/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author user1
 */
public class Server {
   
   
    
    

    public static void main(String[] args) {
       try {
            ServerSocket ServSock =new ServerSocket(2233);
            Socket S=ServSock.accept();
            Socket S2=ServSock.accept();

                    
        DataInputStream in1 = new DataInputStream(S.getInputStream());
           DataOutputStream out1=new DataOutputStream(S.getOutputStream());
               DataInputStream in2 = new DataInputStream(S2.getInputStream());
           DataOutputStream out2=new DataOutputStream(S2.getOutputStream());
           
           System.out.println("C1 said :"+in1.readUTF());           
               System.out.println("C2 said :"+in2.readUTF()); 
       } catch (IOException ex) {
           Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
       }
        
    }

   
    
}
