public class Solution {
    public bool AsteroidsDestroyed(int mass, int[] asteroids) {
        Array.Sort(asteroids);
        double massCumul = mass;
        foreach(var asteroid in asteroids)
        {
            if(massCumul>=asteroid)
                massCumul+= asteroid;
            else
            {
                return false;
            }
        }
        return true;
    }

}