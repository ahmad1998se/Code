
import java.io.DataInputStream;
import java.io.DataOutput;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ConnectException;
import java.net.Socket;

import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Client {

    public static void main(String[] args) {
        System.out.println(" Plsease Enter Number  ");
        Scanner input = new Scanner(System.in);
        int port = input.nextInt();
        int counter = 0;
        Socket cli = null;

        while (true) {
            try {
                counter++;
                cli = new Socket("localhost", port);
            } catch (IOException ex) {
                System.out.println(" Plsease Enter Number  ");
                port = input.nextInt();
                continue;
            }
            break;
        }
        DataOutputStream out;
        try {

            out = new DataOutputStream(cli.getOutputStream());
            DataInputStream in = new DataInputStream(cli.getInputStream());
         
            out.writeUTF("Hello Server. I was able to connect to your open port");

            System.out.println(in.readUTF());//“Good luck client. I am closing the port”.
            System.out.println(port + " is the port number found by the client");
            System.out.println("the number of trials " + counter);

            in.close();
            out.close();
            cli.close();
        } catch (IOException ex) {
            Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
