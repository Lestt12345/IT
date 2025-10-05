#1
sum=0
for i in range (1,1001):
    if i%3==0 or i%5==0:
        sum+=i
print (sum)
#2
numb=int(input("Введіть число: "))
if numb>0:
    for i2 in range (0,numb+1):
        print (i2)
elif numb<0:
    for i2 in range (0,numb-1,-1):
        print (i2)
#3 те що не зміг на уроці зробити через for не знаю як робити, 'Денис' на тексті не заходить але кількість людей поповнюється на 1, напевно зрозуміло пояснив)
people2=0
while people2<10:
    people=str(input("Введіть своє ім'я: "))
    if people=="Денис":
        print ("Вам туди не можна")
    elif people2==9:
        print ("Проходьте\n*Ліфт заповнений*")
        people2+=1
    else:
        print ("Проходьте")
        people2+=1
