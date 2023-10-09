import math
class State():
    
    def __init__(self,cl,ml,boat,cr,mr):
        self.cl=cl
        self.ml=ml
        self.cr=cr
        self.mr=mr
        self.boat=boat
        self.parent=None

    def is_goal(self):
        if self.cl == 0 and self.ml == 0:
            return True
        else:
            return False
    def is_valid(self):
        if self.cl >= 0 and self.ml >= 0 and self.cr >= 0 and self.mr >=0 and (self.ml ==0 or self.ml >= self.cl) and (self.mr ==0 or self.mr >=self.cr):
            return True
        else:
            return False


def successors(cur_state):
    children = []
    if cur_state.boat == 'left':
        ## Two missionaries cross left to right.
        new_state = State(cur_state.cl, cur_state.ml - 2, 'right', cur_state.cr, cur_state.mr + 2)
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)

        ## Two cannibals cross left to right.
        new_state = State(cur_state.cl - 2, cur_state.ml, 'right', cur_state.cr + 2, cur_state.mr)
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
            
        ## One missionary and one cannibal cross left to right.
        new_state = State(cur_state.cl - 1, cur_state.ml - 1, 'right', cur_state.cr + 1, cur_state.mr + 1)
        
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
            
        ## One missionary crosses left to right.
        new_state = State(cur_state.cl, cur_state.ml - 1, 'right',cur_state.cr, cur_state.mr + 1)
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
        
        ## One cannibal crosses left to right
        new_state = State(cur_state.cl - 1, cur_state.ml, 'right',  cur_state.cr + 1, cur_state.mr)
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
    else:
        #CROSSING FROM RIGHT TO LEFT
         ## Two missionaries cross right to left.
        new_state = State(cur_state.cl, cur_state.ml + 2, 'left',  cur_state.cr, cur_state.mr - 2)
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
        new_state = State(cur_state.cl + 2, cur_state.ml, 'left',  cur_state.cr - 2, cur_state.mr)
        ## Two cannibals cross right to left.
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
        new_state = State(cur_state.cl + 1, cur_state.ml + 1, 'left',  cur_state.cr - 1, cur_state.mr - 1)
        ## One missionary and one cannibal cross right to left.
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
        new_state = State(cur_state.cl, cur_state.ml + 1, 'left',  cur_state.cr, cur_state.mr - 1)
        ## One missionary crosses right to left.
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
        new_state = State(cur_state.cl + 1, cur_state.ml, 'left',cur_state.cr - 1, cur_state.mr)
        ## One cannibal crosses right to left.
        if new_state.is_valid():
            new_state.parent = cur_state
            children.append(new_state)
    return children

def bfs_find_only_solution():
    initial_state = State(3,3,'left',0,0)
    if initial_state.is_goal():
        return initial_state
    frontier = list()
    explored = set()
    frontier.append(initial_state)
    while len(frontier)>0:
        state = frontier.pop(0)
        #print(len(frontier))
        if state.is_goal():
            return state
        explored.add(state)
        children = successors(state)
        for child in children:
            if (child not in explored) or (child not in frontier):
                frontier.append(child)
    return None
    '''
    explored=set()
    frontier=list()

    initial_state=State(3,3,'left',0,0)
    frontier.append(initial_state)

    #print("in bfs, frontier:", frontier.pop(0).cl)
    while frontier:
        curr_state=frontier.pop(0)
        #print("in bfs, curr_state:", curr_state.cl)
        print("in bfs, frontier length:" ,len(frontier))
        if curr_state.is_goal():
            return curr_state

        explored.add(curr_state)

        children=successors(curr_state)
        for child in children:
            if (child not in explored) or (child not in frontier):
                frontier.append(child)
    return None
    '''

def print_solution(goal_node):
    path = []
    path.append(goal_node)
    parent = goal_node.parent
    while parent:
        path.append(parent)
        parent = parent.parent

    for t in range(len(path)):
        state = path[len(path) - t - 1]
        print ("(" + str(state.cl) + "," + str(state.ml)  + "," + state.boat + "," + str(state.cr) + "," +   str(state.mr) + ")")


    '''
    path=[]
    path.append(goal_node)

    parent=goal_node.parent

    while parent:
        print("in print_solution")
        path.append(parent)
        parent=parent.parent

    for i in range(len(path)):

        #print path in reverse
        state=path[len(path)-i-1]
        print(str(state.cl)," ", str(state.ml)," ",state.boat," ",str(state.cr)," ",str(state.mr) )
'''
def execute_main():
    
    goal_node= bfs_find_only_solution()
    print(goal_node)

    print("The solution is....")
    print_solution(goal_node)
    
    children= successors(State(3,3,'left',0,0))
    for child in children:
        print(child.is_goal())
        print(child.cl, child.ml,child.boat,child.mr,child.cr)
        

if __name__ == "__main__":
    execute_main()
    
execute_main()
        
