
graph={
    "A":list(["B","C"]),
    "B":list(["A","D","E"]),
    "C":list(["A","F"]),
    "D":list(["B"]),
    "E":list(["B","F"]),
    "F":list(["E","C"]),
    }

def bfs(graph,start):
    queue=[start]
    visited=[]
    while queue:
        ele=queue.pop(0)

        if ele not in visited:
            visited.append(ele)
            queue.extend(graph[ele])
    return visited

print("BFS",bfs(graph,"A"))

def bfs_paths(graph,start,end):

    queue=[(start,[start])]
    print(queue)
    
    while queue:
        print(queue)
        (visited,path)=queue.pop(0)
    
        for next in set(graph[visited]) - set(path):
            if (next ==end):
                yield path+[next]
            else:
                queue.append((next,path+[next]))

def shortest_path(graph,start,end):
    try:
        return next in bfs_paths(graph,start,end)
    except:
        None

print("Paths:", list(bfs_paths(graph,"A","D")))
print(shortest_path(graph,"A","D"))

            
        
