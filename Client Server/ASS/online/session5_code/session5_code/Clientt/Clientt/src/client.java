
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
public class client {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            
            Socket c1=new Socket("192.168.1.108", 3322);
            
            
            DataInputStream in=new DataInputStream(c1.getInputStream());
            System.out.println(in.readUTF());
            
            
            
            ServerSocket ClientServerSock=new ServerSocket(4422);
            Socket c2=ClientServerSock.accept();
            DataOutputStream out=new DataOutputStream(c2.getOutputStream());
            out.writeUTF("HI");
            
            
        } catch (IOException ex) {
            Logger.getLogger(client.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
