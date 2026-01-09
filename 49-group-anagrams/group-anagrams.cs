public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var freqDict = new Dictionary<string, List<string>>();

        for(int i =0; i < strs.Length; i++){
            string currentWord = strs[i];
            int[] currentWordMap = new int[26];
            for(int j = 0; j < currentWord.Length; j++){
                currentWordMap[currentWord[j]- 'a']++;
            }
            string key = string.Join(",", currentWordMap);
            if(!freqDict.ContainsKey(key)){
                freqDict[key] = new List<string>();
            }
            freqDict[key].Add(currentWord);
            
        }
        IList<IList<string>> result = new List<IList<string>>();

        foreach (var group in freqDict.Values) {
            result.Add(group);
        }

        return result;
    }
}