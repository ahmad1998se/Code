/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Q1;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Ahmad
 */
public class Client {

    public static void main(String[] args) {

        try {
            Socket client1 = new Socket("localhost", 2233);
            DataOutputStream out = new DataOutputStream(client1.getOutputStream());
            DataInputStream in = new DataInputStream(client1.getInputStream());

            System.out.println(in.readInt());

            if (in.readBoolean()) {
                out.writeUTF("Happy To Meet You");
                System.out.println(in.readUTF());
            }

            in.close();
            out.close();
            client1.close();
            
        } catch (IOException ex) {
            Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
