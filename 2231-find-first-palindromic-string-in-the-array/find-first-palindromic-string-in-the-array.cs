public class Solution {
    public string FirstPalindrome(string[] words) {
        for(int i =0; i < words.Length; i++){
            string currentWord = words[i];
            int left = 0;
            int right = currentWord.Length - 1;
            bool isPalindrome = true;
            while(left < right){
                if(currentWord[left] == currentWord[right]){
                    left++;
                    right--;
                }
                else{
                  isPalindrome = false;  
                  break;
                }
            }
            if(isPalindrome){
                return currentWord;
            }
        }
        return "";
    }
}