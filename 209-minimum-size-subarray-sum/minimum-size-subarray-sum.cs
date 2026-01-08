public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        // Keep track of minimum array when sum > = target
        // If sum is met move left 
        int left = 0;
        int shortest = int.MaxValue;
        int totalSum = 0;
        for(int right = 0; right < nums.Length; right++){
            totalSum += nums[right];
            while(totalSum >= target){
                if((right - left + 1) < shortest){
                    shortest = right - left + 1; 
                }
                totalSum -= nums[left];
                left++;
            }

        }
        if(shortest == int.MaxValue){
            return 0;
        }
        return shortest;
    }
}