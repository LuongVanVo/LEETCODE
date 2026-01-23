public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<List<int>> graph = new List<List<int>>();
        int[] inDegree = new int[numCourses];

        for (int i = 0; i < numCourses; i++) graph.Add(new List<int>());

        foreach (var item in prerequisites)
        {
            int course = item[0];
            int condition = item[1];

            graph[condition].Add(course); // item[1] -> item[0]
            inDegree[course]++; // Tăng số lượng mũi tên chỉ vào item[0]
        }

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (inDegree[i] == 0) queue.Enqueue(i);
        }

        // BFS 
        int count = 0;
        while (queue.Count > 0)
        {
            int u = queue.Dequeue();
            count++;

            foreach(int v in graph[u])
            {
                inDegree[v]--;
                if (inDegree[v] == 0) 
                    queue.Enqueue(v);
            }
        }
        return count == numCourses;
    }
    
}