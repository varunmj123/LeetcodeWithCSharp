public class Solution {
    public bool IsValid(string s) {
        var bracketPairs = new Dictionary<char , char>{
           { '}','{'},
            {']','['},
            {')','('},
        };
        if(s.Length == 1){
            return false;
        }
        var bracketStack = new Stack<char>();
        for(int i = 0 ; i < s.Length; i++){ 
            // If it is an operner add to stack
            if(!bracketPairs.ContainsKey(s[i])){
                bracketStack.Push(s[i]);
            }
            else{
                if(bracketStack.Count > 0){
                    char poppedBracket = bracketStack.Pop();
                    if(poppedBracket != bracketPairs[s[i]]){
                        return false;
                    }
                }
                else{
                    return false;
                }
                
            }
        }
        if(bracketStack.Count > 0){
            return false;
        }
        else{
            return true;
        }
    }
}