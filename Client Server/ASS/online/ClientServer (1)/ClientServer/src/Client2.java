
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.Scanner;
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
 * @author Teacher
 */
public class Client2 {

    
    public static void main(String[] args) {

        try {
            Socket client2=new Socket("localhost",2233);
               DataOutputStream out=new DataOutputStream(client2.getOutputStream());
      DataInputStream in=new DataInputStream(client2.getInputStream());

          
              Scanner inp=new Scanner(System.in);
                          System.out.println("Enter Msg");

                    String Line=inp.nextLine();
                    out.writeUTF(Line); 

        } catch (IOException ex) {
            Logger.getLogger(Client2.class.getName()).log(Level.SEVERE, null, ex);
        }
        
    }
    
}
