male(aaditya).
male(atharva).
male(sheel).
male(jayant).
male(rameshwar).
female(jamuna).
female(anu).
female(sunitaj).
female(sunitas).

child(aaditya).
child(atharva).
child(anu).
child(sheel).
child(jayant).

parent(sheel,sunitas):-child(aaditya).
parent(jayant,sunitaj):-child(atharva),child(anu).
parent(rameshwar,jamuna):-child(sheel),child(jayant).


father(Fname):- parent(Fname,X),male(Fname).
mother(Mname):-parent(X,Mname),female(Mname).


