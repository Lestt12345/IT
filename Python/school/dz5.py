#1
def ParnNumb(arr):
    res = []
    for i in range(len(arr)):
        if arr[i] % 2 == 0:
            res.append(arr[i])
    return res

arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(ParnNumb(arr))

#2
def SerArif(arr):
    res = 0
    for i in range(len(arr)):
        res += arr[i]
    return res / len(arr)

arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(SerArif(arr))

#3
def FilterArr(arr, num):
    res = arr
    for i in res:
        if i == num:
            res.remove(i)
    return res

arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(FilterArr(arr, 3))
