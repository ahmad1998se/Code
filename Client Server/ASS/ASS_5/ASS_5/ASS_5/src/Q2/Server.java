package Q2;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Server {

    public static int row, col;
    public static char[][] x_o = new char[3][3];
    public static char turn = 'X';
    public static String a = "";

    public static boolean flag = true;

    public static void play(DataOutputStream out1, DataInputStream in1, DataOutputStream out2, DataInputStream in2) {
        board();
        while (flag) {
            try {
                if (turn == 'X') {
                    out1.writeBoolean(flag);
                    out1.writeUTF("Enter Row And Column in range 3x3");
                    out1.writeUTF(write());

                    row = in1.readInt() - 1;
                    col = in1.readInt() - 1;
                    if (row > 2 || col > 2) {
                        System.out.println("For handle wrong value");
                        row = 1;
                        col = 1;
                    }
                } else {
                    out2.writeBoolean(flag);
                    out2.writeUTF("Enter Row And Column in range 3x3");
                    out2.writeUTF(write());
                    row = in2.readInt() - 1;
                    col = in2.readInt() - 1;
                    if (row > 2 || col > 2) {
                        System.out.println("For handle wrong value  ");
                        row = 1;
                        col = 1;
                    }

                }

                if (x_o[row][col] == '_') {
                    x_o[row][col] = turn;
                } else {
                    System.out.println("Please Enter Another Place");
                    continue;
                }

                if (stop(row, col)) {
                    flag = false;
                    if (turn == 'X') {
                        System.out.println("Declares Clinet 1 is winner");
                    } else {
                        System.out.println("Declares Clinet 2 is winner");
                    }
                }

                board();

                if (turn == 'X') {
                    turn = 'O';
                } else {
                    turn = 'X';
                }

            } catch (IOException ex) {
                Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }

    public static void board() {
        for (int i = 0; i < 3; i++) {
            System.out.println("");
            for (int j = 0; j < 3; j++) {
                if (j == 0) {
                    System.out.print("| ");
                }
                System.out.print(x_o[i][j] + " | ");
            }
        }
        System.out.println();
    }

    public static String write() {
        a = "";
        for (int i = 0; i < 3; i++) {
            //System.out.println("");
            a += "\n";
            for (int j = 0; j < 3; j++) {
                if (j == 0) {
                    // System.out.print("| ");
                    a += "| ";
                }
                // System.out.print(x_o[i][j] + " | ");
                a += x_o[i][j] + " | ";
            }
        }
        // System.out.println();
        a += "\n";

        return a;
    }

    public static boolean stop(int row, int col) {
        if (x_o[0][col] == x_o[1][col] && x_o[0][col] == x_o[2][col]) {
            return true;
        }

        if (x_o[row][0] == x_o[row][1] && x_o[row][0] == x_o[row][2]) {
            return true;
        }

        if (x_o[0][0] == x_o[1][1] && x_o[0][0] == x_o[2][2] && x_o[1][1] != '_') {
            return true;
        }

        if (x_o[0][2] == x_o[1][1] && x_o[0][2] == x_o[2][0] && x_o[1][1] != '_') {
            return true;
        }

        return false;
    }

    public static void main(String[] args) {

        try {
            ServerSocket serverSock = new ServerSocket(3322);
            Socket c1 = serverSock.accept();
            Socket c2 = serverSock.accept();
            DataOutputStream out1 = new DataOutputStream(c1.getOutputStream());
            DataInputStream in1 = new DataInputStream(c1.getInputStream());
            DataOutputStream out2 = new DataOutputStream(c2.getOutputStream());
            DataInputStream in2 = new DataInputStream(c2.getInputStream());

            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    x_o[i][j] = '_';

                }
            }
            play(out1, in1, out2, in2);
            out1.close();
            out2.close();
            in1.close();
            in2.close();
            c1.close();
            c2.close();
            serverSock.close();

        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        }

    }

}
