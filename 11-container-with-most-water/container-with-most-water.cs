public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;
        while(left < right){
            int maxAllowedWater = Math.Min(heights[left], heights[right]);
            int totalDistance = right - left;
            int currentArea = maxAllowedWater * totalDistance;
            if(currentArea > maxArea){
                maxArea = currentArea;
            }
            // If the left is bigger move the right pointer back
            if(heights[left] > heights[right]){
                right--;
                continue;
            }
            // If the right is bigger move the left pointer front
            else if(heights[right] > heights[left]){
                left++;
                continue;
            }
            // If they are the same it does not matter and we can move either
            else{
                left++;
            }

        }
        return maxArea;
    }
}

/* Brute force 
public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int left = 0;
        while(left < heights.Length){
            int right = left + 1; 
            while(right < heights.Length){
                int maxAllowedWater = Math.Min(heights[left], heights[right]);
                int totalDistance = right - left;
                int currentArea = maxAllowedWater * totalDistance; 
                if(currentArea > maxArea){
                    maxArea = currentArea;
                }
                right++;
                continue;
            }
            left++;
            continue;
        }
        return maxArea;
    }
}

*/