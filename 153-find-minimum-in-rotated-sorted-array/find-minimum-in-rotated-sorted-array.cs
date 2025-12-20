public class Solution {
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        while(left < right){
            int middle = (left + right)/ 2;
            if(nums[middle] > nums[right]){
                // This means that the smallest is on the right
                left = middle + 1;
            }
            else if(nums[middle] < nums[right]){
                right = middle;
            }
        }
        return nums[left];
    }
}
