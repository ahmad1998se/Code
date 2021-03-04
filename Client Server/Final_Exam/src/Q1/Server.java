/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Q1;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author Ahmad
 */
public class Server {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {

        try {
            int same = 0;

            Random rand = new Random();
            int[] r = new int[4];
            int[] s = new int[]{0, 0, 0, 0};
            ServerSocket Soc = new ServerSocket(2233);
            Socket c1 = Soc.accept();
            Socket c2 = Soc.accept();
            Socket c3 = Soc.accept();
            Socket c4 = Soc.accept();

            DataOutputStream out1 = new DataOutputStream(c1.getOutputStream());
            DataInputStream in1 = new DataInputStream(c1.getInputStream());

            DataOutputStream out2 = new DataOutputStream(c2.getOutputStream());
            DataInputStream in2 = new DataInputStream(c2.getInputStream());

            DataOutputStream out3 = new DataOutputStream(c3.getOutputStream());
            DataInputStream in3 = new DataInputStream(c3.getInputStream());

            DataOutputStream out4 = new DataOutputStream(c4.getOutputStream());
            DataInputStream in4 = new DataInputStream(c4.getInputStream());
            boolean flag = true;

            while (flag) {

                for (int i = 0; i < 4; i++) {
                    r[i] = rand.nextInt((5 - 1) + 1) + 1;

                }
                for (int i = 0; i < 4; i++) {
                    System.out.println("C" + i + " =" + r[i]);
                }
                out1.writeInt(r[0]);
                out2.writeInt(r[1]);
                out3.writeInt(r[2]);
                out4.writeInt(r[3]);

                for (int i = 0; i < 4; i++) {
                    for (int j = 0; j < 4; j++) {
                        if (i == j) {
                            continue;
                        }
                        if (r[i] == r[j]) {
                            same = r[i];
                            flag = false;
                        }
                    }
                }
                System.out.println("The Same is " + same);
            }

            if (r[0] != same) {
                out1.writeBoolean(false);
                in1.close();
                out1.close();
            } else {
                out1.writeBoolean(true);
                out1.writeUTF("Happy To Meet You ");
            }
            if (r[1] != same) {
                out2.writeBoolean(false);
                in2.close();
                out2.close();
            } else {
                out2.writeBoolean(true);
                out2.writeUTF("Happy To Meet You ");
            }
            if (r[2] != same) {
                out3.writeBoolean(false);
                in3.close();
                out3.close();
            } else {
                out3.writeBoolean(true);
                out3.writeUTF("Happy To Meet You ");
            }
            if (r[3] != same) {
                out4.writeBoolean(false);
                in4.close();
                out4.close();
            } else {
                out4.writeBoolean(true);
                out4.writeUTF("Happy To Meet You");
            }

        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
