package Q2;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Server {

    private static int counter;

    public static void main(String[] args) {
        try {
            ServerSocket serverSocket = new ServerSocket(3000);
            Socket socket = serverSocket.accept();

            DataInputStream in1 = new DataInputStream(socket.getInputStream());
            DataOutputStream out1 = new DataOutputStream(socket.getOutputStream());

            int[][] A = new int[2][2];
            int[][] B = new int[2][2];

            Random random = new Random();

            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    A[i][j] = random.nextInt(100) + 1;
                    B[i][j] = random.nextInt(100) + 1;
                }
            }

            System.out.println("A = ");
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    System.out.print(A[i][j] + "  ");
                }
                System.out.println();
            }

            System.out.println("B = ");
            for (int i = 0; i < 2; i++) {
                for (int j = 0; j < 2; j++) {
                    System.out.print(B[i][j] + "  ");
                }
                System.out.println();
            }

            for (int i = 0; i < 4; i++) {
                String Operation = in1.readUTF();
                String Name = in1.readUTF();

                if (Name.equals("1")) {
                    if (Operation.equals("+")) {
                        out1.writeInt(A[0][0] + B[0][0]);
                        System.out.println("the result of the ADD operation " + (A[0][0] + B[0][0]) + " sent to thread 1");
                    } else if (Operation.equals("-")) {
                        out1.writeInt(A[0][0] - B[0][0]);
                        System.out.println("the result of the SUB operation " + (A[0][0] - B[0][0]) + " sent to thread 1");
                    }
                } else if (Name.equals("2")) {
                    if (Operation.equals("+")) {
                        out1.writeInt(A[0][1] + B[0][1]);
                        System.out.println("the result of the ADD operation " + (A[0][1] + B[0][1]) + " sent to thread 2");
                    } else if (Operation.equals("-")) {
                        out1.writeInt(A[0][1] - B[0][1]);
                        System.out.println("the result of the SUB operation " + (A[0][1] - B[0][1]) + " sent to thread 2");
                    }
                } else if (Name.equals("3")) {
                    if (Operation.equals("+")) {
                        out1.writeInt(A[1][0] + B[1][0]);
                        System.out.println("the result of the ADD operation " + (A[1][0] + B[1][0]) + " sent to thread 3");
                    } else if (Operation.equals("-")) {
                        out1.writeInt(A[1][0] - B[1][0]);
                        System.out.println("the result of the SUB operation " + (A[1][0] - B[1][0]) + " sent to thread 3");
                    }
                } else if (Name.equals("4")) {
                    if (Operation.equals("+")) {
                        out1.writeInt(A[1][1] + B[1][1]);
                        System.out.println("the result of the ADD operation " + (A[1][1] + B[1][1]) + " sent to thread 4");
                    } else if (Operation.equals("-")) {
                        out1.writeInt(A[1][1] - B[1][1]);
                        System.out.println("the result of the SUB operation " + (A[1][1] - B[1][1]) + " sent to thread 4");
                    }
                }
            }
        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
