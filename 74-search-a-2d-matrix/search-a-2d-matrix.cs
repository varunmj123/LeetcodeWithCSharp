public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int numberOfRows = matrix.Length; //3
        int numberOfCols = matrix[0].Length; //4
        int left = 0;
        int right = numberOfRows * numberOfCols -1; 

        while(left <= right){
            int medium = (right + left)/ 2;
            int currentRow = medium / numberOfCols;
            int currentCol = medium % numberOfCols;
            int mediumNumber = matrix[currentRow][currentCol];
            if(mediumNumber == target){
                return true;
            }
            else if(mediumNumber > target){
                right = medium - 1;
            }
            else if(mediumNumber < target){
                left = medium + 1;
            }
        }
        return false;
    }
}
