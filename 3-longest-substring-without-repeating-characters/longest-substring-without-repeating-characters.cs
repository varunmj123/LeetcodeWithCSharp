public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int longest = 0;
        var currentChar = new Dictionary<char, int>();
        for(int right = 0; right < s.Length; right++){
            if(currentChar.ContainsKey(s[right])){
                while(currentChar.ContainsKey(s[right])){
                    currentChar.Remove(s[left]);
                    left++;
                }
            }
            currentChar[s[right]] = right; 
            int currLength = right - left + 1;
            if(currLength > longest){
                longest = currLength;
            }
        }
        return longest;
    }
}