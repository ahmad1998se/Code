import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.net.Socket;
import java.net.UnknownHostException;
import java.util.Scanner;

public class Client {

	
	public static void main(String[] args) {
		try {
			Scanner input = new Scanner(System.in);
			String msg;
			Socket socket = new Socket("localhost", 1511);
			
			DataInputStream in = new DataInputStream(socket.getInputStream());
			DataOutputStream out = new DataOutputStream(socket.getOutputStream());
			
			System.out.println(in.readUTF());
			
			while(true) {
				msg = in.readUTF();
				if(!msg.toLowerCase().equals("ok"))
				{
					System.out.println(msg);
					break;
				}
				System.out.println(in.readUTF());
				System.out.println(in.readUTF());
				out.write(input.nextInt());
				msg = in.readUTF();
				
				while(!msg.toLowerCase().equals("ok")){
					System.out.println(msg);
					out.write(input.nextInt());
					msg = in.readUTF();
				}
				
				
				msg = in.readUTF();
				if(!msg.toLowerCase().equals("ok"))
				{
					System.out.println(msg);
					break;
				}
			}
			System.out.println(in.readUTF());
			socket.close();
			in.close();
			out.close();
			
		} catch (UnknownHostException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}

	}

}
