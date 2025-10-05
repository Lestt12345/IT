#1
#створення данних
pib=None
grupa=None
yo=None
gr_kr=None
#створення бази данних
student_info={"student1" : {"ПІБ студента" : pib, 
                            "група" : grupa, 
                            "вік" : yo, 
                            "група крові" : gr_kr}}
#введення даних
pib=str(input("Введіть ваш ПІБ\nУ форматі 'Прізвище Ім'я Побатькові'\nВаш ПІБ: "))
grupa=str(input("\n\nВведіть вашу групу\nУ форматі 'П32'\nВаша група: "))
yo=int(input("\n\nВведіть ваш вік\nУ форматі '32'\nВаш вік: "))
gr_kr=str(input("\n\nВведіть вашу групу крові\nУ форматі '1+' / '1-'\nВаша група крові: "))
#оновлення бази данних
student_info={"student1" : {"ПІБ студента" : pib, 
                            "група" : grupa, 
                            "вік" : yo, 
                            "група крові" : gr_kr}}
print(student_info["student1"])#це я для себе
#2
#перший варіант через готовий список
#створення данних
rand_numb_xd_1=None
rand_numb_xd_2=None
rand_numb_xd_3=None
rand_numb_xd_4=None
rand_numb_xd_5=None
rand_numb_xd_6=None
rand_numb_xd_7=None
rand_numb_xd_8=None
rand_numb_xd_9=None
rand_numb_xd_10=None
#створення бази данних
contacts_var1={"c1_1" : rand_numb_xd_1, 
               "c2_1" : rand_numb_xd_2, 
               "c3_1" : rand_numb_xd_3, 
               "c4_1" : rand_numb_xd_4, 
               "c5_1" : rand_numb_xd_5, 
               "c6_1" : rand_numb_xd_6, 
               "c7_1" : rand_numb_xd_7, 
               "c8_1" : rand_numb_xd_8, 
               "c9_1" : rand_numb_xd_9, 
               "c10_1" : rand_numb_xd_10}
#другий варіант через список без данних та з ручним вводом
#створення данних
cont1=None
cont2=None
cont3=None
cont4=None
cont5=None
cont6=None
cont7=None
cont8=None
cont9=None
cont10=None
#створення бази данних
contacts_var2={"c1_2" : cont1, 
               "c2_2" : cont2, 
               "c3_2" : cont3, 
               "c4_2" : cont4, 
               "c5_2" : cont5, 
               "c6_2" : cont6, 
               "c7_2" : cont7, 
               "c8_2" : cont8, 
               "c9_2" : cont9, 
               "c10_2" : cont10}
#введення даних
cont1=int(input("Введіть номер першого контакту у форматі '+380235710426': +"))#це рандомний номер XD
cont2=int(input("Введіть номер другого контакту у форматі '+380235710426': +"))
cont3=int(input("Введіть номер третього контакту у форматі '+380235710426': +"))
cont4=int(input("Введіть номер четвертого контакту у форматі '+380235710426': +"))
cont5=int(input("Введіть номер п'ятого контакту у форматі '+380235710426': +"))
cont6=int(input("Введіть номер шостого контакту у форматі '+380235710426': +"))
cont7=int(input("Введіть номер сьомого контакту у форматі '+380235710426': +"))
cont8=int(input("Введіть номер восьмого контакту у форматі '+380235710426': +"))
cont9=int(input("Введіть номер дев'ятого контакту у форматі '+380235710426': +"))
cont10=int(input("Введіть номер десятого контакту у форматі '+380235710426': +"))
#оновлення бази данних
contacts_var2={"c1_2" : cont1, 
               "c2_2" : cont2, 
               "c3_2" : cont3, 
               "c4_2" : cont4, 
               "c5_2" : cont5, 
               "c6_2" : cont6, 
               "c7_2" : cont7, 
               "c8_2" : cont8, 
               "c9_2" : cont9, 
               "c10_2" : cont10}
print(contacts_var2)#це я для себе