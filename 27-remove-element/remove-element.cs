public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != val) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}


// public class Solution {
//     public int RemoveElement(int[] nums, int val) {
//         for(int i = 0; i < nums.Length; i++){
//             if(nums[i] == val){
//                 // Assuming this question will only have positive numbers
//                 nums[i] = -nums[i];
//             }
//         }
//         //2, 3,2,2,3, 2 will become 2, -3, 2, 2, -3, 2

//         int left = 0;
//         int right = nums.Length - 1;
//         while(left < right){
//             if(nums[left] < 0 && nums[right] < 0){
//                 right--;
//             }
//             else if(nums[left] > 0 && nums[right] > 0){
//                 left++;
//             }
//             else if(nums[left] > 0 && nums[right] < 0){
//                 right--;
//             }
//             else if(nums[left] < 0 && nums[right] > 0){
//                 int temp = nums[left];
//                 nums[left] = nums[right];
//                 nums[right] = temp;
//                 left++;
//                 right--;
//             }
//         }
//         int k = left;
//         return left;
//     }
// }