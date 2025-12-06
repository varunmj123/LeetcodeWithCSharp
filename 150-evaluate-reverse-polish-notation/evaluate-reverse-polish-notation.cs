public class Solution {
    public int EvalRPN(string[] tokens) {
        var operators = new Dictionary<string, int>{
            {"+", 1},
            {"-", 2},
            {"*", 3},
            {"/", 4}
        
        };
        var currentNumbers = new Stack<int>();
        for(int i = 0; i < tokens.Length; i++){
            // Add to stack if it is not an operator
            if(!operators.ContainsKey(tokens[i])){  
                currentNumbers.Push(int.Parse(tokens[i]));
            }
            // We have seen an operator
            else{
                int operationOutput = 0;
                int numberOnRight = currentNumbers.Pop();
                int numberOnLeft = currentNumbers.Pop();
                if(operators[tokens[i]] == 1){
                    operationOutput = numberOnLeft + numberOnRight;
                }
                if(operators[tokens[i]] == 3){
                    operationOutput = numberOnLeft * numberOnRight;
                }
                if(operators[tokens[i]] == 2){
                    operationOutput = numberOnLeft - numberOnRight;
                }
                if(operators[tokens[i]] == 4){
                    operationOutput = numberOnLeft / numberOnRight;
                }
                currentNumbers.Push(operationOutput);  
            }
        }
        return currentNumbers.Pop();
    }
}
