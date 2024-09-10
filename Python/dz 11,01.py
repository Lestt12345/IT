import random
# небольшой тест чтоб вспомнить как он всё работает
# list1=[]
# list2=[]
# for i in range(10):
#     rand_numb=random.randint(1,10)
#     list1.append(rand_numb)
#     rand_numb=random.randint(1,10)
#     list2.append(rand_numb)
# test=list(set(list1))
# print(list1)
# print(test)
# print(list2)
# print(list(set(list2)))
# print(set(list2))
# print(set(list1)&set(list2))
# !!! print(list1&list2)  !!!
list1=[]
list2=[]
for i in range(10):
    rand_numb=random.randint(1,10)
    list1.append(rand_numb)
    rand_numb=random.randint(1,10)
    list2.append(rand_numb)


combo_list=list1+list2
combo_withoutCopy_list=list(set(combo_list))
general_list=list(set(list1)&set(list2))
combo_withoutCopy_list1=list(set(list1))
combo_withoutCopy_list2=list(set(list2))
minMax_list1=min(list1), max(list1)
minMax_list2=min(list2), max(list2)


print("елементи обох списків:", end=" ")
for i in range (len(combo_list)):
    if i+1==len(combo_list):
        print(combo_list[i])
    else:
        print(combo_list[i], end=", ")

print("елементи обох списків без повторень:", end=" ")
for i in range (len(combo_withoutCopy_list)):
    if i+1==len(combo_withoutCopy_list):
        print(combo_withoutCopy_list[i])
    else:
        print(combo_withoutCopy_list[i], end=", ")

print("елементи, спільні для двох списків:", end=" ")
for i in range (len(general_list)):
    if i+1==len(general_list):
        print(general_list[i])
    else:
        print(general_list[i], end=", ")

print("тільки унікальні елементи кожного зі списків:")
print("list1:", end=" ")
for i in range (len(combo_withoutCopy_list1)):
    if i+1==len(combo_withoutCopy_list1):
        print(combo_withoutCopy_list1[i])
    else:
        print(combo_withoutCopy_list1[i], end=", ")
print("list2:", end=" ")
for i in range (len(combo_withoutCopy_list2)):
    if i+1==len(combo_withoutCopy_list2):
        print(combo_withoutCopy_list2[i])
    else:
        print(combo_withoutCopy_list2[i], end=", ")

print("тільки мінімальне та максимальне значення кожного зі списків:")
print("list1:", end=" ")
for i in range (len(minMax_list1)):
    if i+1==len(minMax_list1):
        print(minMax_list1[i])
    else:
        print(minMax_list1[i], end=", ")
print("list2:", end=" ")
for i in range (len(minMax_list2)):
    if i+1==len(minMax_list2):
        print(minMax_list2[i])
    else:
        print(minMax_list2[i], end=", ")