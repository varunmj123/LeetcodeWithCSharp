public class Solution {
    public int LongestOnes(int[] nums, int k) {
        int left = 0;
        int longest = 0;
        int numberOfOnes = 0;
        for(int right = 0; right < nums.Length; right++){
            // Formula is windowSize - numberOf1s > k // If this is not true we can increase left
            if(nums[right] == 1){
                numberOfOnes++;
            }

            if((right - left + 1) - numberOfOnes > k){
                if(nums[left] == 1){
                    numberOfOnes--;
                }
                left++;
            }
            if((right - left + 1) > longest){
                longest = right - left + 1;
            }  
        }
        return longest;
    }
}