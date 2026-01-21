public class Solution {
    public int CountKeyChanges(string s) {
        char currChar = ' ';
        int numberOfChanges = 0;
        for(int i = 0; i < s.Length; i++){
            if(currChar == ' '){ 
                currChar = s[i];
            }
            if(Char.ToLower(s[i]) != Char.ToLower(currChar)){
                numberOfChanges++;
                currChar = s[i];
            }
        }
        return numberOfChanges;
    }
}