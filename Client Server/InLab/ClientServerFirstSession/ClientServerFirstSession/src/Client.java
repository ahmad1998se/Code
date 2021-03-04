
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
            Socket client=new Socket("localhost", 2222);
            DataOutputStream outc=new DataOutputStream(client.getOutputStream());//to know the obj of client
            
            DataInputStream inS =new DataInputStream(client.getInputStream());
             System.out.println("Enter The message send from Client to Server" );
              Scanner in = new Scanner(System.in);
              String A =in.next();

            outc.writeUTF(A);
            System.out.println("Hello This message from Server "+inS.readUTF());
        } catch (IOException ex) {
            Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }
        
}
}
