triangle = input('Enter number of triangle numbers:')
tr = int(triangle)
for i in range (1,tr+1):
    number=(i*(i+1))/2
    print(number, end=' ')
