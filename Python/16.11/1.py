#1
# masa=0
# total_masa=0
# for i in range(7):
#     masa=int(input("Введіть свою вагу: "))
#     if masa<0:
#         print ("Такої ваги не існує")
#         continue
#     else:
#         total_masa+=masa
#     if total_masa>=450:
#         print ("Ліфт *fall*")
#         break
#     elif total_masa>=350:
#         print ("Ліфт переповнений")
#         break
#     else:
#         print ("Проходьте")
#     if i==6:
#         print ("Ліфт переповнений")
#         break
ch=-1
while(ch!=0):
    ch=int(input("1 - +\n2 - -\n3 - *\n4 - /\n0 - Вихід\nОберіть варіант: "))
    if ch==1:
        a=int(input("Ведіть перше число: "))
        b=int(input("Ведіть друге число: "))
        print(f"{a} + {b} = {a+b}")
    elif ch==2:
        a=int(input("Ведіть перше число: "))
        b=int(input("Ведіть друге число: "))
        print(f"{a} - {b} = {a-b}")
    elif ch==3:
        a=int(input("Ведіть перше число: "))
        b=int(input("Ведіть друге число: "))
        print(f"{a} * {b} = {a*b}")
    elif ch==4:
        a=int(input("Ведіть перше число: "))
        b=int(input("Ведіть друге число: "))
        if b != 0:
            print(f"{a} / {b} = {a/b}")
        else:
            print("Ділення на нуль неможливе")
    elif ch==0:
        print ("bb")
        break
    else:
        print ("Такого варінту немає")
list_asd=[]
numb=-1
while numb!=0:
    numb=int(input("Введіть число (або напишіть '0' для завершення вводу чисел): "))
    if numb!=0:
        list_asd.append(numb)
for i in range(len(list_asd)):
    if i+1!=len(list_asd):
        print(list_asd[i], end=", ")
    else:
        print(list_asd[i], end=".\n")