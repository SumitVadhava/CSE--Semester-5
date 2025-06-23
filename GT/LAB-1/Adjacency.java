import java.util.*;

class Adjacency{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);       
        
        System.out.println("Enter the number of vertex =");
        int v = sc.nextInt();

        System.out.println("Enter the number of edges =");
        int edges = sc.nextInt();

        int [][] adj_edges = new int[edges][2];

        for(int i = 0; i < edges ; i++){
            System.out.println("Enter the"+ i +"edges");
            int x = sc.nextInt();
            int y = sc.nextInt();
            adj_edges[i][0] = x;
            adj_edges[i][1] = y; 
        }

        List<List<Integer>> ans = new ArrayList<>(v);

        for(int i = 0; i < v; i++){
            ans.add(new ArrayList<>());
        }
        
        for(int [] edge : adj_edges){
            int s = edge[0];
            int d = edge[1];

            ans.get(s).add(d);
        }

        for(int i = 0; i < ans.size(); i++){
            System.out.print(i + " -> ");

            for(int j : ans.get(i)){
                System.out.print(j + " ");
            }
            System.out.println("");
        }
       
    }
}