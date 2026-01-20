public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Value : Index pairs 
        var freqDict = new Dictionary<int , int>();
        int[] output = new int[2];
        for(int i =0; i < nums.Length; i++){
            int compliment = target - nums[i];
            if(freqDict.ContainsKey(compliment)){
                output[0] = i;
                output[1] = freqDict[compliment];
                return output;
            }
            freqDict[nums[i]] = i;
        }
        return output;
    }
}