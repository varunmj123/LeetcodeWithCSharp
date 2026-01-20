public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int candidateOne = 0;
        int candidateTwo = 0;
        int countOne = 0;
        int countTwo = 0;
        // The for statement below calculates the 2 most common numbers
        for(int i = 0; i < nums.Length; i++){
            if (nums[i] == candidateOne) {
                countOne++;
            }
            else if (nums[i] == candidateTwo) {
                countTwo++;
            }
            else if (countOne == 0) {
                candidateOne = nums[i];
                countOne = 1;
            }
            else if (countTwo == 0) {
                candidateTwo = nums[i];
                countTwo = 1;
            }
            else {
                countOne--;
                countTwo--;
            }
        }
        // Now we need to find which of these occur more than n/3 times
        countOne = 0;
        countTwo = 0;
        foreach(var n in nums){
            if(n == candidateOne){
                countOne++;
            }
            if(n == candidateTwo){
                countTwo++;
            }
        }
        int numberToMatch = nums.Length/3;
        List<int> result = new List<int>();
        if(countOne > numberToMatch){
            result.Add(candidateOne);
        }
        if(candidateTwo != candidateOne && countTwo > numberToMatch){
            result.Add(candidateTwo);
        }
        return result;
    }
}