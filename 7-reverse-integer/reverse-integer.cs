public class Solution {
    public int Reverse(int x) {
        if(x > int.MaxValue || x < int.MinValue){
            return 0;
        }
        bool isNegative = false;
        if(x < 0){
            isNegative = true;
        }
        string xString = x.ToString();
        string output = "";
        if(isNegative){
            output += "-";
            for(int i = xString.Length -1  ; i > 0; i--){
                output += xString[i];
        }
        }
        else{
            for(int i = xString.Length - 1; i >= 0; i--){
                output += xString[i];
        }
        }
        if(int.TryParse(output, out int result)){
            return result;
        }
        else{
            return 0;
        }
   
        
        
    }
}