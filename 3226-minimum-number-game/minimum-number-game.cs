public class Solution{
public int[] NumberGame(int[] nums) {
    Array.Sort(nums);

    int[] output = new int[nums.Length];
    int pos = 0;

    for (int i = 0; i < nums.Length; i += 2) {
        output[pos++] = nums[i + 1]; // Bob
        output[pos++] = nums[i];     // Alice
    }

    return output;
}
}

// public class Solution {
//     public int[] NumberGame(int[] nums) {
 
//         int[] output = new int[nums.Length];
//         int numberOfTurns = nums.Length/2;
//         int position = 0;
//         while(numberOfTurns > 0){
//             int aliceMin = int.MaxValue;
//             int aliceMinIndex = 0;
//              for(int i =0; i < nums.Length; i++){
//                 if(nums[i] < aliceMin){
//                     aliceMin = nums[i];
//                     aliceMinIndex = i;
//                 }
//              }
//              nums[aliceMinIndex] = int.MaxValue;
//             int bobMin = int.MaxValue;
//             int bobMinIndex = 0;
//             for(int i = 0; i < nums.Length; i++){
//                 if(nums[i] < bobMin){
//                     bobMin = nums[i];
//                     bobMinIndex = i;
//                 }
//             }
//             nums[bobMinIndex] = int.MaxValue;
//             output[position] = bobMin;
//             position++;
//             output[position] = aliceMin;
//             position++;
//             numberOfTurns--;
//         }
//         return output;
//     }
// }