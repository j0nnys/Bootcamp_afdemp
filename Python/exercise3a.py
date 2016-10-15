import math

sidea = input('input side a:')
a = float(sidea)
sideb = input('input side b:')
b = float(sideb)
sidec = input('input side c:')
c = float(sidec)
embadon = (1/4)*math.sqrt((a+b+c)*(-a+b+c)*(a-b+c)*(a+b-c))                                                               
print('to embado tou trigwnou einai', embadon)  
