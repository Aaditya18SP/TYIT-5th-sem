#Approach1
import random
deck=[]
cardfaces=[]
royal_cards=['A','King','Queen','Jack']
all_card_types=['Spade','Diamond','Heart','Club']

for card_type in range(0,4):
    for cards in range(2,11):
        #append all the numbered cards
        cardfaces.append(str(cards) + " of " + all_card_types[card_type])

        #append all the royal cards
    for r_cards in royal_cards:
        cardfaces.append(r_cards + " of " + all_card_types[card_type])

random.shuffle(cardfaces)
deck=cardfaces
print(len(deck))

for m in range(52):
    print(deck[m])
    
'''OUTPUT
52
6 of Spade
8 of Heart
7 of Diamond
9 of Club
2 of Heart
2 of Club
9 of Heart
2 of Diamond
Jack of Heart
Queen of Club
6 of Heart
A of Diamond
Queen of Spade
5 of Heart
5 of Diamond
5 of Spade
8 of Diamond
Jack of Club
King of Heart
4 of Heart
2 of Spade
Jack of Spade
Jack of Diamond
6 of Club
4 of Diamond
5 of Club
3 of Heart
3 of Spade
10 of Club
3 of Club
A of Club
6 of Diamond
3 of Diamond
A of Spade
10 of Spade
King of Spade
8 of Spade
7 of Heart
Queen of Heart
8 of Club
7 of Club
Queen of Diamond
10 of Diamond
9 of Spade
4 of Spade
King of Club
King of Diamond
7 of Spade
10 of Heart
9 of Diamond
A of Heart
4 of Club
'''

#Approach 2


# import modules
import itertools, random
# make a deck of cards
deck = list(itertools.product(range(1,14),['Spade','Heart','Diamond','Club']))
# shuffle the cards
random.shuffle(deck)
# draw five cards
print("You got:")
for i in range(5):
    print(deck[i][0], "of", deck[i][1])

'''OUTPUT
You got:
4 of Club
13 of Spade
11 of Club
4 of Diamond
6 of Spade

'''
