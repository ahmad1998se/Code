
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Random;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Server {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {
            int randomNum;
            Random rand = new Random();
            randomNum = rand.nextInt((3050 - 3000) + 1) + 3000;
            System.out.println("The Random Number = "+randomNum);
             ServerSocket Soc = new ServerSocket(randomNum);
        
            Socket c1 = Soc.accept();

            DataOutputStream out1 = new DataOutputStream(c1.getOutputStream());
            DataInputStream in1 = new DataInputStream(c1.getInputStream());

            System.out.println(in1.readUTF());//1 Hello Server. I was able to connect to your open port          

            out1.writeUTF("Good luck client. I am closing the port"); // 1“Good luck client. I am closing the port”.

            System.out.println("I am closing all open sockets and input and output ports");

            out1.close();
            in1.close();
            c1.close();
            Soc.close();

        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
