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

#random.shuffle(cardfaces)
deck=cardfaces
print(len(deck))

for m in range(52):
    print(deck[m])
    

