public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int pointer = 0;
        var seenNumber = new Dictionary<int , int>();

        for(int i=0; i < nums.Length; i++){
            if(!seenNumber.ContainsKey(nums[i])){
                nums[pointer] = nums[i];
                pointer++;
            }
            seenNumber[nums[i]] = i;
        }
        return pointer;
    }
}