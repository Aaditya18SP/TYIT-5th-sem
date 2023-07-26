graph ={'A':set(['B','C']),
        'B':set(['A','D','E']),
        'C':set(['A','F']),
        'D':set(['B']),
        'E':set(['B','F']),
        'F':set(['E','C'])
         }
def bfs(graph,start):
    visited,queue=set(),[start]
    while queue:
        vertex=queue.pop(0)
        if vertex not in visited:
            visited.add(vertex)
            queue.extend(graph[vertex]-visited)
    return visited

print("BFS:",bfs(graph,"A"),"\n");

string="Do it with a list to get the correct order in which the nodes are visited"
allcaps=string.upper()
print(allcaps)
'''
DO IT WITH A LIST TO GET THE CORRECT ORDER IN WHICH THE NODES ARE VISITED

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
        
        for next in graph[vertex]-set(path):
            
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
#print(shortest_path(graph,'A','F'))

