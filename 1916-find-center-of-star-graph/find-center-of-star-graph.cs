public class Solution {
    public int FindCenter(int[][] edges) {
        
        int[] vertices = new int[edges.Length+2];

        for(int i=0;i<edges.Length;i++)
        {            
            vertices[edges[i][0]]++;
            vertices[edges[i][1]]++;

            if(vertices[edges[i][0]]==edges.Length)
            {
                return edges[i][0];
            }

            if(vertices[edges[i][1]]==edges.Length)
            {
                return edges[i][1];
            }
        }
        return 0;
    }
}