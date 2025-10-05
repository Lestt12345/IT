while(True):
    a=0
    b=0
    answ=int(input("1 - Додавання\n2 - Віднімання\n3 - Множення\n4 - Ділення\nОберіть дію: "))
    a=input(input("Введіть перше число: "))
    b=input(input("Введіть друге число: "))
    if answ==1:
        def sum(a, b):
            return a+b
        print(sum(a, b))
    elif answ==2:
        def otn(a, b):
            return a-b
        print(otn(a, b))
    elif answ==3:
        def umn(a, b):
            return a*b
        print(umn(a, b))
    elif answ==4:
        def dil(a, b):
            return a/b
        print(dil(a, b))
    else:
        print("error")








# # Інформація про студента

# # У студента запитують ПІБ, група, вік, група крові. Внести ці данні у словник за поданим прикладом.

# pib=None
# grupa=None
# yo=None
# gr_kr=None
# syudent_info={"student1" : {"ПІБ студента" : pib, "група" : grupa, "вік" : yo, "група крові" : gr_kr}}