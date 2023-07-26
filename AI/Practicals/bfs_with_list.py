graph ={'A':list(['B','C']),
        'B':list(['A','D','E']),
        'C':list(['A','F']),
        'D':list(['B']),
        'E':list(['B','F']),
        'F':list(['E','C'])
         }
def bfs(graph,start):
    visited,queue=list(),[start]
    while queue:
        vertex=queue.pop(0)
        if vertex not in visited:
            visited.append(vertex)
            print(graph[vertex])
            print(visited)
            queue.extend(graph[vertex])
    return visited

print("BFS:",bfs(graph,"B"),"\n");

'''
This is done as BFS with set doesnt retain the order in which the nodes are visited.
With a list, theo order of the visited nodes is preserved hence we get the required output
'''
