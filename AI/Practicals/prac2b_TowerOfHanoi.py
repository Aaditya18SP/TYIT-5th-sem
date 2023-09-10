def moveTower(height, frompole, topole, withpole):
    if height>0:
        moveTower(height-1,frompole,withpole,topole)
        moveDisk(frompole,topole)
        moveTower(height-1, withpole,topole,frompole)

def moveDisk(fp,tp):
    print("moving disk from ",fp ,"to ",tp)

moveTower(3,"A","B","C") #moving from A to B using C

'''OUTPUT 
moving disk from  A to  B
moving disk from  A to  C
moving disk from  B to  C
moving disk from  A to  B
moving disk from  C to  A
moving disk from  C to  B
moving disk from  A to  B
'''
