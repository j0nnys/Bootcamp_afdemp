Python I Exercises

EXERCISE 1

Write a program that produces the following output:
000000001
000000022
000000333
000004444
000055555
000666666
007777777
088888888
999999999


EXERCISE 2

Write a program that asks the user to provide different numbers of banknotes and coins, from €50 to €1. Then output the total sum in euros. For example:
Enter number of 50 euro banknotes: 10
Enter number of 20 euro banknotes: 20
Enter number of 10 euro banknotes: 30
Enter number of 5 euro banknotes: 40
Enter number of 2 euro coins: 50
Enter number 1 euro coints: 60
You have 1560 euros.


EXERCISE 3

If we want to calculate the area of a triange given its sides, we can use Heron's formula, which is:
A=sqrt(1/4(a+b+c)(−a+b+c)(a−b+c)(a+b−c)
where  a,  b, and  c, are the three sides of the triangle. Write a program that asks the user for the three sides and calculates its area. 
Note that to calculate the square root in Python you have to include the line
import math
at the beginning of your program. Then, the square root of, say, r, is math.sqrt(r).
        
        
EXERCISE 4
        
A quadratic equation is an equation of the form:
ax^2+bx+c
ax^2+bx+c
 
The roots of a quadratic equation are given by the formula:
x=sqrt(−b±b2−4ac)/2a
Note that if  b2−4ac<0, then no real-valued solutions exist. Write a program that asks the user to enter values for  a,  b,  c, then prints the solutions of the quadratic equation they define, if they exist. 
If they do not exist, it should output an appropriate message.
        
        
EXERCISE 5
        
Write a program that calculates the first five terms of the harmonic sequence, that is, the numbers:
                                1
                              1+1/2
                            1+1/2+1/3
                          1+1/2+1/3+1/4
                        1+1/2+1/3+1/4+1/5
These are the numbers:
1
1.5
1.8333333333333333
2.083333333333333
2.283333333333333
        
        
EXERCISE 6
 
The first six triangular numbers are: 0, 1, 3, 6, 10, 15, 21. Their name comes from the fact that it is the number of objects that we must use to form an equilateral triangle. 
Write a program that asks the user the number of triangular numbers to produce, then prints them out:
Enter number of triangle numbers: 9
1 3 6 10 15 21 28 36 45
Enter number of triangle numbers: 15
1 3 6 10 15 21 28 36 45 55 66 78 91 105 120
Enter number of triangle numbers: 30
1 3 6 10 15 21 28 36 45 55 66 78 91 105 120 136 153 171 190 210 231 253 276 300 325 351 378 406 435 465
        
        
EXERCISE 7
        
The pronic numbers are those that are the product of two consecutive integers, so that they have the form  n(n+1). For example, the first six pronic numbers are:
1×2=2
2×3=6
3×4=12
4×5=20
5×6=30
6×7=42
Write a program that asks the user the number of pronic numbers to output, then goes on and prints them:
Enter number of pronic numbers: 10
2 6 12 20 30 42 56 72 90 110
