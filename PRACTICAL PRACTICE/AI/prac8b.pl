adjacent(1,2).
adjacent(2,1).
adjacent(1,3).
adjacent(3,1).
adjacent(1,4).
adjacent(4,1).
adjacent(1,5).
adjacent(5,1).

adjacent(2,3).
adjacent(3,2).
adjacent(2,4).
adjacent(4,2).
adjacent(2,5).
adjacent(5,2).

adjacent(3,4).
adjacent(4,3).
adjacent(3,5).
adjacent(5,3).
-
adjacent(4,5).
adjacent(5,4).

color(1,orange,x).
color(1,orange,y).

color(2,red,x).
color(2,red,y).

color(3,pink,x).
color(3,pink,y).

color(4,grey,x).
color(4,red,y).

color(5,purple,x).
color(5,purple,y).


conflict(R1,R2,Colorscheme):-
adjacent(R1,R2),color(R1,Color,Colorscheme),color(R2,Color,Colorscheme).

