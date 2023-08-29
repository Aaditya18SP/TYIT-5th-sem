#3 water jugs capacity -> (x,y,z) where x>y>0
#initial state (12,0,0)
#find state (6,6,0)

capacity=(12,8,5)
#minimum capacities of 3 jugs ->x,y,z

x=capacity[0]
y=capacity[1]
z=capacity[2]

#to mark visited states memory in a dictionary key value pair

memory={}

#store the solution path
ans=[]

def get_all_states(state):
    #Let the 3 jugs be calleed a,b,c
    a=state[0]
    b=state[1]
    c=state[2]

    if(a==6 and b==6):
        ans.append(state)
        return True

    #if current state is already visited earlier
    if((a,b,c) in memory):
        return False
    memory[(a,b,c)]=1

    #empty jug a
    if(a>0):
        #empty a into b
        if(a+b <=y):
            if(get_all_states((0,a+b,c)):
               ans.append(state)
               return True
        else:
            if(get_all_states((a-(y-b),y,c))):
                ans.append(state)
                return True
                
