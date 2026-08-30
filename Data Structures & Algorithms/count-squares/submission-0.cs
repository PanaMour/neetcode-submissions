public class CountSquares {
    Dictionary<(int x, int y), int> pointCounts;
    List<(int x, int y)> allPoints;
    public CountSquares() {
        pointCounts = new Dictionary<(int x, int y), int>();
        allPoints = new List<(int x, int y)>();
    }

    public void Add(int[] point) {
        (int x, int y) p = (point[0], point[1]);
        allPoints.Add(p);
        if (!pointCounts.ContainsKey(p))
            pointCounts[p] = 1;
        else
            pointCounts[p]++;
    }

    public int Count(int[] point) {
        int qx = point[0];
        int qy = point[1];
        int totalSquares = 0;
        foreach ((int px, int py) in allPoints) {
            if (Math.Abs(qx - px) == Math.Abs(qy - py) && qx != px) {
                if (pointCounts.ContainsKey((qx, py)) && pointCounts.ContainsKey((px, qy)))
                    totalSquares += pointCounts[(qx, py)] * pointCounts[(px, qy)];
            }
        }
        return totalSquares;
    }
}
