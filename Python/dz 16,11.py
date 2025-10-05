list_numbers_positiv=[]
list_numbers_notpositiv=[]

numb_of_numb_xd=int(input("Скільки ви хочете ввести чисел?: "))
for i in range (numb_of_numb_xd):
    numb=int(input("Введіть число (або напишіть '9999' для завершення вводу чисел): "))
    if numb==9999:
        break 
    elif numb==0:
        continue
    elif numb%2==0 and numb>0:
        list_numbers_positiv.append(numb)
    elif numb%2==0 and numb<0:
        list_numbers_notpositiv.append(numb)

print("Усі парні додатні числа:", end=" ")
if len(list_numbers_positiv)>0:
    for i in range (len(list_numbers_positiv)):
        if i+1==(len(list_numbers_positiv)):
            print(list_numbers_positiv[i])
        else:
            print(list_numbers_positiv[i], end=", ")
elif len(list_numbers_positiv)==0:
    print("Немає")

print("Усі парні від'ємні числа:", end=" ")
if len(list_numbers_notpositiv)>0:
    for i in range (len(list_numbers_notpositiv)):
        if i+1==(len(list_numbers_notpositiv)):
            print(list_numbers_notpositiv[i])
        else:
            print(list_numbers_notpositiv[i], end=", ")
elif len(list_numbers_notpositiv)==0:
    print("Немає")
#2
leap_year_list=[]
year=int(input("Введіть свій рік народження: "))
for i2 in range (year, 2023):
    if (i2%4==0 and i2%100!=0) or (i2%100==0 and i2%400==0):
        leap_year_list.append(i2)
print("Високосні роки які ви пережили:", end=" ")
for i in range (len(leap_year_list)):
    if i+1==(len(leap_year_list)):
        print(leap_year_list[i])
    else:
        print(leap_year_list[i], end=", ")