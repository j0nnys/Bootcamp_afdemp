dn=input("Enter a 9-digit number: ")
dn.split()
dna = [eval(x) for x in dn]
for i in range (0,9,3) :
  print (dna[i], end='  ')
print("\n")
for i in range (1,9,3) :
  print ("", dna[i], end=' ')
print("\n")
for i in range (2,9,3) :
  print (" ", dna[i], end='')
