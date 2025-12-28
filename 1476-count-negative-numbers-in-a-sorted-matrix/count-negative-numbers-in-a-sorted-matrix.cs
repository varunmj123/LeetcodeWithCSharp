public class Solution {
    public int CountNegatives(int[][] grid) {
        int numberOfNegatives = 0;
        for(int i = 0; i < grid.Length; i++){
            int[] currentRow = grid[i];
            for(int j = 0; j < currentRow.Length; j++){
                if(currentRow[j] < 0){
                    numberOfNegatives++;
                }
            }
        }
        return numberOfNegatives;
    }
}