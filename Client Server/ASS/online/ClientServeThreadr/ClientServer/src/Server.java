
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author user1
 */
public class Server implements Runnable{
static ServerSocket ServSock;
static  Socket S;

    public Server() throws IOException {
                S=ServSock.accept();
    }

    public static void main(String[] args) {
       try {
            ServSock =new ServerSocket(2233);
       Thread T1=new Thread(new Server());
       T1.start();
       
           Thread T2=new Thread(new Server());
       T2.start();  
       
       
       } catch (IOException ex) {
           Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
       }
        
    }

    @Override
    public void run() {
        
    try {
        
        
        DataInputStream in1 = new DataInputStream(S.getInputStream());
        DataOutputStream out1=new DataOutputStream(S.getOutputStream());
        
        System.out.println("Client said :"+in1.readUTF());    
    } catch (IOException ex) {
        Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
    }
    }

   
    
}
