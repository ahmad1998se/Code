package Q2;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Client {
    
    public static void main(String[] args) {

        try {
                      
            Socket c1 = new Socket("localhost", 3322);            
            DataOutputStream out = new DataOutputStream(c1.getOutputStream());
            DataInputStream in = new DataInputStream(c1.getInputStream());
            Scanner scan = new Scanner(System.in);
          
            while (true) 
            { 
               if(in.readBoolean())
               {
                System.out.println(in.readUTF());   
                System.out.println(in.readUTF());
                out.writeInt(scan.nextInt());               
                out.writeInt(scan.nextInt());}
               else 
                   break;
            }
        
            out.close();
            in.close();
            c1.close();

        } catch (IOException ex) {
           // Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}