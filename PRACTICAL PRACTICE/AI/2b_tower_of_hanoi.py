
def moveToTower(num_of_discs,frompole,withpole,topole):
    if(num_of_discs > 0):
        #print(num_of_discs)
        moveToTower(num_of_discs -1,frompole,topole,withpole)
        moving(num_of_discs,frompole,topole)
        moveToTower(num_of_discs - 1,withpole,frompole,topole)

def moving(num,fp,tp):
    print("moving ", num,"the discs from ",fp," to",tp)
    #here num is the disc no and not number of discs
    
moveToTower(3,"A","B","C")
