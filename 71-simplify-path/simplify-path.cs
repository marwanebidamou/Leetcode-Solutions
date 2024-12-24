public class Solution {
    public string SimplifyPath(string path) {
        
       var pathArray = path.Split('/');

        Stack<string> directories = new Stack<string>();

        foreach(var pathElement in pathArray)
        {
            Console.WriteLine(pathElement);

            if(pathElement=="" || pathElement==".")
                continue;
            
            if(pathElement==".." && directories.Count > 0)
                directories.Pop();
            else if (pathElement!="..")
                directories.Push(pathElement);
        }

        
        return "/"+string.Join('/', directories.Reverse());        
    }
}