import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {

	

	public static void main(String[] args) {
		try {
			char p1 = 'X', p2 = 'O';
			Game game = new Game(p1, p2);
			int cell;
			
			ServerSocket serverSocket = new ServerSocket(1511);
			System.out.println("Please Run the Client 2 Times : First is " + p1 + ", Second is "+ p2);
			Socket clientX = serverSocket.accept();
			DataInputStream inX = new DataInputStream(clientX.getInputStream());
			DataOutputStream outX = new DataOutputStream(clientX.getOutputStream());
			
			Socket clientO = serverSocket.accept();
			DataInputStream inO = new DataInputStream(clientO.getInputStream());
			DataOutputStream outO = new DataOutputStream(clientO.getOutputStream());
			
			outX.writeUTF("Game Started - You Are ( " + p1 + " )\n");
			outO.writeUTF("Game Started - You Are ( " + p2 + " )\n");
			
			outX.writeUTF("ok");
			while(true) {
				
				outX.writeUTF(game.boardState());
				outX.writeUTF("Your turn : Selet a Cell");
				cell = inX.read();
				while(!game.set(Game.PLAYERS.P1,cell)) {
					outX.writeUTF("Invalid Position : Try Again");
					cell = inX.read();
				}
				outX.writeUTF("ok");
				
				if(game.win(Game.PLAYERS.P1))
				{
					outX.writeUTF("** You Win **");
					outO.writeUTF("** You Lose **");
					break;
				}
				else if(game.draw())
				{
					outX.writeUTF("** You Draw** ");
					outO.writeUTF("** You Draw** ");
					break;
				}else {
					outX.writeUTF("ok");
					outO.writeUTF("ok");
				}
				
				outO.writeUTF(game.boardState());
				outO.writeUTF("Your turn : Select a Cell");
				cell = inO.read();
				while(!game.set(Game.PLAYERS.P2,cell)) {
					outO.writeUTF("Invalid Position : Try Again");
					cell = inO.read();
				}
				outO.writeUTF("ok");
				
				if(game.win(Game.PLAYERS.P2))
				{
					outX.writeUTF("** You Lose **");
					outO.writeUTF("** You Win **");
					break;
				}else {
					outX.writeUTF("ok");
					outO.writeUTF("ok");
				}
			}
			
			outX.writeUTF(game.boardState());
			outO.writeUTF(game.boardState());
			
			clientX.close();
			inX.close();
			outX.close();
			
			clientO.close();
			inO.close();
			outO.close();
			
			serverSocket.close();
			
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
