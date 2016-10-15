import math
year=int(input("Enter year: "))
if year in range (1900,2100):
    a = year % 4
    b = year % 7
    c = year % 19
    d = (19*c+15) % 30
    e = (2*a + 4*b - d + 34) % 7
    month = math.floor((d+e+114) // 31)
    day = (((d + e + 114) % 31) + 1) + 13
    if day > 30 :
        day = day % 30
        print("Day: ", day, "Month: ", month+1)
    else :
        print("Day: ", day, "Month: ", month)
else :
    print ("Wrong year")
