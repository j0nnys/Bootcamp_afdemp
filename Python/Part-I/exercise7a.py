pronic_number = input('Enter number of pronic numbers:')
pn = int(pronic_number)
for i in range (1,pn+1):
    number=i*(i+1)
    print(number, end=' ')
