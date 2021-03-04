
import java.io.DataInputStream;
import java.io.DataOutput;
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
 * @author Teacher
 */
public class Client {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        try {
            Socket cli=new Socket("localhost", 2233);
           
      DataOutputStream out=new DataOutputStream(cli.getOutputStream());
      DataInputStream in=new DataInputStream(cli.getInputStream());
      Scanner inp=new Scanner(System.in);
            System.out.println("Enter Msg");
      String Line=inp.nextLine();
      
        out.writeUTF(Line);
        
        } catch (IOException ex) {
            Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
