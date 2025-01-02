public class Solution {
    public int FindCircleNum(int[][] isConnected) {
        
        int n = isConnected.Length;
        int[] citiesProvinces = new int[n];
        int visitedCount = 0;

        //Convert matrix to adjacent list
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

        for(int i=0;i<n;i++)
        {
            for(int j=0;j<n;j++)
            {
                if(isConnected[i][j]==1)
                {
                    if(graph.ContainsKey(i))
                        graph[i].Add(j);
                    else
                        graph.Add(i, new List<int>{j});
                }
            }
        }

        int province = 1;
        while(visitedCount < n)
        {
            Stack<int> stack = new Stack<int>();
            //get next not visited city
            int city=0;
            while(citiesProvinces[city]!=0)
                city++;
            
            stack.Push(city);
            citiesProvinces[city] = province;
            visitedCount++;

            while(stack.Any())
            {
                var currCity = stack.Pop();
                
                //get neighbors
                var neighbors = graph[currCity];
                foreach(var neighbor in neighbors)
                {
                    if(citiesProvinces[neighbor]==0)
                    {
                        citiesProvinces[neighbor] = province;
                        stack.Push(neighbor);
                        visitedCount++;
                    }
                }
            }

            province++;
        }

        return province-1;
    }
}