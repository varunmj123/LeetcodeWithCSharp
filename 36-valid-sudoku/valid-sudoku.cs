public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // From here we need to call the threee methods 
        // To check for valid rows, we need to feed every row
        // [y][x] y = rows x = col
        for(int i = 0; i < board.Length; i++){
            if(isValidRow(board, i) == false){
                return false;
            }
            
        }
        //Giving board[0] means we are assuming the Length of each row is the same (true in this case but not dynamic)
        for(int i = 0; i < board[0].Length; i++ ){
            if(isValidCol(board, i) == false){
                return false;
            }
        }

        for(int row = 0; row < board.Length; row += 3){
            for(int col = 0; col < board[0].Length; col += 3){
                if(isValidSquare(board, row, col) == false){
                    return false;
                }
            }
            
        }
        return true;

        

    }

    public bool isValidRow(char[][] board, int currentRowNumber){
        
        var seenNumbers = new Dictionary<int, int>();
        // Need to iterate over this given row
        for(int i = 0; i < board[currentRowNumber].Length; i++){
            char currentChar = board[currentRowNumber][i];
            //Skip the empty cells
            if(currentChar == '.'){
                continue;
            }
            //Convert char into int:
            int currentNumber = currentChar - '0';
            // check of valid numbers:
            if(currentNumber > 9 || currentNumber < 1){
                return false;
            }
            // check of repeating numbers
            if(seenNumbers.ContainsKey(currentNumber)){
                return false;
            }
            seenNumbers[currentNumber] = i;
        }
        return true;
    }
    public bool isValidCol(char[][] board, int currentCol){
        var seenNumbers = new Dictionary<int, int>();
        // Iterate over this current col
        for(int i = 0; i < board.Length ; i++){
            char currentChar = board[i][currentCol];
            //Skip empty cells
            if(currentChar == '.'){
                continue;
            }
            //Convert char into int:
            int currentNumber = currentChar - '0';
            // check of valid numbers:
            if(currentNumber > 9 || currentNumber < 1){
                return false;
            }
            // check of repeating numbers
            if(seenNumbers.ContainsKey(currentNumber)){
                return false;
            }
            seenNumbers[currentNumber] = i;

        }
        return true;
    }
    public bool isValidSquare(char[][] board, int startRow, int startCol){
        var seenNumbers = new Dictionary<int, int>();
        // Iterate over the square
        for(int row = startRow; row < startRow + 3; row++ ){
            for(int col = startCol; col < startCol + 3; col++){
                char currentChar = board[row][col];
                if (currentChar == '.') continue;

                int currentNumber = currentChar - '0';

                if (currentNumber < 1 || currentNumber > 9) return false;

                if (seenNumbers.ContainsKey(currentNumber)) return false;

                seenNumbers[currentNumber] = row;

            }
        }
        return true;

    }
}
