public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int currentPointer = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[currentPointer] = nums[i];
                currentPointer++;
            }
        }
        return currentPointer;
    }
}