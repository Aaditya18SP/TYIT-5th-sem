import os
import time

board=[' ',' ',' ',' ',' ',' ',' ',' ',' ',' '] #10 elements

Win=1
Draw=-1
Running=0

Game=Running
player=1
Mark='X'

def checkPosition(x):
    if(board[x] != ' '):
        return False
    else:
        return True

def drawBoard():
    
    print("%c | %c | %c" % (board[1],board[2],board[3]))
    print("__|___|__")
    print("%c | %c | %c" % (board[4],board[5],board[6]))
    print("__|___|__")
    print("%c | %c | %c" % (board[7],board[8],board[9]))
    print("__|___|__")

def checkWin():
    #####VERY IMP####S
    global Game
    
    #horizontal conditions
    if(board[1] == board[2] and board[2]==board[3] and board[1]!=' '):
        Game=Win
    elif(board[4] == board[5] and board[5]==board[6] and board[4]!=' '):
        Game=Win
    elif(board[7] == board[8] and board[8]==board[9] and board[9]!=' '):
        Game=Win

    #Vertical Win Condition
    elif(board[1] == board[4] and board[4]==board[7] and board[1]!=' '):
        Game=Win
    elif(board[2] == board[5] and board[5]==board[8] and board[2]!=' '):
        Game=Win
    elif(board[3] == board[6] and board[6]==board[9] and board[9]!=' '):
        Game=Win
    #Diagonal Win Condition
    elif(board[1] == board[5] and board[5]==board[9] and board[1]!=' '):
        Game=Win
    elif(board[3] == board[5] and board[5]==board[7] and board[3]!=' '):
        Game=Win

    elif(board[1]!=' ' and board[2]!=' ' and board[3]!=' ' and board[4]!=' ' and board[5]!=' '  and board[6]!=' ' and board[7]!=' ' and board[8]!=' ' and board[9]!=' '):
        Game=Draw
    else:
        Game=Running
    
        

print("TIC TAC TOE GAME")
print()
print()

while(Game==Running):
    drawBoard()

    if(player%2 != 0):
        print("ABC's Chance")
        Mark='X'
    else:
        print("XYZ's chance")
        Mark='O'
    choice=int(input("Enter a position between [1-9]:"))
    if(checkPosition(choice)):
        board[choice]=Mark
        player+=1
        checkWin()

os.system('cls')
if(Game==Draw):
    print("Game Draw")
elif(Game==Win):
    player-=1

    if(player%2 !=0):
        print("ABC won")
    else:
        print("XYZ won")
        
    
