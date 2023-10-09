import random
suites=['clubs','hearts','diamond','spade']

royal_cards=['A','King','Queen','Jack']
deck=[]
card_faces=[]
for suite in suites:

    for i in range(2,11):
        card_faces.append([i, suite])

    for royal in royal_cards:
        card_faces.append([royal,suite])

print(len(card_faces))
random.shuffle(card_faces)
deck=card_faces
print(len(deck))

for i in deck:
    print(i)
