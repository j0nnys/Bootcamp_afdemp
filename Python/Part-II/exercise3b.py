dn=input("Enter a 10-digit number: ")
dn.split()
dna = [eval(x) for x in dn]
for i in range (0,10) :
    if i % 2 == 0 :
        print (dna[i], end=' ')
print("\n")
for i in range (0,10) :
    if i % 2 != 0 :
        print ("", dna[i], end='')
