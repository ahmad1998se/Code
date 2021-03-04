
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;


public class Server {

    

   
    public static void main(String[] args) {
        try {
            ServerSocket ser=new ServerSocket(2222);
            Socket Cli1=ser.accept();
           // Socket Cli2=ser.accept();
            System.out.println("Enter The message send from server to clinet" );
              Scanner in = new Scanner(System.in);
              String A =in.next();
              

            
            DataInputStream inS= new DataInputStream(Cli1.getInputStream());
            
            DataOutputStream outS=new DataOutputStream(Cli1.getOutputStream());
            outS.writeUTF(A);
            
            System.out.println("The Message from Client \t "+inS.readUTF());
        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
