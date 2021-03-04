
import java.io.DataInputStream;
import java.io.DataOutputStream;
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
public class client3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {
            Socket cli = new Socket("localhost", 4433);
            DataInputStream in = new DataInputStream(cli.getInputStream());
            DataOutputStream out = new DataOutputStream(cli.getOutputStream());

            out.writeUTF("hello");
            in.close();
            out.close();
            cli.close();
        } catch (IOException ex) {
            Logger.getLogger(client3.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
