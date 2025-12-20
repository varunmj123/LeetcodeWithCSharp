public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 0;
        int right = piles.Max();
        int k = right;
        while(left <= right){
            int middle = (right + left)/2;
            double middleTime = TimeTakenForPile(piles, middle);
            /*
            If valid (time <= h) →found a valid K(undertime) but could be smaller go left (try smaller k)
            If invalid (time > h) → go right (need bigger k)
            Never return on equality
            */
            if(middleTime > h){
                left = middle + 1;
            }
            else if(middleTime <= h){
                k = middle;
                right = middle - 1;
            }
        }
        return k;
    }
    public double TimeTakenForPile(int[] piles, int speedK){
        double returnTime = 0;
        for(int i =0; i < piles.Length; i++){
            double timeTakenForPile = Math.Ceiling((double)piles[i] / speedK);
            
            returnTime += timeTakenForPile;
        }
        return returnTime;
    }
}

/* TLE Brute Force O(n*k).Where K is the max eating rate 
public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int currentK = 1;
        // Call a function that takes in k, and total time, and piles and returns timetaken
 
        while(TimeTakenForPile(piles, currentK) > h){
            currentK++;
        }
        return currentK;
        
    }

    public double TimeTakenForPile(int[] piles, int speedK){
        double returnTime = 0;
        for(int i =0; i < piles.Length; i++){
            double timeTakenForPile = Math.Ceiling((double)piles[i] / speedK);
            
            returnTime += timeTakenForPile;
        }
        return returnTime;
    }
}

*/