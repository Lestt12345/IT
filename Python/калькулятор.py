import math
while True:
  do = input("1-Ділення\n2-Множення\n3-Додавання\n4-Віднімання\n5-Сінус числа\n6-Косінус числа\n7-Перевести у степінь\nВиберіть дію: ")
  a = 0
  b = 0
  if do == "5":
    a = int(input("Введіть число: "))
    b = int(input("Введіть число: "))
  elif do == "6":
    a = int(input("Введіть число: "))
  elif do == "7":
    a = int(input("Введіть число: "))
    b = int(input("Введіть степінь: "))
  elif do == "2":
    a = int(input("Введіть перше число: "))
    b = int(input("Введіть друге число: "))
  elif (do == "1" and b == 0):
    a = int(input("Введіть перше число: "))
    b = int(input("Введіть друге число: "))
  elif do == "1":
    a = int(input("Введіть перше число: "))
    b = int(input("Введіть друге число: "))
  elif do == "3":
    a = int(input("Введіть перше число: "))
    b = int(input("Введіть друге число: "))
  elif do == "4":
    a = int(input("Введіть перше число: "))
    b = int(input("Введіть друге число: "))
  if do == "1" and a>=(-1000) and a<=1000 and b>=(-1000) and b<=1000:
    print (a/b)
  elif do == "2" and a>=(-1000) and a<=1000 and b>=(-1000) and b<=1000:
    print (a*b)
  elif do == "3" and a>=(-1000) and a<=1000 and b>=(-1000) and b<=1000:
    print (a+b)
  elif do == "4" and a>=(-1000) and a<=1000 and b>=(-1000) and b<=1000:
    print (a-b)
  elif do == "5" and a>=(-1000) and a<=1000:
    print (math.sin(a))
  elif do == "6" and a>=(-1000) and a<=1000:
    print (math.cos(a))
  elif do == "7" and a>=(-1000) and a<=1000 and b>=(-1000) and b<=1000:
    print (a**b)
  else:
    print ("error")