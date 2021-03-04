
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
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
public class Server {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {

            ServerSocket Soc = new ServerSocket(2233);
            Socket c1 = Soc.accept();
            Socket c2 = Soc.accept();

            DataOutputStream out1 = new DataOutputStream(c1.getOutputStream());
            DataInputStream in1 = new DataInputStream(c1.getInputStream());

            DataOutputStream out2 = new DataOutputStream(c2.getOutputStream());
            DataInputStream in2 = new DataInputStream(c2.getInputStream());
            out1.writeUTF("Hello");
            out2.writeUTF("Hello");
            out1.close();
            out2.close();
            in1.close();
            in2.close();
            c1.close();
            c2.close();
            Soc.close();

            ServerSocket Ser2 = new ServerSocket(4433);
            Socket c11 = Ser2.accept();

            DataOutputStream out11 = new DataOutputStream(c11.getOutputStream());
            DataInputStream in11 = new DataInputStream(c11.getInputStream());

            System.out.println(in11.readUTF());
            out11.close();
            in11.close();
            c11.close();

        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
