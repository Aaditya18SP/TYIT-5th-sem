graph ={'A':list(['B','C']),
        'B':list(['A','D','E']),
        'C':list(['A','F']),
        'D':list(['B']),
        'E':list(['B','F']),
        'F':list(['E','C'])
         }
def dfs(graph,start):
    visited,stack=list(),[start]
    while stack:
        vertex=stack.pop()
        if vertex not in visited:
            visited.append(vertex)
            print("current vertex: ",vertex) 
            print("possible vertices to go to: ",graph[vertex])
            print("visited: ", visited)
            stack.extend(graph[vertex])
    return visited

print("DFS:",dfs(graph,"B"),"\n")

'''
This is done as DFS with set doesnt retain the order in which the nodes are visited.
With a list, theo order of the visited nodes is preserved hence we get the required output
'''

def dfs_paths(graph,start,goal):
    stack=[(start,[start])]
    print("in the start the stack is:",stack) #delete this
    while stack:
        (vertex,path)=stack.pop()
        print("\ncurrent stack after pop is:",stack) #delete this
        
        print("current vertex is:", vertex)#delete this
        print("current path is:", path)#delete this
        
        for next in set(graph[vertex])- set(path):
            
            print("graph[vertex] is:",graph[vertex]) #delete this
            print("set(path) is :", set(path))#delete this
            print("next is :", next)#delete this
            if next==goal:
                yield path+[next]
                
            else:
                stack.append((next,path+[next]))
                print("appended stack is:",stack)#delete this
                

def shortest_path(graph,start,goal):
    try:
        return next(dfs_paths(graph,start,goal))
    except:
        return None

print("the paths to reach from the given start and end goal:")
print ("DFS paths:",list(dfs_paths(graph,'B','F')))

#get the shortest path
print("shortest path:",shortest_path(graph,'B','F'))

