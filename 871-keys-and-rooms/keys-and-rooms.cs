public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        
        bool[] visited = new bool[rooms.Count()];

        void VisiteRooms(int room)
        {
            foreach(var nextRoom in rooms[room])
            {
                if(!visited[nextRoom])
                {
                    visited[nextRoom] = true;
                    VisiteRooms(nextRoom);
                }
            }
        }

        visited[0]=true;
        VisiteRooms(0);

        foreach(bool isVisited in visited)
        {
            if(!isVisited)
                return false;
        }
        return true;
    }

   
}