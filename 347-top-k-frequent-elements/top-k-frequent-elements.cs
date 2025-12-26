public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqList = new List<int>[nums.Length + 1];
        // Need to initalize freqList with empty ints[]
        for(int i = 0; i < freqList.Length; i++){
            freqList[i] = new List<int>();
        }
        var freqMap = new Dictionary<int , int>();
        // O(n)
        for(int i = 0; i < nums.Length; i++){
            if(!freqMap.ContainsKey(nums[i])){
                freqMap[nums[i]] = 1;
            }
            else{
                freqMap[nums[i]]++;
            }
        }
        // Now freqMap contains number: frequency of number
        // Now we need to iterate over the keys
        var uniqueNumbers = freqMap.Keys.ToList();
        for(int i = 0; i < uniqueNumbers.Count; i++){
            // frequencyOfCurrentNumber is the position in main list  
            int frequencyOfCurrentNumber = freqMap[uniqueNumbers[i]];
            // Now we need to put this current number into the position 
            freqList[frequencyOfCurrentNumber].Add(uniqueNumbers[i]);
        }
        
        // Iterate backwards and return K amount of numbers 
        int counter = 0;
        int[] output = new int[k];
        for(int i = freqList.Length - 1; i >= 0; i--){
            if(counter < k){
                List<int> currentList = freqList[i];
                foreach(var number in currentList){
                    output[counter] = number;
                    counter++; 
                }
            }
        }
        return output; 


    }
}


/*
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Frequency : Number pairs 
        var numFreqDict = new Dictionary<int , int>();
        for(int i = 0; i < nums.Length; i++){
            if(!numFreqDict.ContainsKey(nums[i])){
                numFreqDict[nums[i]] = 0;
            }
            numFreqDict[nums[i]]++;
        }

        // Now we need to reverse this. Frequency : Numbers with that freq
        var freqNumDict = new Dictionary<int, List<int>>();
        foreach(var kvp in numFreqDict){
            int keys = kvp.Key;
            int value = kvp.Value;
            if(!freqNumDict.ContainsKey(value)){
                freqNumDict[value] = new List<int>();
            }
            freqNumDict[value].Add(keys);
        }
        // Sort the frequency keys from largest to smallest. 
        var sorted = freqNumDict.OrderByDescending(kvp => kvp.Key);

        //Now we need to pop from the dict the K highest values
        var numberOfOutputs = 0;
        var finalOutput = new List<int>();

        foreach(var kvp in sorted){
            List<int> numbers = kvp.Value;

            foreach(var v in numbers){
                finalOutput.Add(v);
                numberOfOutputs++;
                
                if(numberOfOutputs == k){
                    return finalOutput.ToArray();
                }
            }

        }
        return finalOutput.ToArray();
    }
}
*/