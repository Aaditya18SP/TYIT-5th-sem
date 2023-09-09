male(aaditya).
male(aman).
male(atharva).
male(sheel).
male(jayant).
male(indra).
male(shiv).
male(rameshwar).
male(amar).
female(amarwife).
female(jamuna).
female(sunitai).
female(sheela).
female(sunitas).
female(sunitaj).
female(diksha).
female(sakshi).
female(akansha).
female(aditi).
female(anu).

parents(sheel,sunitas):-child(aaditya).
parents(jayant,sunitaj):-child(anu,atharva).
parents(indra,sunitai):-child(aman).
parents(shiv,sheela):-child(diksha,sakshi,aditi,akansha).
parents(rameshwar,jamuna):-child(sheel,jayant,sunitai,sheela).
parents(amar,amarwife):-child(rameshwar).

father(Fname):- parents(Fname,X).
mother(Mname):-parents(X,Mname).

