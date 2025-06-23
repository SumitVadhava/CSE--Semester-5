import java.util.*;

class DFS{
    public static ArrayList<Integer> dfs(ArrayList<ArrayList<Integer>> adj){
        ArrayList<Integer> result = new ArrayList<>();
        Stack<Integer> stack = new Stack<>();
        boolean [] visited = new boolean[adj.size()];

        stack.add(0);
        result.add(0);

        while(!stack.isEmpty()){
            int node = stack.pop();
            visited[node] = true;

            for(int neighbor : adj.get(node)){
                if(!visited[neighbor]){
                    stack.add(neighbor);
                    result.add(neighbor);
                    visited[neighbor] = true;
                }
               
            }
        }

        return  result;
    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);        
        System.out.println("Enter the number of vertax = ");
        int V = sc.nextInt();

        ArrayList<ArrayList<Integer>> adj = new ArrayList<>(V);

        for(int i = 0; i < V; i++){
            adj.add(new ArrayList<>());
        }

        System.out.println("Enter the number of edges = ");
        int E = sc.nextInt();

        for(int i = 0; i < E; i++){
            System.out.println("Enter the "+ (i + 1) +" edge = " );
            int x = sc.nextInt();
            int y = sc.nextInt();

            adj.get(x).add(y);
            adj.get(y).add(x);
        }

        ArrayList<Integer> result = dfs(adj);

        System.out.println("DFS Traversal =");
        
        for(int num : result){
            System.out.print(num +" ");
        }
    }
}