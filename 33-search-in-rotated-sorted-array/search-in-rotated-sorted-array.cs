public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;

        // Find pivot (minimum)
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] < nums[right]) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }

        int pivot = left;

        // Decide which half to search
        if (target >= nums[pivot] && target <= nums[nums.Length - 1]) {
            left = pivot;
            right = nums.Length - 1;
        } else {
            left = 0;
            right = pivot - 1;
        }

        // Standard binary search
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] < target) left = mid + 1;
            else right = mid - 1;
        }

        return -1;
    }
}
