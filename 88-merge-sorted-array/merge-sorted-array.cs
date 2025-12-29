public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        // Right counter will start from the back of nums2
        int right = n - 1;
        // Left counter will start from the middle of nums1
        int left = m - 1;
        // i counter will start from the back of nums1
        for (int i = m + n - 1; i >= 0; i--) {
            if (right < 0) break;

            if (left >= 0 && nums1[left] > nums2[right]) {
                nums1[i] = nums1[left];
                left--;
            } else {
                nums1[i] = nums2[right];
                right--;
            }
        }
    }
}
