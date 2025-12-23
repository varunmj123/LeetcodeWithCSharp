public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int maxProfit = 0;
        for(int i = 1; i < prices.Length; i++){
            int currentProfit = prices[i] - min;
            if(currentProfit > maxProfit){
                maxProfit = currentProfit;
            }
            if(prices[i] < min){
                min = prices[i];
            }
            
        }
        return maxProfit;
    }
}
