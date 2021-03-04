
import java.io.DataInput;
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Teacher
 */
public class Server {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {
            
            ServerSocket Soc=new ServerSocket(2233);
            Socket c1=Soc.accept();       
            Socket c2=Soc.accept();   
            
            DataInputStream in1 = new DataInputStream(c1.getInputStream());                     
            String Msg1 =in1.readUTF();
            
            
                    DataOutputStream out2 = new DataOutputStream(c2.getOutputStream());
                    out2.writeUTF(Msg1);
                    
                    
                    DataInputStream in2 = new DataInputStream(c2.getInputStream());
                   
                    
                    String msg2 = in2.readUTF();
                    
                    DataOutputStream out1 = new DataOutputStream(c1.getOutputStream());
                    out1.writeUTF(msg2);
                    

           

             } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }
    
    }
    
}
