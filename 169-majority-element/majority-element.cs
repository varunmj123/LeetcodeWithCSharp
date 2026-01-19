public class Solution {
    public int MajorityElement(int[] nums) {
        int currentMax = 0; 
        int count = 0; 
        foreach(var n in nums){
            if(count == 0){
                currentMax = n;
            }
            if(currentMax == n){
                count++;
            }
            else{
                count--;
            }
        }
        return currentMax;
    }
}