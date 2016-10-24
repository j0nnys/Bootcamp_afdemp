sequence = input('Enter a binary sequence: ')
sequence.split()
b = [eval(x) for x in sequence]
count0 = 0
count1 = 0
for i in range (0,len(sequence)) :
    if  b[i] == 1 :
        count1 += 1
    else :
        count0 += 1
if count1 > count0 :
    print('Longest run was ones with length:', count1)
elif count1 < count0 :
    print('Longest run was zeros with length:', count0)
else :
    print('Equal longest run of ones and zeros with length:', count0)
