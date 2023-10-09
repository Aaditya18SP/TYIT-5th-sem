from math import *
x={}
n=int(4)
def clear_block(k):
    for i in range(k,n+1):
        x[i]=None
        
def place(k,i):
    if(i in x.values()):
        return False
    j=1
    while(j<k):
        if abs(x[j]-i)==abs(j-k):
            return False
        j+=1
    return True

def NQueens(k):
    for i in range(1,n+1):
        clear_block(k)
        if place(k,i):
            x[k]=i
            if(k==n):
                for j in x:
                    print(x[j],end='')
                print()
                print()
                print('------')
            else:
                NQueens(k+1)
            
NQueens(1)
