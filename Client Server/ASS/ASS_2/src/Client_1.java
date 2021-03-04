
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
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
 * @author Ahmad
 */
public class Client_1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       try {
            int counter = 0;
            String Msg = null;
            Socket client1=new Socket("localhost", 3324);
            DataOutputStream out =new DataOutputStream(client1.getOutputStream());
            DataInputStream in =new DataInputStream(client1.getInputStream());
            Scanner scanner = new Scanner(System.in);
            int number;
            do{
                System.out.print("Enter number Between 1-10 " + (counter+1) + ": ");
                try
                {
                number = Integer.parseInt(scanner.nextLine());
                }
                catch (Exception e)
                {
                    System.out.println("Enter number Between 1-10");
                number = Integer.parseInt(scanner.nextLine());
                }
                
                out.write(number);
                Msg = in.readUTF();
                
                if (Msg.equals("Client1 and client2 and random number are the same.")){
                    counter++;
                    System.out.println(Msg);
                }else if (Msg.equals("you are winner.")){
                    System.out.println(Msg);
                    counter = 5;
                }else if (Msg.equals("you are loser.")){ 
                    System.out.println(Msg);
                    counter = 5;
                }else if(Msg.equals("invalid input"))
                {
                    System.out.println(Msg);
                    counter++;
                }
                else
                {
                    counter++;
                }
            }while(counter != 5);
            in.close();
            out.close();
            client1.close();
        } catch (IOException ex) {
            Logger.getLogger(Client_1.class.getName()).log(Level.SEVERE, null, ex);
        }  
         
    }
    
}
