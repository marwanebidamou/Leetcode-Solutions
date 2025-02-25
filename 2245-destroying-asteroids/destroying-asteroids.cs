public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        Array.Sort(asteroids);
        long totalMass = mass;
        foreach(var asteroid in asteroids)
        {
            if(totalMass<asteroid)
                return false;
            
            totalMass += asteroid;
        }

        return true;
    }
}