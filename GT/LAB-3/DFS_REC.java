import java.util.*;

public class DFS_REC {
    public static void dfs_rec(ArrayList<ArrayList<Integer>> adj,boolean [] visited,ArrayList<Integer> result, int node){
        visited[node] = true;
        result.add(node);

        for(int neighbour : adj.get(node)){
            if(!visited[neighbour]){
                dfs_rec(adj, visited, result, neighbour);
            }
        }

    }

    public static ArrayList<Integer> dfs(ArrayList<ArrayList<Integer>>adj) {
        boolean[] visited = new boolean[adj.size()];
        ArrayList<Integer> result = new ArrayList<>();

        dfs_rec(adj, visited, result, 0);
        return result;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);   
        
        System.out.println("Enter the number of vertex = ");
        int V = sc.nextInt();
        
        ArrayList<ArrayList<Integer>> adj = new ArrayList<>(V);

        for(int i = 0; i < V; i++){
            adj.add(new ArrayList<>());
        }

        System.out.println("Enter the number of edges = ");
        int E = sc.nextInt();

        for(int i = 0; i < E; i++){
            System.out.println("Enter " + (i + 1) + " edge =");
            int x = sc.nextInt();
            int y = sc.nextInt();

            adj.get(x).add(y);
            adj.get(y).add(x);
        }

        ArrayList<Integer> result = dfs(adj);

        System.out.println("DFS Traversal = ");
        for(int num : result){
            System.out.print(num + " ");
        }

        System.out.println("\n"+adj.get(0));

    }
}