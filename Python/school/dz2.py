students = [
    {'name': 'Petr', 'year': 2001},
    {'name': 'Ivan', 'year': 2002},
    {'name': 'Sergey', 'year': 2003},
    {'name': 'Olga', 'year': 2004},
    {'name': 'Andrey', 'year': 2005},
    {'name': 'Natalia', 'year': 2006},
    {'name': 'Nikolay', 'year': 2007},
    {'name': 'Margarita', 'year': 2008},
    {'name': 'Aleksandr', 'year': 2009},
    {'name': 'Irina', 'year': 2010}
]
for student in students:
    print(student['name'], student['year'])
print()

students.append({'name': 'Ekaterina', 'year': 2011})
for student in students:
    print(student['name'], student['year'])
print()

del students[0]
for student in students:
    print(student['name'], student['year'])
    
print([0])
print([1, 2, 3])