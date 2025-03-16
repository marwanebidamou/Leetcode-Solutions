public class RandomizedSet {

    HashSet<int> hash = new HashSet<int>();
    Random r = new Random();
    public RandomizedSet() {
        
    }
    
    public bool Insert(int val) {
        return hash.Add(val);
    }
    
    public bool Remove(int val) {
        return hash.Remove(val);
    }
    
    public int GetRandom() {

        int rInt = r.Next(0, hash.Count);
        return hash.ElementAt(rInt);        
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */