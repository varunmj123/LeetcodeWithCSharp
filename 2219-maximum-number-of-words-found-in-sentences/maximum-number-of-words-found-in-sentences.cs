public class Solution {
    public int MostWordsFound(string[] sentences) {
        int max = 0;
        for(int i = 0; i < sentences.Length; i++){
            string currentSentence = sentences[i];
            int currentSentenceLength = 1;
            for(int j = 0; j < currentSentence.Length; j++){
                if(currentSentence[j] == ' '){
                    currentSentenceLength++;
                }
            }
            if(currentSentenceLength > max){ 
                max = currentSentenceLength;
            }

        }
        return max;
    }
}