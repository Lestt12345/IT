#1
masa=0
total_masa=0
for i in range(7):
    masa=int(input("Введіть свою вагу: "))
    if masa<0:
        print ("Такої ваги не існує")
        continue
    else:
        total_masa+=masa
    if total_masa>=450:
        print ("Ліфт *fall*")
        break
    elif total_masa>=350:
        print ("Ліфт переповнений")
        break
    else:
        print ("Проходьте")
    if i==6:
        print ("Ліфт переповнений")