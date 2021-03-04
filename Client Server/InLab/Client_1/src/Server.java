
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
 * @author Ahmad
 */
public class Server {

    
    public static void main(String[] args) throws IOException {
        try
        {
        ServerSocket server = new ServerSocket(2226);
            Socket C1=server.accept();
            Socket C2=server.accept();
            System.out.println("Clinet 1 and 2  is conenected");
        }
        catch (IOException e )
        {
        Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, e);
        
        }
        
    }
    
}
