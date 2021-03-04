
import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.logging.Level;
import java.util.logging.Logger;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

 
class Coordinates{
    public int X;
    public int Y;
    
    public Coordinates(int x, int y){
        X=x;
        Y=y;
    }
    
    public boolean isValid(){
        if (X == -1 || Y == -1)
            return false;
        return true;
    }
}    
 
public class Servergame {
    
      public static void PrintGameState(char[][] game){
          System.out.println("-----------------------------------------");
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                System.out.print(game[i][j] == ' '? "_\t":game[i][j]+"\t");
            }
            System.out.println("");
        }
    }
    public static String msg="";
    public static boolean GameEnded(char[][] game)
    {
        int [][] lines = {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6},
    };
        
        for (int i = 0; i < lines.length; i++) {
            int a = lines[i][0]+1;
            int b = lines[i][1]+1;
            int c = lines[i][2]+1;
            
            Coordinates aCoordinates = GetCellCoordinates(a);
            Coordinates bCoordinates = GetCellCoordinates(b);
            Coordinates cCoordinates = GetCellCoordinates(c);
            
            if (aCoordinates.isValid() && bCoordinates.isValid() && cCoordinates.isValid()){
            if (game[aCoordinates.X][aCoordinates.Y] != ' ' &&
                    game[aCoordinates.X][aCoordinates.Y] == game[bCoordinates.X][bCoordinates.Y] &&
                    game[aCoordinates.X][aCoordinates.Y] == game[cCoordinates.X][cCoordinates.Y]) {
                msg = "Winner is :"+(game[aCoordinates.X][aCoordinates.Y] == 'X'? " Player1":" Player2");
                System.out.println(msg);
                return true;
            }
            }

        }
        
        for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    if (game[i][j]==' ')
                        return false;
                }
            }
        
        return true;
    }
    public static char[][] ChangeGameState(Coordinates cell, char[][] game, boolean player1Turn){   
        game[cell.X][cell.Y] = player1Turn?'X':'O';
        return game; 
    }
    
     public static Coordinates GetCellCoordinates(int x){
         
       switch(x){
           case 1 :
               return new Coordinates(0,0);
                case 2 :
               return new Coordinates(0,1);
                case 3 :
               return new Coordinates(0,2);
                case 4 :
               return new Coordinates(1,0);
                case 5 :
               return new Coordinates(1,1);
                case 6 :
               return new Coordinates(1,2);
                case 7 :
               return new Coordinates(2,0);
                case 8 :
               return new Coordinates(2,1);
                case 9 :
               return new Coordinates(2,2);
       }
       return new Coordinates(-1,-1);
    }
    
    public static void SendGameState(char[][] game, DataOutputStream output){
       try{
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                   output.writeChar(game[i][j]);
                }
                
            }
           
        
       }catch (IOException ex) {
            Logger.getLogger(Servergame.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
    
    
    public static void main(String[] args) {
           
        try {
            ServerSocket server = new ServerSocket(3005);
            
            Socket player1 = server.accept();
            System.out.println("Player 1 is connected and he's X player");
            Socket player2 = server.accept();
            System.out.println("Player 2 is connected and he's O player");
            
            DataInputStream player1Input = new DataInputStream(player1.getInputStream());
            DataInputStream player2Input = new DataInputStream(player2.getInputStream());
            
            DataOutputStream player1Output = new DataOutputStream(player1.getOutputStream());
            DataOutputStream player2Output = new DataOutputStream(player2.getOutputStream());
            
            char [][] game = new char[3][3];
            
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    game[i][j]=' ';
                }
            }
            
            boolean player1Turn=true;
            
            while (!GameEnded(game)){

                if (player1Turn){
                   
                    SendGameState(game,player1Output);
                    
                    int cellNumber = player1Input.read();
                    
                    Coordinates index  = GetCellCoordinates(cellNumber);
                    game = ChangeGameState(index,game,player1Turn);
                    PrintGameState(game);
      
                }else{
                   
                     SendGameState(game,player2Output);
                    
                    int cellNumber = player2Input.read();
                    
                    Coordinates index  = GetCellCoordinates(cellNumber);
                    game = ChangeGameState(index,game,player1Turn);
                    PrintGameState(game);  
                    
                }
                
                player1Turn = !player1Turn;
               
            }
            
            SendGameState(game,player1Output);
            SendGameState(game,player2Output);
            player1Output.writeUTF(msg);
            player2Output.writeUTF(msg);
player1Input.close();
player2Input.close();
player1Output.close();
player2Output.close();
player1.close();
player2.close();
server.close();

         
        } catch (IOException ex) {
            Logger.getLogger(Servergame.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    
}
