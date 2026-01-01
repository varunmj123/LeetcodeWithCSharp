public class Solution {
    public int AddDigits(int num) {
        string numberAsString = num.ToString();
        while(numberAsString.Length > 1){
            int totalSum = 0;
            for(int i =0; i < numberAsString.Length; i++){
                string currentNumber = numberAsString[i].ToString();
                totalSum += int.Parse(currentNumber);
            }
            numberAsString = totalSum.ToString();
        }
        return int.Parse(numberAsString);
    }
}