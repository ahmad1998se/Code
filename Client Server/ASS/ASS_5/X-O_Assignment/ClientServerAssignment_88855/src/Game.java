
public class Game {
	public static enum PLAYERS {P1, P2};
	private char[][] gameBoard;
	private int round;
	char p1, p2;
	
	public Game(char p1, char p2) {
		gameBoard = new char [3][3];
		this.p1 = p1;
		this.p2 = p2;
		this.reset();
	}
	
	
	public String boardState() {
		StringBuilder state = new StringBuilder();
		state.append("/---|---|---\\");
		state.append("\n| " + gameBoard[0][0] + " | " + gameBoard[0][1] + " | " + gameBoard[0][2] + " |");
		state.append("\n|-----------|");
		state.append("\n| " + gameBoard[1][0] + " | " + gameBoard[1][1] + " | " + gameBoard[1][2] + " |");
		state.append("\n|-----------|");
		state.append("\n| " + gameBoard[2][0] + " | " + gameBoard[2][1] + " | " + gameBoard[2][2] + " |");
		state.append("\n\\---|---|---/");
		return state.toString();
	}
	
	public void reset() {
		int counter = 1;
		for (int i = 0; i<3; i++)
			for (int j = 0; j<3; j++) 
				gameBoard[i][j] = (char)(counter++ +'0');
		round = 0;
	}
	
	public boolean set (PLAYERS p , int i , int j) {
		if (gameBoard[i][j] == p1 || gameBoard[i][j] == p2)
			return false;
		
		char letter;
		if(p == PLAYERS.P1)
			letter = p1;
		else
			letter = p2;
		gameBoard[i][j] = letter;
		round++;
		return true;
				
	}
	
	public boolean set (PLAYERS p , int cell) {
		if(cell < 1 || cell > 9)
			return false;
		
		int i = (cell-1)/3;
		
		int j = (cell%3) -1;
		if(j == -1)
			j = 2;
		return set(p,i , j);
	}
	
	public boolean win(PLAYERS p) {
		if(round >= 5) {
			char letter;
			if(p == PLAYERS.P1)
				letter = p1;
			else
				letter = p2;
			
			//check rows
			for (int i = 0; i<3; i++) 
				if(gameBoard[i][0] == letter && gameBoard[i][1] == letter && gameBoard[i][2] == letter)
					return true;
			//check columns
			for (int i = 0; i<3; i++) 
				if(gameBoard[0][i] == letter && gameBoard[1][i] == letter && gameBoard[2][i] == letter)
					return true;
			//check diagonals
			if(gameBoard[1][1] == letter && gameBoard[0][0] == letter && gameBoard[2][2] == letter)
				return true;
			
			if(gameBoard[1][1] == letter && gameBoard[0][2] == letter && gameBoard[2][0] == letter)
				return true;
		}
		return false;
			
	}
	
	public boolean draw() {
		if(round < 9)
			return false;
		return win(PLAYERS.P1);
			
	}
}
