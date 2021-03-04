
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.util.ArrayList;
import java.util.List;
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
 * @author Moyed
 */
public class player2 {
    public static char[][] GetGameState(DataInputStream serverInput){
        char [][] game = new char[3][3];
        try{
        
        
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                char x = serverInput.readChar();
                game[i][j]= x;
            }
        }
        
        
        }catch (IOException ex) {
           
        }
        return game;
    }
    
    public static void PrintGameState(char[][] game){
        System.out.println("-----------------------------------------");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                System.out.print(game[i][j] == ' '? GetCellNumber(i,j)+"\t":game[i][j]+"\t");
            }
            System.out.println("");
        }
    }
    
    public static int GetCellNumber(int x, int y){
       switch(x){
           case 0 :
               switch(y){
                   case 0:
                       return 1;
                   case 1:
                       return 2;
                   case 2:
                       return 3;
               }
            case 1 :
               switch(y){
                   case 0:
                       return 4;
                   case 1:
                       return 5;
                   case 2:
                       return 6;
               }
            case 2 :
               switch(y){
                   case 0:
                       return 7;
                   case 1:
                       return 8;
                   case 2:
                       return 9;
               }
       }
       
       return -1;
    }
    static boolean other=false;
     public static boolean GameEnded(char[][] game)
    {
        
           
         if ((game[0][0]=='X'&&game[0][1]==game[0][0]&&game[0][1]==game[0][2]) || (game[1][0]=='X'&&game[1][0]==game[1][1]&&game[1][0]==game[1][2])||
            (game[2][0]=='X'&&game[2][0]==game[2][1]&&game[2][1]==game[2][2])||(game[0][0]=='X'&&game[0][0]==game[1][0]&&game[1][0]==game[2][0])||
            (game[0][1]=='X'&&game[0][1]==game[1][1]&&game[1][1]==game[2][1])||
           (game[0][2]=='X'&&game[0][2]==game[1][2]&&game[1][2]==game[2][2])||
          (game[0][0]=='X'&&game[0][0]==game[1][1]&&game[1][1]==game[2][2])||
          (game[0][2]=='X'&&game[0][2]==game[1][1]&&game[1][1]==game[2][0]))
         {
             other=true;
         return true;
         }
             for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (game[i][j]==' ')
                        return false;
                }
            }
       
        
        
        
        
        return true;
    }
 static List<Integer> choices = new ArrayList<>();
     static boolean wins=false;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        try {
            
            Socket server = new Socket("127.0.0.1",3005);
            
            DataInputStream serverInput = new DataInputStream(server.getInputStream());
            DataOutputStream serverOutput = new DataOutputStream(server.getOutputStream());
            
            boolean isGameEnded = false;
            System.out.println("im Player 2 (O Player)");
            while(true){
                //isGameEnded = serverInput.readBoolean();
                char[][] game = GetGameState(serverInput);
            
                PrintGameState(game);
                         if (choices.size()>0){
         if ((choices.contains(1)&&choices.contains(2)&&choices.contains(3))||(choices.contains(4)&&choices.contains(5)&&choices.contains(6))||(choices.contains(7)&&choices.contains(8)&&choices.contains(9))||(choices.contains(1)&&choices.contains(4)&&choices.contains(7))||(choices.contains(2)&&choices.contains(5)&&choices.contains(8))||(choices.contains(3)&&choices.contains(6)&&choices.contains(9))||(choices.contains(1)&&choices.contains(5)&&choices.contains(9))||(choices.contains(3)&&choices.contains(5)&&choices.contains(7)))
         {
            
             System.out.print("player 2 wins :)");
            break;
        
        }}
                if (GameEnded(game)){
                    if (other)System.out.print("player 1 wins");
                    break;
                }
                
                Scanner userInput = new Scanner(System.in);



                System.out.println("Pick a cell");

                int cellNumber = userInput.nextInt();
                 choices.add(cellNumber);
                serverOutput.write(cellNumber);
                
            }
serverInput.close();
serverOutput.close();
server.close();
            

      
            
        } catch (IOException ex) {
            Logger.getLogger(player2.class.getName()).log(Level.SEVERE, null, ex);
        }            
    }
    
}
