public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = 0;
        int left = 0;
        var seenChars = new Dictionary<char, int>();
        for(int i =0; i < s.Length; i++){
            while(seenChars.ContainsKey(s[i])){
                seenChars.Remove(s[left]);
                left++;
            }
            seenChars[s[i]] = i;
            int currentCount = i - left + 1;
            if(currentCount > max){
                max = currentCount;
            }
        }
        return max;
    }
}