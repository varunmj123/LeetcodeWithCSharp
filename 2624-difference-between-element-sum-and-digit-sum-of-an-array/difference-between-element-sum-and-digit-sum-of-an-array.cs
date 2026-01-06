public class Solution {
    public int DifferenceOfSum(int[] nums) {
        int elementSum = 0;
        int digitSum = 0;
        foreach(var num in nums){
            elementSum += num;


        }
        foreach(var num in nums){
            if(num < 10){
                digitSum += num;
            }
            else{
                int currentNum = num;
                while(currentNum > 0){
                    // 153 % 10 = 3
                    int numberToAdd = currentNum % 10;
                    digitSum += numberToAdd;
                    currentNum/=10;
                }
            }
        }
        return Math.Abs(elementSum - digitSum);

    }
}