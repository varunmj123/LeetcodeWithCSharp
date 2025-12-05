public class Solution {
    public bool IsValid(string s) {
        var stackName = new Stack<char>();
        var bracketPairs = new Dictionary<char, char>{
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        for(int i = 0; i < s.Length; i++){
            if(bracketPairs.ContainsKey(s[i]))
            {
                // This is an opening bracket so add to stack
                stackName.Push(s[i]);
            }
            else{
                // This is a closing bracket so we need to pop
                //Before popping we need to check if the stack is empty
                if(stackName.Count < 1){
                    return false;
                }
                char poppedChar = stackName.Pop();
                if(bracketPairs[poppedChar] != s[i]){
                    return false;
                }
            }
        }
        if(stackName.Count > 0){
            return false;
        }
        return true;
    }
}
