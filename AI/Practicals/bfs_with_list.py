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
            print("current vertex: ",vertex) 
            print("possible vertices to go to: ",graph[vertex])
            print("visited: ", visited)
            queue.extend(graph[vertex])
    return visited

print("BFS:",bfs(graph,"B"),"\n")

'''
This is done as BFS with set doesnt retain the order in which the nodes are visited.
With a list, theo order of the visited nodes is preserved hence we get the required output
'''

def bfs_paths(graph,start,goal):
    queue=[(start,[start])]
    print("in the start the queue is:",queue) #delete this
    while queue:
        (vertex,path)=queue.pop(0)
        print("\ncurrent queue after pop is:",queue) #delete this
        
        print("current vertex is:", vertex)#delete this
        print("current path is:", path)#delete this
        
        for next in set(graph[vertex])- set(path):
            
            print("graph[vertex] is:",graph[vertex]) #delete this
            print("set(path) is :", set(path))#delete this
            print("next is :", next)#delete this
            if next==goal:
                yield path+[next]
                
            else:
                queue.append((next,path+[next]))
                print("appended queue is:",queue)#delete this
                

def shortest_path(graph,start,goal):
    try:
        return next(bfs_paths(graph,start,goal))
    except:
        return None

print("the paths to reach from the given start and end goal:")
print ("BFS paths:",list(bfs_paths(graph,'A','F')))

#get the shortest path
print("shortest path:",shortest_path(graph,'A','F'))

