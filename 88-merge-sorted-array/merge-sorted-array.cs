public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int left = m -1; 
        int right = n -1;
        //int pointer = m + n -1 ;
        
        for(int pointer = m + n -1; pointer >= 0; pointer--){
            if(right < 0){
                break;
            }
            if (left >= 0 && nums1[left] > nums2[right]) {
                nums1[pointer] = nums1[left];
                left--;
            } else {
                nums1[pointer] = nums2[right];
                right--;
            }
        }
    }
}