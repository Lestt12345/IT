# #1
# print("Привет!")
# name = input("Твоё имя: ")
# age = int(input("Твой возраст: "))
# print(f"Привет, {name}! Тебе {age} лет.")

# #2
# a = -1
# while(a != 0):
#     a = int(input("numb: "))
#     if (a == 0):
#         continue
#     elif (a % 2 == 0):
#         print("Это чётное число")
#     elif (a % 2 != 0):
#         print("Это нечётное число")

# #3
# def Max(List):
#     max = List[0]
#     for i in range(len(List)):
#         if (List[i] > max): max = List[i]
#     return max

# List = []
# for i in range(5):
#     List.append(int(input("numb: ")))
# print(f"\nmax: {Max(List)}")

#3
# a = input("line: ")
# for i in range(len(a)-1, -1, -1):
#     print(a[i], end='')
# vowels = ['a', 'e', 'i', 'o', 'u', 'y']
# vowels_count = 0
# for i in a:
#     if i in vowels: vowels_count+=1
# print(f"\nvolwes: {vowels_count}")

# #1
# a = input("line: ")
# from_right = ""
# for i in range(len(a)-1, -1, -1):
#     from_right = f"{from_right}{a[i]}"
# if a == from_right: print("true")
# else: print("false")

# /

# a = input("line: ")
# if a == a[::-1]:
#     print("true")
# else:
#     print("false")

# #2
# a = input("line: ")
# char_frequency = {}
# for i in a:
#     if i in char_frequency:
#         char_frequency[i] += 1
#     else:
#         char_frequency[i] = 1
# for char, freq in sorted(char_frequency.items()):
#     print(f"{char}: {freq}")

# #3
# a = input("line: ")
# text = a.replace(" ", "")
# print(text)

# /

# a = input("line: ")
# text = ''.join(a.split())
# print(text)

# /

# loop_count = int(input("count of loops: "))
# word = input("word: ")
# for i in range(loop_count):
#     print(word)