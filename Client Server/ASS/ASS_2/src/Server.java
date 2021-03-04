
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Server {

    
    public static void main(String[] args) {
        
        
         try {
            ServerSocket ser = new ServerSocket(3324);
            Socket c1=ser.accept();
            Socket c2=ser.accept();
            Random rand = new Random(); 
            int r=rand.nextInt((10 - 1) + 1) + 1;
            //Client 1 input and output
            DataInputStream inp1= new DataInputStream(c1.getInputStream());
            DataInputStream inp2 = new DataInputStream(c2.getInputStream());
                       
            //Client 2 input and output
            DataOutputStream out1 = new DataOutputStream(c1.getOutputStream());
            DataOutputStream out2 = new DataOutputStream(c2.getOutputStream());
                    
           int Msg1 = -1,Msg2 = -1;
           int counter=0;
           
           System.out.println("Server is work");
           
           while(counter != 5){
                Msg1 = inp1.read();
               Msg2 = inp2.read();
               
               if ( Msg1>0 && Msg1<11 && Msg1>0 && Msg1<11 ){
                   if (Msg1 == Msg2 && Msg1 == r){
                       r = rand.nextInt((10 - 1) + 1) + 1;
                       System.out.println("Random number="+r+", Client1="+Msg1+", Clent2="+Msg2+", Gess number="+(counter+1));
                       out1.writeUTF("Client1 and client2 and random number are the same.");
                       out2.writeUTF("Client1 and client2 and random number are the same.");
                       //out1.write(counter);
                       //out2.write(counter);
                       counter++;
                   }
                   else if (Msg1 == r){
                       System.out.println("Random number="+r+", Client1="+Msg1+", Clent2="+Msg2+", Gess number="+(counter+1));
                       System.out.println("Client1 is winner.");
                       counter = 5;
                       out1.writeUTF("you are winner.");
                       out2.writeUTF("you are loser.");
                       break;
                   }else if (Msg2 == r){
                       System.out.println("Random number="+r+", Client1="+Msg1+", Clent2="+Msg2+", Gess number="+(counter+1));
                       System.out.println("Client1 is winner.");
                       counter = 5;
                       out1.writeUTF("you are loser.");
                       out2.writeUTF("you are winner.");
                       break;
                   }else{
                       System.out.println("Random number="+r+", Client1="+Msg1+", Clent2="+Msg2+", Gess number="+(counter+1));
                       out1.writeUTF("Try again.");
                       out2.writeUTF("Try again.");
                       counter++;
                   }
               }
               
              else{
                       out1.writeUTF("invalid input");
                       out2.writeUTF("invalid input");
                       counter++;
               }
           }
           
           out1.close();
           out2.close();
           inp1.close();
           inp2.close();
           c1.close();
           c2.close();
           ser.close();
           
           
           
        } catch (IOException ex) {
            Logger.getLogger(Server.class.getName()).log(Level.SEVERE, null, ex);
        } 
        
        
        
    }

    
    
}
