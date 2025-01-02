public class Solution {
    public int NumIslands(char[][] grid) {
        //Build the graph
        Dictionary<int,List<int>> graph = new Dictionary<int,List<int>>();
        int rowsCount = grid.Length;
        int colsCount = grid[0].Length;
        bool?[] visited = new bool?[colsCount*rowsCount];
        int landsCount = 0;
        for(int i=0;i<rowsCount;i++)
        {
            for(int j=0;j<colsCount;j++)
            {
                if(grid[i][j] == '1')
                {
                    List<int> neighbors = new List<int>();
                    if(j>0 && grid[i][j-1]=='1')
                        neighbors.Add(colsCount*i +j-1);
                    if(j<colsCount-1 && grid[i][j+1]=='1')
                        neighbors.Add(colsCount*i +j+1);
                    if(i>0 && grid[i-1][j]=='1')
                        neighbors.Add(colsCount*(i-1) +j);
                    if(i<rowsCount-1 && grid[i+1][j]=='1')
                        neighbors.Add(colsCount*(i+1) +j);

                    graph[colsCount*i +j] = neighbors;
                    visited[colsCount*i +j] = false;
                    landsCount++;
                }
            }
        }

        //Get next unvisited land
        int visitedCount = 0;
        int numberofIslands = 0;
        while(visitedCount<landsCount)
        {
            int land=0;
            while(visited[land]!= false)
                land++;

            numberofIslands++;
            Stack<int> stack = new Stack<int>();
            stack.Push(land);
            visitedCount++;
            visited[land]=true;

            while(stack.Count > 0)
            {
                land = stack.Pop();
                var neighbors = graph[land];
                foreach(var neighbor in neighbors)
                {
                    if(visited[neighbor]==false)
                    {
                        visited[neighbor] = true;
                        stack.Push(neighbor);
                        visitedCount++;
                    }
                }
            }
        }


        return numberofIslands;
        
    }
}