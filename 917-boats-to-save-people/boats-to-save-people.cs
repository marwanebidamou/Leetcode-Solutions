public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people); // Step 1: Sort the people array
        int left = 0, right = people.Length - 1;
        int boats = 0;

        while (left <= right) {
            // Step 2: Try to pair the lightest and heaviest person
            if (people[left] + people[right] <= limit) {
                left++; // Move left pointer (lightest person is placed)
            }
            right--; // Heaviest person always gets placed in a boat
            boats++; // Use one boat
        }

        return boats;
    }
}
