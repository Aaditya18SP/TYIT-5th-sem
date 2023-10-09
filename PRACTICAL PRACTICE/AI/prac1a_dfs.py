graph={
    "A":list(["B","C"]),
    "B":list(["A","D","E"]),
    "C":list(["A","F"]),
    "D":list(["B"]),
    "E":list(["B","F"]),
    "F":list(["C","E"])
    }

print(graph)
def dfs(graph,start):
    stack=[start]
    visited=[]
    while stack:
        cur_node= stack.pop()
        if(cur_node not in visited):
            visited.append(cur_node)
            stack.extend(graph[cur_node])
    return visited

print("DFS:", dfs(graph,"B"))

def dfs_paths(graph,start,goal):
    stack=[(start,[start])]
    
    while stack:
        (vertex,path)= stack.pop()

        for next in set(graph[vertex])- set(path):
            if next==goal:
                yield path+[next]
            else:
                stack.append((next,path+[next]))
print("DFS paths:", list(dfs_paths(graph,"A","D")))


#No need to find the shortest path
def shortest_path(graph,start,goal):
    try:
        return next(dfs_paths(graph,start,goal))
    except:
        None


print(shortest_path(graph,"A","D"))
