public class Solution {
    public string foreignDictionary(string[] words) {
        Dictionary<char, List<char>> adj = new Dictionary<char, List<char>>();
        Dictionary<char, int> inDegree = new Dictionary<char, int>();

        foreach (string word in words) {
            foreach (char c in word) {
                if (!adj.ContainsKey(c)) {
                    adj[c] = new List<char>();
                    inDegree[c] = 0;
                }
            }
        }

        for (int i = 0; i < words.Length - 1; i++) {
            string w1 = words[i];
            string w2 = words[i + 1];

            if (w1.Length > w2.Length && w1.StartsWith(w2)) {
                return "";
            }

            for (int j = 0; j < Math.Min(w1.Length, w2.Length); j++) {
                if (w1[j] != w2[j]) {
                    char parent = w1[j];
                    char child = w2[j];

                    adj[parent].Add(child);
                    inDegree[child]++;

                    break;
                }
            }
        }
        Queue<char> queue = new Queue<char>();

        foreach (var kvp in inDegree) {
            if (kvp.Value == 0) {
                queue.Enqueue(kvp.Key);
            }
        }

        System.Text.StringBuilder res = new System.Text.StringBuilder();

        while (queue.Count > 0) {
            char current = queue.Dequeue();
            res.Append(current);

            foreach (char neighbor in adj[current]) {
                inDegree[neighbor]--;
                if (inDegree[neighbor] == 0) {
                    queue.Enqueue(neighbor);
                }
            }
        }
        if (res.Length != inDegree.Count) {
            return "";
        }

        return res.ToString();
    }
}
