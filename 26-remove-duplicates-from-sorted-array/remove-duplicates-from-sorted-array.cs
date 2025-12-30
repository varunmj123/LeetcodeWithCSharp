public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int pointer = 0;
        for(int i =0; i < nums.Length; i++){
            if(nums[pointer] != nums[i]){
                nums[pointer + 1] = nums[i];
                pointer++;
            }
        }
        return pointer + 1;
    }
}

//public class Solution {
//     public int RemoveDuplicates(int[] nums) {
//         int pointer = 0;
//         var seenNumber = new Dictionary<int , int>();

//         for(int i=0; i < nums.Length; i++){
//             if(!seenNumber.ContainsKey(nums[i])){
//                 nums[pointer] = nums[i];
//                 pointer++;
//             }
//             seenNumber[nums[i]] = i;
//         }
//         return pointer;
//     }
// }