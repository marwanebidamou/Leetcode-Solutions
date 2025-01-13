public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        // Variables to track the current sum of gas and cost differences,
        // the total sum of gas and cost differences, and the potential starting station.
        int currentSum = 0;
        int totalSum = 0;
        int response = 0;

        // Loop through all gas stations.
        for(int i = 0; i < gas.Length; i++) {
            // Calculate the net gas left after visiting station i (gas[i] - cost[i]).
            currentSum += gas[i] - cost[i];
            // Update the total net gas difference for the entire circuit.
            totalSum += gas[i] - cost[i];

            // If at any point, the current sum becomes negative,
            // it means we cannot continue from the current starting station (response).
            if (currentSum < 0) {
                // Update the starting station to the next one (i + 1),
                // as all stations from the previous 'response' to 'i' are invalid.
                response = i + 1;
                // Reset the current sum to 0, as we are considering a new starting station.
                currentSum = 0;
            }
        }

        // After completing the loop, check if the total gas is sufficient to cover the total cost.
        // If totalSum >= 0, the circuit is possible, and 'response' holds the valid starting station.
        // Otherwise, return -1 to indicate the circuit is not possible.
        return totalSum >= 0 ? response : -1;
    }
}
