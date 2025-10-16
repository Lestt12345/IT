#CW
#1
arr1 = []
ch = -1
while ch != 0:
    ch = int(input("Введіть число(або 0 для завершення): "))
    if ch != 0:
        arr1.append(ch)
ind = int(input("Введіть індекс: "))
swapFor = int(input("Введіть число для заміни: "))
arr1[ind] = swapFor
print(f"Елемент за індексом {ind} було замінений на {swapFor}")
print(arr1)

print()

#2
arr2 = [1, 2, 3]
editedToZero = 0
print(arr2)
for i in range(len(arr2)):
    if arr2[i] == 2:
        arr2[i] = 0
        editedToZero += 1
print(f"Кількість змінених елементів: {editedToZero}")
print(arr2)

print()

#3
arr3 = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]
swapCount = 0
for i in range(len(arr3)):
    for j in range(len(arr3[i])):
        if i == j:
            arr3[i][j] = 0
            swapCount += 1
for i in range(len(arr3)):
    print(arr3[i])
print(f"Кількість змінених елементів: {swapCount}")

print()


#HW
#4
arr4 = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]
sum_dig_el = 0
for i in range(len(arr4)):
    for j in range(len(arr4[i])):
        if i == j:
            sum_dig_el += arr4[i][j]
print(sum_dig_el)