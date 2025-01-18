public class SQL
{
    Dictionary<string, Dictionary<int, IList<string>>> data = new Dictionary<string, Dictionary<int, IList<string>>>();
    Dictionary<string, int> autoIncrement = new Dictionary<string, int>();
    Dictionary<string, int> columnCount = new Dictionary<string, int>();

    public SQL(IList<string> names, IList<int> columns)
    {
        int n = names.Count;
        for (int i = 0; i < n; i++)
        {
            data[names[i]] = new Dictionary<int, IList<string>>();
            autoIncrement[names[i]] = 1;
            columnCount[names[i]] = columns[i];
        }
    }

    public bool Ins(string name, IList<string> row)
    {
        if (!data.ContainsKey(name) || row.Count != columnCount[name])
            return false;

        int id = autoIncrement[name]++;
        data[name].Add(id, row);
        return true;
    }

    public void Rmv(string name, int rowId)
    {
        if (data.ContainsKey(name))
        {
            data[name].Remove(rowId);
        }
    }

    public string Sel(string name, int rowId, int columnId)
    {
        if (!data.ContainsKey(name) || !data[name].ContainsKey(rowId))
            return "<null>";

        if (columnId < 0 || columnId > data[name][rowId].Count)
            return "<null>";

        return data[name][rowId][columnId-1];
    }

    public IList<string> Exp(string name)
    {
        if (!data.ContainsKey(name))
            return new List<string>();

        return data[name]
            .OrderBy(x => x.Key) // Ensure rows are exported in order
            .Select(x => x.Key.ToString() + "," + string.Join(',', x.Value))
            .ToList();
    }
}

/**
 * Your SQL object will be instantiated and called as such:
 * SQL obj = new SQL(names, columns);
 * bool param_1 = obj.Ins(name,row);
 * obj.Rmv(name,rowId);
 * string param_3 = obj.Sel(name,rowId,columnId);
 * IList<string> param_4 = obj.Exp(name);
 */