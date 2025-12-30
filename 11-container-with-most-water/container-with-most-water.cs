public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length -1 ;
        int maxVolume = 0;
        while(left < right){
            int minHeight = Math.Min(height[left], height[right]);
            int currentVolume = (right - left) * minHeight;
            if(currentVolume > maxVolume){
                maxVolume = currentVolume;
            }
            if(height[left] > height[right]){
                right--;
            }
            else{
                left++;
            }
        }
        return maxVolume;
    }
}