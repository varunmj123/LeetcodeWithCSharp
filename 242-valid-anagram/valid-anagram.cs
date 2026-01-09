public class Solution {
    public bool IsAnagram(string s, string t) {
        // make a map of s and t
        if(s.Length != t.Length){
            return false;
        }

        int[] sMap = new int[26];
        int[] tMap = new int[26];

        for(int i = 0; i < s.Length; i++){
            tMap[s[i] - 'a']++;
            sMap[t[i]- 'a']++;
        }

        for(int i = 0; i < 26; i++){
            if(tMap[i] != sMap[i]){
                return false;
            }
        }
        return true;
    }
}