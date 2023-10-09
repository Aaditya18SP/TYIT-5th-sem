graph={
    "A":list(["B","C"]),
    "B":list(["A","D","E"]),
    "C":list(["A","F"]),
    "D":list(["B"]),
    "E":list(["B","F"]),
    "F":list(["E","C"]),
    }

def bfs(graph,startnode):
    queue=[startnode]
    visited=list()
    while queue:
        currentnode= queue.pop(0)
        if currentnode not in visited:
            visited.append(currentnode)
            queue.extend(graph[currentnode])
    return visited

print("BFS:",bfs(graph,"B"))
        
def bfs_paths(graph,startnode,endnode):
    queue=[(startnode,[startnode])]
    while queue:
        (vertex,path) = queue.pop(0)

        for next in set(graph[vertex])-set(path):
            if next==endnode:
                yield path+[next]
                #yeild temporarily stops the execution of the program
            else:
                queue.append((next,path+[next]))
print("the paths are:", list(bfs_paths(graph,"A","D")))

def shortest_path(graph,start,goal):
    try:
        return next(bfs_paths(graph,start,goal))
    except:
        return None
        
        
print(shortest_path(graph,"A","D"))

    
