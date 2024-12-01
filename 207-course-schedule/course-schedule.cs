public class Solution {

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        Dictionary<int, List<int>> graph = new Dictionary <int, List<int>>();
        int[] prereqCount = new int[numCourses];

        for(int i=0;i<prerequisites.Length;i++)
        {
            if(!graph.ContainsKey(prerequisites[i][1]))
            {
                graph[prerequisites[i][1]] = new List<int>();
            }

            graph[prerequisites[i][1]].Add(prerequisites[i][0]);

            prereqCount[prerequisites[i][0]]++;
        }

        for(int i=0;i<prereqCount.Length;i++){
                bool[] visited = new bool[numCourses];
                bool[] active = new bool[numCourses];

                bool isValid = dfs(i, graph, visited, active);
                if(!isValid)
                {
                    return false;
                }
            
        }
        return true;
    }

    private bool dfs(int startVertex, Dictionary <int, List<int>> graph, bool[] visited, bool[] active)
    {
       

        if(!graph.ContainsKey(startVertex))
            return true;

        visited[startVertex] = true;
        active[startVertex] = true;

        var dependecies = graph[startVertex];
        foreach(var dependency in dependecies)
        {
            if(!visited[dependency])
            {
                bool isValid = dfs(dependency, graph, visited, active);
                if(!isValid)
                {
                    return false;
                }
            }
            else if(visited[dependency] && active[dependency])
            {
                return false;
            }
        }
        active[startVertex] = false;
        return true;
    }
}