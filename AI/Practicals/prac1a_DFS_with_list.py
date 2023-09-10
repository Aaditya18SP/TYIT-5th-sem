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

'''OUTPUT To be written

DFS: ['B', 'E', 'F', 'C', 'A', 'D']
the paths to reach from the given start and end goal:
DFS paths: [['B', 'E', 'F'], ['B', 'A', 'C', 'F']]
shortest path: ['B', 'E', 'F']

'''


'''OUTPUT FOR UNDERSTANDING
current vertex:  B
possible vertices to go to:  ['A', 'D', 'E']
visited:  ['B']
current vertex:  E
possible vertices to go to:  ['B', 'F']
visited:  ['B', 'E']
current vertex:  F
possible vertices to go to:  ['E', 'C']
visited:  ['B', 'E', 'F']
current vertex:  C
possible vertices to go to:  ['A', 'F']
visited:  ['B', 'E', 'F', 'C']
current vertex:  A
possible vertices to go to:  ['B', 'C']
visited:  ['B', 'E', 'F', 'C', 'A']
current vertex:  D
possible vertices to go to:  ['B']
visited:  ['B', 'E', 'F', 'C', 'A', 'D']
DFS: ['B', 'E', 'F', 'C', 'A', 'D'] 

the paths to reach from the given start and end goal:
in the start the stack is: [('B', ['B'])]

current stack after pop is: []
current vertex is: B
current path is: ['B']
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B'}
next is : A
appended stack is: [('A', ['B', 'A'])]
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B'}
next is : D
appended stack is: [('A', ['B', 'A']), ('D', ['B', 'D'])]
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B'}
next is : E
appended stack is: [('A', ['B', 'A']), ('D', ['B', 'D']), ('E', ['B', 'E'])]

current stack after pop is: [('A', ['B', 'A']), ('D', ['B', 'D'])]
current vertex is: E
current path is: ['B', 'E']
graph[vertex] is: ['B', 'F']
set(path) is : {'B', 'E'}
next is : F

current stack after pop is: [('A', ['B', 'A'])]
current vertex is: D
current path is: ['B', 'D']

current stack after pop is: []
current vertex is: A
current path is: ['B', 'A']
graph[vertex] is: ['B', 'C']
set(path) is : {'B', 'A'}
next is : C
appended stack is: [('C', ['B', 'A', 'C'])]

current stack after pop is: []
current vertex is: C
current path is: ['B', 'A', 'C']
graph[vertex] is: ['A', 'F']
set(path) is : {'B', 'C', 'A'}
next is : F
DFS paths: [['B', 'E', 'F'], ['B', 'A', 'C', 'F']]
in the start the stack is: [('B', ['B'])]

current stack after pop is: []
current vertex is: B
current path is: ['B']
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B'}
next is : A
appended stack is: [('A', ['B', 'A'])]
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B'}
next is : D
appended stack is: [('A', ['B', 'A']), ('D', ['B', 'D'])]
graph[vertex] is: ['A', 'D', 'E']
set(path) is : {'B'}
next is : E
appended stack is: [('A', ['B', 'A']), ('D', ['B', 'D']), ('E', ['B', 'E'])]

current stack after pop is: [('A', ['B', 'A']), ('D', ['B', 'D'])]
current vertex is: E
current path is: ['B', 'E']
graph[vertex] is: ['B', 'F']
set(path) is : {'B', 'E'}
next is : F
shortest path: ['B', 'E', 'F']



'''

