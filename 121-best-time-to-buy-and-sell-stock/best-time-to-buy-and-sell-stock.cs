public class Solution {
    public int MaxProfit(int[] prices) {
        int min = 0;
        int maxProfit = 0;
        for(int i = 1; i < prices.Length; i++){
            if(prices[min] > prices[i]){
                min = i;
            }
            else{
                int currentProfit = prices[i] - prices[min];
                if(currentProfit > maxProfit){
                    maxProfit = currentProfit; 
                }
            }
        }
        return maxProfit;
    }
}