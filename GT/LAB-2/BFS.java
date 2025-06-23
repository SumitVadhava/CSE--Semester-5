import java.util.*;

public class BFS{
    
    public static ArrayList<Integer> bfs(ArrayList<ArrayList<Integer>> adj){
        ArrayList<Integer> ans = new ArrayList<>();
        boolean [] visited = new boolean[adj.size()];
        Queue<Integer> que = new LinkedList<>();
        
        que.add(0);
        ans.add(0);
        
        while(!que.isEmpty()){
            int node = que.poll();
            visited[node] = true;

            for(int neighbor : adj.get(node)){
                if(!visited[neighbor]){
                    que.add(neighbor);
                    ans.add(neighbor);
                    visited[neighbor] = true;
                }
            }
        }
        return ans;    
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);        

        System.out.println("Enter the number of verticies = ");
        int V = sc.nextInt();

        ArrayList<ArrayList<Integer>> adj = new ArrayList<>(V);

        for(int i = 0;  i < V; i++){
            adj.add(new ArrayList<>());
        }

        System.out.println("Enter the number of edges = ");
        int E = sc.nextInt();


        for(int i = 0; i < E; i++){
            System.out.println("Enter" + (i + 1)+ "Edge=");
            int x = sc.nextInt();
            int y = sc.nextInt();

            adj.get(x).add(y);
            adj.get(y).add(y);
        }

        ArrayList<Integer> ans = bfs(adj);
        
        System.out.println("BFS Traversal = ");
        for(int i = 0; i < ans.size(); i++){
            System.out.print(ans.get(i) + " ");
        }
    }
}