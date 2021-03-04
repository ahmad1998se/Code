
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
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
 * @author Ahmad
 */
public class Client2 {

    
    public static void main(String[] args) {
       
        try {
            Socket Client2=new Socket("localhost",2233);
            DataInputStream in2=new DataInputStream(Client2.getInputStream());
            System.out.println(in2.readUTF());
            
            
            Scanner input = new Scanner(System.in);
            System.out.println("Enter The Msg");
            
            String Line = input.next();
            DataOutputStream out2 = new DataOutputStream(Client2.getOutputStream());
            out2.writeUTF(Line);
            
            
           // DataOutputStream out2 = new DataOutputStream(Client2.getOutputStream());
         //   out2.writeUTF();
          
            
            
        } catch (IOException ex) {
            Logger.getLogger(Client2.class.getName()).log(Level.SEVERE, null, ex);
        }
        
        
        
    }
    
}
