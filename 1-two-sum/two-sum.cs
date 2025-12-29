public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output = new int[2];
        var seenNumber = new Dictionary<int , int>();
        for(int i = 0; i < nums.Length; i++){
            int compliment = target - nums[i];
            if(seenNumber.ContainsKey(compliment)){
                output[0] = i;
                output[1] = seenNumber[compliment];
                return output;
            }
            
            seenNumber[nums[i]] = i;
        }
        return output;
    }
}