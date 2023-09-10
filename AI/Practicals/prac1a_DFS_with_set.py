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
print("shortest path:", shortest_path(graph,'A','F'))

'''OUTPUT for understanding
BFS: {'D', 'F', 'E', 'A', 'B', 'C'} 

DO IT WITH A LIST TO GET THE CORRECT ORDER IN WHICH THE NODES ARE VISITED
the paths to reach from the given start and end goal:
in the start the queue is: [('A', ['A'])]

current queue after pop is: []
current vertex is: A
current path is: ['A']
graph[vertex] is: {'B', 'C'}
set(path) is : {'A'}
next is : B
appended queue is: [('B', ['A', 'B'])]
graph[vertex] is: {'B', 'C'}
set(path) is : {'A'}
next is : C
appended queue is: [('B', ['A', 'B']), ('C', ['A', 'C'])]

current queue after pop is: [('C', ['A', 'C'])]
current vertex is: B
current path is: ['A', 'B']
graph[vertex] is: {'D', 'E', 'A'}
set(path) is : {'A', 'B'}
next is : D
appended queue is: [('C', ['A', 'C']), ('D', ['A', 'B', 'D'])]
graph[vertex] is: {'D', 'E', 'A'}
set(path) is : {'A', 'B'}
next is : E
appended queue is: [('C', ['A', 'C']), ('D', ['A', 'B', 'D']), ('E', ['A', 'B', 'E'])]

current queue after pop is: [('D', ['A', 'B', 'D']), ('E', ['A', 'B', 'E'])]
current vertex is: C
current path is: ['A', 'C']
graph[vertex] is: {'F', 'A'}
set(path) is : {'A', 'C'}
next is : F

current queue after pop is: [('E', ['A', 'B', 'E'])]
current vertex is: D
current path is: ['A', 'B', 'D']

current queue after pop is: []
current vertex is: E
current path is: ['A', 'B', 'E']
graph[vertex] is: {'F', 'B'}
set(path) is : {'E', 'A', 'B'}
next is : F
BFS paths: [['A', 'C', 'F'], ['A', 'B', 'E', 'F']]
in the start the queue is: [('A', ['A'])]

current queue after pop is: []
current vertex is: A
current path is: ['A']
graph[vertex] is: {'B', 'C'}
set(path) is : {'A'}
next is : B
appended queue is: [('B', ['A', 'B'])]
graph[vertex] is: {'B', 'C'}
set(path) is : {'A'}
next is : C
appended queue is: [('B', ['A', 'B']), ('C', ['A', 'C'])]

current queue after pop is: [('C', ['A', 'C'])]
current vertex is: B
current path is: ['A', 'B']
graph[vertex] is: {'D', 'E', 'A'}
set(path) is : {'A', 'B'}
next is : D
appended queue is: [('C', ['A', 'C']), ('D', ['A', 'B', 'D'])]
graph[vertex] is: {'D', 'E', 'A'}
set(path) is : {'A', 'B'}
next is : E
appended queue is: [('C', ['A', 'C']), ('D', ['A', 'B', 'D']), ('E', ['A', 'B', 'E'])]

current queue after pop is: [('D', ['A', 'B', 'D']), ('E', ['A', 'B', 'E'])]
current vertex is: C
current path is: ['A', 'C']
graph[vertex] is: {'F', 'A'}
set(path) is : {'A', 'C'}
next is : F
shortest path:['A', 'C', 'F']

'''

