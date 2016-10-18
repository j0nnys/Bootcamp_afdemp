tin = input('Enter Tax identification number: ')
tin.split()
tina = [eval(x) for x in tin]
for i in range (0,10):
    tina_reversed = str(tina)[::-1]
    x1 = tina[1]*2**1
    x2 = tina[2]*2**2
    x3 = tina[3]*2**3
    x4 = tina[4]*2**4
    x5 = tina[5]*2**5
    x6 = tina[6]*2**6
    x7 = tina[7]*2**7
    x8 = tina[8]*2**8
    sum = x1 + x2 + x3 + x4 +x5 + x6 + x7 + x8
    remainder = sum%11
    remainderb = remainder%10
if remainderb == tina[0]:
    print('Tax Identification Number valid.')
else:
    print('Tax Identification Number not valid.')
