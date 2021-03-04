package Q2;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Client {

    private static int[][] C = new int[2][2];
    private static int counter;

    public static void main(String[] args) {
        try {
            Socket socket = new Socket("localhost", 3000);

            DataOutputStream out = new DataOutputStream(socket.getOutputStream());
            DataInputStream in = new DataInputStream(socket.getInputStream());

            counter = 0;

            new Thread(new Runnable() {

                @Override
                public void run() {
                    try {
                        DataOutputStream out = new DataOutputStream(socket.getOutputStream());
                        DataInputStream in = new DataInputStream(socket.getInputStream());

                        String Operation;
                        if (new Random().nextInt(2) == 0) {
                            Operation = "+";
                        } else {
                            Operation = "-";
                        }

                        out.writeUTF(Operation);
                        out.writeUTF(Thread.currentThread().getName());

                        if (Operation.equals("+")) {
                            System.out.println("Thread 1 sends a request to ADD element A[0][0] and B[0][0]");
                        } else if (Operation.equals("-")) {
                            System.out.println("Thread 1 sends a request to SUB element A[0][0] and B[0][0]");
                        }

                        C[0][0] = in.readInt();
                        System.out.println("Thread 1 received the value " + C[0][0]);
                        counter++;
                    } catch (IOException ex) {
                        Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
                    }
                }
            }, "1").start();

            new Thread(new Runnable() {

                @Override
                public void run() {
                    try {
                        DataOutputStream out = new DataOutputStream(socket.getOutputStream());
                        DataInputStream in = new DataInputStream(socket.getInputStream());

                        String Operation;
                        if (new Random().nextInt(2) == 0) {
                            Operation = "+";
                        } else {
                            Operation = "-";
                        }

                        out.writeUTF(Operation);
                        out.writeUTF(Thread.currentThread().getName());

                        if (Operation.equals("+")) {
                            System.out.println("Thread 2 sends a request to ADD element A[0][1] and B[0][1]");
                        } else if (Operation.equals("-")) {
                            System.out.println("Thread 2 sends a request to SUB element A[0][1] and B[0][1]");
                        }

                        C[0][1] = in.readInt();
                        System.out.println("Thread 2 received the value " + C[0][1]);
                        counter++;
                    } catch (IOException ex) {
                        Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
                    }
                }
            }, "2").start();

            new Thread(new Runnable() {

                @Override
                public void run() {
                    try {
                        DataOutputStream out = new DataOutputStream(socket.getOutputStream());
                        DataInputStream in = new DataInputStream(socket.getInputStream());

                        String Operation;
                        if (new Random().nextInt(2) == 0) {
                            Operation = "+";
                        } else {
                            Operation = "-";
                        }

                        out.writeUTF(Operation);
                        out.writeUTF(Thread.currentThread().getName());

                        if (Operation.equals("+")) {
                            System.out.println("Thread 3 sends a request to ADD element A[1][0] and B[1][0]");
                        } else if (Operation.equals("-")) {
                            System.out.println("Thread 3 sends a request to SUB element A[1][0] and B[1][0]");
                        }

                        C[1][0] = in.readInt();
                        System.out.println("Thread 3 received the value " + C[1][0]);
                        counter++;
                    } catch (IOException ex) {
                        Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
                    }
                }
            }, "3").start();

            new Thread(new Runnable() {

                @Override
                public void run() {
                    try {
                        DataOutputStream out = new DataOutputStream(socket.getOutputStream());
                        DataInputStream in = new DataInputStream(socket.getInputStream());

                        String Operation;
                        if (new Random().nextInt(2) == 0) {
                            Operation = "+";
                        } else {
                            Operation = "-";
                        }

                        out.writeUTF(Operation);
                        out.writeUTF(Thread.currentThread().getName());

                        if (Operation.equals("+")) {
                            System.out.println("Thread 4 sends a request to ADD element A[1][1] and B[1][1]");
                        } else if (Operation.equals("-")) {
                            System.out.println("Thread 4 sends a request to SUB element A[1][1] and B[1][1]");
                        }

                        C[1][1] = in.readInt();
                        System.out.println("Thread 4 received the value " + C[1][1]);
                        counter++;
                    } catch (IOException ex) {
                        Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
                    }
                }
            }, "4").start();

            while (true) {
                if (counter == 4) {
                    System.out.println("C = ");
                    for (int i = 0; i < 2; i++) {
                        for (int j = 0; j < 2; j++) {
                            System.out.print(C[i][j] + "  ");
                        }
                        System.out.println();
                    }
                    break;
                }
            }

        } catch (IOException ex) {
            Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
