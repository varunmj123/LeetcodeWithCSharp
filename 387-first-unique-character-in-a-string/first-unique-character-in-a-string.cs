public class Solution {
    public int FirstUniqChar(string s) {
        var charFreq = new Dictionary<char, int>();
        // Make a map of how many times we have seen a char
        for(int i =0; i < s.Length; i++){
            if(!charFreq.ContainsKey(s[i])){
                charFreq[s[i]] = 1;
            }
            else{
                charFreq[s[i]]++;
            }
        }
        // Find the first item in dict where Value == 1
        char nonRepeatingChar = ' ';
        foreach(var kvp in charFreq){
            if(kvp.Value == 1){
                nonRepeatingChar = kvp.Key;
                break;
            }
        }
        // If nonRepeatingChar is empty still then every char is repeating
        if(nonRepeatingChar == ' '){
            return -1;
        }
        // Find the index of the repeating char
        for(int i = 0; i < s.Length; i++){
            if(s[i] == nonRepeatingChar){
                return i;
            }
        }
        return -1;
    }
}