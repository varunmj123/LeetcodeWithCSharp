public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int numberOfDays = temperatures.Length;
        int[] output = new int[numberOfDays];
        var hottestStack = new Stack<int[]>(); // Temp : Position

        for(int i = 0; i < numberOfDays; i++){
            int currentTemp = temperatures[i];
            if(hottestStack.Count == 0){
                hottestStack.Push(new int[]{currentTemp, i});
            }
            else{
                int[] lastTempAndLocation = hottestStack.Peek();
                int lastTemp = lastTempAndLocation[0];
                while(currentTemp > lastTemp){
                    int[] dayToProcess = hottestStack.Pop();
                    int diffrenceInDays = i - dayToProcess[1];
                    output[dayToProcess[1]] = diffrenceInDays;
                    if(hottestStack.Count != 0){
                        lastTempAndLocation = hottestStack.Peek();
                        lastTemp = lastTempAndLocation[0];
                    }
                    else{
                        break;
                    }
                    
                }
                hottestStack.Push(new int[] {currentTemp , i});
                
            }
        }
        return output; 
    }
}
