public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] adj = new List<int>[numCourses];
        int[] inDegree = new int[numCourses];
        for (int i = 0; i < numCourses; i++) {
            adj[i] = new List<int>();
        }
        for(int i=0;i<prerequisites.Length;i++){
            int course = prerequisites[i][0];
            int pre = prerequisites[i][1];
            adj[pre].Add(course);
            inDegree[course]++;
        }

        int coursesTaken = 0;
        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < inDegree.Length; i++) {
            if (inDegree[i] == 0) {
                queue.Enqueue(i);
            }
        }
        while(queue.Count > 0){
            int course = queue.Dequeue();
            coursesTaken++;
            foreach(int nextCourse in adj[course]){
                inDegree[nextCourse]--;
                if(inDegree[nextCourse] == 0){
                    queue.Enqueue(nextCourse);
                }                
            }
        }
        return coursesTaken == numCourses;
    }
}
