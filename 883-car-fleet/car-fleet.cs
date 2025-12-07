public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {

        // Pair each car's position with its speed
        int[][] positionSpeed = new int[position.Length][];
        for(int i = 0; i < position.Length; i++){
            positionSpeed[i] = new int[]{ position[i], speed[i] };
        }
        Array.Sort(positionSpeed, (a, b) => b[0].CompareTo(a[0]));

        // Stack is storing the time each FLEET will reach
        var fleetStack = new Stack<double>();

        for(int i = 0; i < position.Length; i++){

            // Time for current car to reach target
            double timeOfCar = (double)(target - positionSpeed[i][0])/ positionSpeed[i][1];

            // If this car catches up to the fleet ahead, it merges into the fleet
            if(fleetStack.Count != 0 && fleetStack.Peek() >= timeOfCar){
                continue;
            }

            // Otherwise, this car starts a new fleet
            fleetStack.Push(timeOfCar);
        }

        // Number of fleets is the number of times stored
        return fleetStack.Count;
    }
}



/*
public int CarFleet(int target, int[] position, int[] speed) {
    int[][] positionSpeed = new int[position.Length][];
    for(int i = 0; i < position.Length; i++){
        positionSpeed[i] = new int[]{ position[i], speed[i] };
    }

    Array.Sort(positionSpeed, (a, b) => b[0].CompareTo(a[0]));

    int fleets = 0;
    double slowestTime = 0;

    for(int i = 0; i < position.Length; i++){
        double time = (double)(target - positionSpeed[i][0]) 
                      / positionSpeed[i][1];

        // New fleet only if slower than all fleets ahead
        if(time > slowestTime){
            fleets++;
            slowestTime = time;
        }
    }

    return fleets;
}

*/