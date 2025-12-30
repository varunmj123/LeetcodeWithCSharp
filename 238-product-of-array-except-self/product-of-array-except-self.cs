public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // We have to make a postfix and prefix Array
        int[] prefixArr = new int[nums.Length];
        prefixArr[0] = 1;
        int[] postFixArr = new int[nums.Length];
        postFixArr[nums.Length - 1] = 1;

        // Populating prefix array
        for(int i = 1; i < nums.Length; i++){
            prefixArr[i] = prefixArr[i -1] * nums[i -1];
        }
        // Populating postix array
        for(int i = nums.Length - 2; i >= 0; i--){
            postFixArr[i] = postFixArr[i + 1]* nums[i + 1];
        }
        int[] output = new int[nums.Length];
        //Multiplying both
        for(int i = 0; i < nums.Length; i++){
            output[i] = postFixArr[i] * prefixArr[i];
        }

        return output;
    }
}