public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int>[] adj = new List<int>[numCourses];
        int[] inDegree = new int[numCourses];

        for (int i = 0; i < numCourses; i++) {
            adj[i] = new List<int>();
        }

        for (int i = 0; i < prerequisites.Length; i++) {
            int dest = prerequisites[i][0];
            int prereq = prerequisites[i][1];

            adj[prereq].Add(dest);
            inDegree[dest]++;
        }

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++) {
            if (inDegree[i] == 0) {
                queue.Enqueue(i);
            }
        }

        int[] order = new int[numCourses];
        int index = 0;

        while (queue.Count > 0) {
            int course = queue.Dequeue();

            order[index] = course;
            index++;

            foreach (int nextCourse in adj[course]) {
                inDegree[nextCourse]--;

                if (inDegree[nextCourse] == 0) {
                    queue.Enqueue(nextCourse);
                }
            }
        }

        if (index == numCourses) {
            return order;
        } else {
            return new int[0];
        }
    }
}
