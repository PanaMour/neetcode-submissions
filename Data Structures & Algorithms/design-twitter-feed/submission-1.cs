public class Twitter {
    int time;
    Dictionary<int, HashSet<int>> followMap;
    Dictionary<int, List<(int time, int tweetId)>> tweetMap;
    public Twitter() {
        this.time = 0;
        this.followMap = new Dictionary<int, HashSet<int>>();
        this.tweetMap = new Dictionary<int, List<(int count, int tweetId)>>();
    }

    public void PostTweet(int userId, int tweetId) {
        if (!tweetMap.ContainsKey(userId)) {
            tweetMap[userId] = new List<(int, int)>();
        }
        tweetMap[userId].Add((time, tweetId));
        time++;
    }

    public List<int> GetNewsFeed(int userId) {
        List<int> res = new List<int>();
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        Follow(userId, userId);
        foreach (int followeeId in followMap[userId]) {
            if (tweetMap.ContainsKey(followeeId)) {
                foreach (var tweet in tweetMap[followeeId]) {
                    maxHeap.Enqueue(tweet.tweetId, -tweet.time);
                }
            }
        }
        while (maxHeap.Count > 0 && res.Count < 10) {
            res.Add(maxHeap.Dequeue());
        }

        return res;
    }

    public void Follow(int followerId, int followeeId) {
        if (!followMap.ContainsKey(followerId)) {
            followMap[followerId] = new HashSet<int>();
        }

        followMap[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId) {
        if (followMap.ContainsKey(followerId)) {
            followMap[followerId].Remove(followeeId);
        }
    }
}