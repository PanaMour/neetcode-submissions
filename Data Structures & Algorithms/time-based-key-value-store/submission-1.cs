public class TimeMap
{
    Dictionary<string, List<(int time, string val)>> timeMap;
    public TimeMap()
    {
        timeMap = new Dictionary<string, List<(int time, string val)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!timeMap.ContainsKey(key))
        {
            timeMap[key] = new List<(int time, string val)>();
        }
        timeMap[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!timeMap.ContainsKey(key)) return "";

        var list = timeMap[key];
        int left = 0;
        int right = list.Count - 1;
        string res = "";

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (list[mid].time <= timestamp)
            {
                res = list[mid].val;
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return res;
    }
}