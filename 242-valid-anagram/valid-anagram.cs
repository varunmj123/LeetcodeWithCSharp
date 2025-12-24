public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        var freqDictS = new Dictionary<char, int>();
        var freqDictT = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            if(!freqDictS.ContainsKey(s[i])){
                freqDictS[s[i]] = 1;
            }
            else{
                freqDictS[s[i]]++;
            }
        }
        for(int i = 0; i < t.Length; i++){
            if(!freqDictT.ContainsKey(t[i])){
                freqDictT[t[i]] = 1;
            }
            else{
                freqDictT[t[i]]++;
            }
        }
        //r : 2, a :2, c :2, e : 1
        //c : 2, a: 2, r: 2, e: 1
        // How do we compare these 2 dicts
        // Get the keys for S = [r, a,c, e]
        // Iterate over this check if this value exists in T and if the freq is matching
        char[] sKeys = freqDictS.Keys.ToArray();
        for(int i = 0; i < sKeys.Length; i++){
            if(!freqDictT.ContainsKey(sKeys[i])){
                return false;
            }
            else{
                int sKeyFreq = freqDictS[sKeys[i]];
                int tKeyFreq = freqDictT[sKeys[i]];
                if(sKeyFreq != tKeyFreq){
                    return false;
                }
            }
        }
        return true;
    }
}
