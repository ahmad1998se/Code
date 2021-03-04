
import java.io.DataInputStream;
import java.io.IOException;
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
public class clent2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            Socket C2=new Socket("192.168.1.108",4422);
            
            DataInputStream in=new DataInputStream(C2.getInputStream());
            
            System.out.println(in.readUTF());
            
        } catch (IOException ex) {
            Logger.getLogger(clent2.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
