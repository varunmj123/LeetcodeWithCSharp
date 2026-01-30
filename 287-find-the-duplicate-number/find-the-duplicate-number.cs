public class Solution {
    public int FindDuplicate(int[] nums) {
        int fast = 0;
        int slow = 0;
        
        while(true){
            slow = nums[slow];
            fast = nums[nums[fast]];
            if(slow == fast){
                break;
            }
        }
        int slowNew = 0; 
        while(true){
            slow = nums[slow];
            slowNew = nums[slowNew];
            if(slow == slowNew){
                return slow;
            }
        }

    }
}
