"Parity Check"
binarynumber = input('Enter an 8-bit binary number: ')
binarynumber.split()
bn = [eval(x) for x in binarynumber]
count = 0
for i in range (0,8) :
    if  bn[i] == 1 :
        count += 1
if count % 2 == 0 :
    print("Parity check OK.")
else :
    print("Parity check not OK.")
