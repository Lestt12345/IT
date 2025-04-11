numbs = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

# Умова 1
even_numbs = [num for num in numbs if num % 2 == 0]
if even_numbs:
    print("Середнє значення парних чисел: ", sum(even_numbs) / len(even_numbs))
else:
    print("Парних чисел немає")

print()

# Умова 2
numb = int(input("Число: "))
if numbs.count(numb) > 0:
    print(f"Елемент зустрічається {numbs.count(numb)} разів")
else:
    print("Елемента немає")

print()

# Умова 3
print(numbs[::-1])

#ДЗ
print("\n\nДЗ\n")

# Задача 1
numbs1 = [15, 28, 33, 44, 56, 73]
print([num for num in numbs1 if num % 2 == 0])

print()

# Задача 2
numbs2 = [12, 5, 22, 7, 16, 3, 9]
print(f"Найбільше число: {max(numbs2)}\nНайменше число: {min(numbs2)}")

print()

# Задача 3
list1 = [0, 1, 2, 3, 4, 5]
list2 = [5, 6, 7, 8, 9, 10]
list3 = list1 + list2
print(list3)
