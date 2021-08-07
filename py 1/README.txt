Hello Marker!

I have attached 3 different Assignments. I got resonably far with the third part of the Assignment but couldn't finish it after days of trying. The first
one is just Assignment1 Question 1. It is a recursive backtracking suduko solver without any pruning. The second one is Assignment 1 Question 1 & 2. It is
a recursive backtracking suduko solver that also completes 'simpletons'. Lastly is Assignment 1 Question 1, 2, and an attempt at 3. It is a recursive
backtracking suduko solver that completes 'simpletons' and tries to complete 'doubles'.

A double is what I name two unsolved cells in the same row or column and different blocks that only have two possible options, that also share an option. 
This means that I can test for when a double occurs and solve it as long as one of the cells' rows or columns contains the other cells' different number

Take the following Suduko blocks (top three blocks);

5 0 0 | 0 0 2 | 0 8 9         The middle row has three unsolved cells. If I take the left and right cells they have two possible values; 2 & 7 and 2 & 4.
0 3 9 | 1 8 0 | 0 6 5         This means I one equal to the common number and the other equal to the remaining. I do realise now, when I write this out 
4 0 0 | 0 5 0 | 7 1 2         at 10:55PM why it's not working but I don't have time to fix it. I hope the attempt will gain some marks. Thanks :)