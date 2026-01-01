public class Solution {
    public int CountDigits(int num) {
        string stringNumber = num.ToString();
        int output = 0;
        for(int i =0; i < stringNumber.Length; i++){
            int currentNumber = int.Parse(stringNumber[i].ToString());
            if(num % currentNumber == 0){
                output++;
            }
        }
        return output;
    }
}