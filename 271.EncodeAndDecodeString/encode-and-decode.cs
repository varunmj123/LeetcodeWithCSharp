public class Solution {

    public string Encode(IList<string> strs) {
        string encodedString = "";
        for(int i = 0; i < strs.Count; i++){
            string currentWord = strs[i];
            string currentWordLength  = currentWord.Length.ToString();
            encodedString += currentWordLength + "#" + currentWord;
        }
        return encodedString;
    }    
    
    public List<string> Decode(string s) {
        var output = new List<string>();
        string currentLength = "";
        for(int i = 0; i < s.Length; i++){
            if(char.IsDigit(s[i])){
                currentLength += s[i];
            }
            else if(s[i] == '#' && currentLength != ""){
                int lengthOfWord = int.Parse(currentLength);
                string wordToAdd = s.Substring(i + 1, lengthOfWord);
                output.Add(wordToAdd);
                currentLength = "";
                i += lengthOfWord;
            }
        }
        return output;
   }
}
