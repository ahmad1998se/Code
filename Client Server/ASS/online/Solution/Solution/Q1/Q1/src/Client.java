
package client;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Scanner;
import java.util.logging.Level;
import java.util.logging.Logger;


public class Client {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
         try {
             Scanner input = new Scanner(System.in);
             
            Socket cli=new Socket("localhost",3005);
            
            DataInputStream in = new DataInputStream(cli.getInputStream()); 
            
            DataOutputStream out = new DataOutputStream(cli.getOutputStream()); 
            
           boolean running=true; 
            
            while (running) 
        { 
              System.out.println("choose 1 for + - * / 2 for sqr sqrroot"); 
              
              int numbers=input.nextInt();
                
              out.write(numbers);
              
            if (numbers==1){
            System.out.println("operand1 :"); 
            
            int num1=input.nextInt();
            
            out.write(num1);
            
            System.out.println("operand2 :"); 
            
            int num2=input.nextInt();
            
            out.write(num2); 
            
            System.out.println("operation :"); 
            
            String op=input.next();
            
            out.writeUTF(op);
            
            int resualt = in.read(); 
            
            System.out.println("Answer=" + resualt);
            
          
            }
            else{
             System.out.println("operand1 :"); 
            
            int num1=input.nextInt();
            
            out.write(num1);
            
            System.out.println("operation :"); 
            
            String op=input.next();
            
            out.writeUTF(op);
            
            int resualt = in.read(); 
            
            System.out.println("Answer=" + resualt);
            
            }
              System.out.println("choose 1 for keep on 2 to stop ");
            
             int keeprun=input.nextInt();
             if (keeprun ==2)
                 running=false;
                 out.writeBoolean(running);
          
           // break;
        }
            in.close();out.close();cli.close();
        } catch (IOException ex) {
            Logger.getLogger(Client.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
