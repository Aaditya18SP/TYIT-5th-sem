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

'''OUTPUT to be written
BFS: ['B', 'A', 'D', 'E', 'C', 'F']
the paths to reach from the given start and end goal:
BFS paths: [['A', 'C', 'F'], ['A', 'B', 'E', 'F']]
shortest path: ['A', 'C', 'F']
'''

'''OUTPUT FOR UNDERSTANDING
current vertex:  B
possible vertices to go to:  ['A', 'D', 'E']
visited:  ['B']
current vertex:  A
possible vertices to go to:  ['B', 'C']
visited:  ['B', 'A']
current vertex:  D
possible vertices to go to:  ['B']
visited:  ['B', 'A', 'D']
current vertex:  E
possible vertices to go to:  ['B', 'F']
visited:  ['B', 'A', 'D', 'E']
current vertex:  C
possible vertices to go to:  ['A', 'F']
visited:  ['B', 'A', 'D', 'E', 'C']
current vertex:  F
possible vertices to go to:  ['E', 'C']
visited:  ['B', 'A', 'D', 'E', 'C', 'F']
BFS: ['B', 'A', 'D', 'E', 'C', 'F'] 

the paths to reach from the given start and end goal:
in the start the queue is: [('A', ['A'])]

current queue after pop is: []
current vertex is: A
current path is: ['A']
graph[vertex] is: ['B', 'C']
set(path) is : {'A'}
next is : B
appended queue is: [('B', ['A', 'B'])]
graph[vertex] is: ['B', 'C']
set(path) is : {'A'}
next is : C
appended queue is: [('B', ['A', 'B']), ('C', ['A', 'C'])]

current queue after pop is: [('C', ['A', 'C'])]
current vertex is: B
current path is: ['A', 'B']
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B', 'A'}
next is : E
appended queue is: [('C', ['A', 'C']), ('E', ['A', 'B', 'E'])]
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B', 'A'}
next is : D
appended queue is: [('C', ['A', 'C']), ('E', ['A', 'B', 'E']), ('D', ['A', 'B', 'D'])]

current queue after pop is: [('E', ['A', 'B', 'E']), ('D', ['A', 'B', 'D'])]
current vertex is: C
current path is: ['A', 'C']
graph[vertex] is: ['A', 'F']
set(path) is : {'C', 'A'}
next is : F

current queue after pop is: [('D', ['A', 'B', 'D'])]
current vertex is: E
current path is: ['A', 'B', 'E']
graph[vertex] is: ['B', 'F']
set(path) is : {'B', 'E', 'A'}
next is : F

current queue after pop is: []
current vertex is: D
current path is: ['A', 'B', 'D']
BFS paths: [['A', 'C', 'F'], ['A', 'B', 'E', 'F']]
in the start the queue is: [('A', ['A'])]

current queue after pop is: []
current vertex is: A
current path is: ['A']
graph[vertex] is: ['B', 'C']
set(path) is : {'A'}
next is : B
appended queue is: [('B', ['A', 'B'])]
graph[vertex] is: ['B', 'C']
set(path) is : {'A'}
next is : C
appended queue is: [('B', ['A', 'B']), ('C', ['A', 'C'])]

current queue after pop is: [('C', ['A', 'C'])]
current vertex is: B
current path is: ['A', 'B']
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B', 'A'}
next is : E
appended queue is: [('C', ['A', 'C']), ('E', ['A', 'B', 'E'])]
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B', 'A'}
next is : D
appended queue is: [('C', ['A', 'C']), ('E', ['A', 'B', 'E']), ('D', ['A', 'B', 'D'])]

current queue after pop is: [('E', ['A', 'B', 'E']), ('D', ['A', 'B', 'D'])]
current vertex is: C
current path is: ['A', 'C']
graph[vertex] is: ['A', 'F']
set(path) is : {'C', 'A'}
next is : F
shortest path: ['A', 'C', 'F']


'''

