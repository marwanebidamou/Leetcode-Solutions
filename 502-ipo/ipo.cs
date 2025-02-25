public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        List<Project> projects = new List<Project>();

        // Step 1: Store all projects in a list
        for (int i = 0; i < profits.Length; i++) {
            projects.Add(new Project(capital[i], profits[i]));
        }

        // Step 2: Sort projects by required capital (ascending)
        projects.Sort((a, b) => a.Capital.CompareTo(b.Capital));

  // Step 3: Use a max-heap to track profitable projects
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        int index=0;


        // Step 4: Pick at most `k` projects
        for(int i=0;i<k;i++)
        {
            // Add all affordable projects to the max-heap
            while(index<projects.Count && projects[index].Capital<= w)
            {
                maxHeap.Enqueue(projects[index].Profit, projects[index].Profit);
                index++;
            }

            // If no projects are available, stop
            if (maxHeap.Count == 0) break;

            w += maxHeap.Dequeue();

        }

        return w;

    }
}



class Project {
    public int Capital { get; }
    public int Profit { get; }

    public Project(int capital, int profit) {
        Capital = capital;
        Profit = profit;
    }
}