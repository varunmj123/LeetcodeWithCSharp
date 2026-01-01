public class Solution {
    public bool CheckIfPangram(string sentence) {
        bool[] seen = new bool[26];
        for(int i = 0; i < sentence.Length; i++){
            seen[sentence[i] - 'a'] = true;
        }
        for(int i = 0; i < seen.Length; i++){
            if(seen[i] == false){
                return false;
            }
        }
        return true;
    }
}