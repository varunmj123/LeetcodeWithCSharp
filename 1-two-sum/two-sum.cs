public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seenNumber = new Dictionary<int , int>();
        for(int i = 0; i < nums.Length; i++){
            int compliment = target - nums[i];
            if(seenNumber.ContainsKey(compliment)){
                int[] output = {seenNumber[compliment], i};
                return output;
            }
            else{
                seenNumber[nums[i]] = i;
            }
        }
        return null;

    }
}
