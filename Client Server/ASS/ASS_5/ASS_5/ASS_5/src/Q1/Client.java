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
            Socket c1 = new Socket("localhost", 3222);
            DataOutputStream out = new DataOutputStream(c1.getOutputStream());
            DataInputStream in = new DataInputStream(c1.getInputStream());
            boolean flag = true;
            String op;
            double n1, n2;
            Scanner input = new Scanner(System.in);
            do {
                System.out.println(in.readUTF());
                op = input.next();
                out.writeUTF(op);
                
                if (op.equals("+") || op.equals("-") || op.equals("*") || op.equals("/")) {
                    System.out.println(in.readUTF());
                    n1 = input.nextDouble();
                    n2 = input.nextDouble();
                    out.writeDouble(n1);
                    out.writeDouble(n2);
                    System.out.println(in.readDouble());
                    
                } else if ("s".equals(op) || "r".equals(op)) {
                    System.out.println(in.readUTF());
                    n1 = input.nextDouble();
                    out.writeDouble(n1);
                    System.out.println(in.readDouble());
                    
                }else if (op.equals("e")){
                    System.out.println(in.readUTF());
                    break;
                }else{
                    System.out.println(in.readUTF());
                }
            } while (true);

            in.close();
            out.close();
            c1.close();

        } catch (IOException ex) {
            Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}