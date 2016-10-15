import math

av = input('Enter value for a:')
a = float(av)
bv = input('Enter value for b:')
b = float(bv)
cv = input('Enter value for c:')
c = float(cv)
if b**2-4*a*c>0 :
    arithm=math.sqrt((b**2)-(4*a*c))
    arithm2=math.sqrt((b**2)-(4*a*c))
    
    x1=-b+arithm/(2*a)
    x2=-b-arithm2/(2*a)
    print('to x1 einai:',x1, 'kai to x2 einai:',x2)
else:
    print('The value for x1 and x2 is not defined')
