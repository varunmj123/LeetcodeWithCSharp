public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        int[] output = new int[2];
        while(left < right){
            int currentSum = numbers[left] + numbers[right];
            if(currentSum > target){
                right--;
                continue;
            }
            else if(currentSum < target){
                left++;
                continue;
            }
            else{
                output[0] = left + 1;
                output[1] = right + 1;
                return output;
            }
        }
        return output;
    }
}
