tasks = []

while True:
    print("Менеджер списку задач")
    print("1. Переглянути задачі")
    print("2. Додати задачу")
    print("3. Видалити задачу")
    print("4. Вийти")
    choice = input("\nОберіть опцію: ")
    print()
    
    if choice == "1":
        if not tasks:
            print("Ваш список задач порожній.\n")
        else:
            print("\nВаші задачі:")
            for i in range(len(tasks)):
                print(f"{i+1}. {tasks[i]}")
            print()
    
    elif choice == "2":
        tasks.append(input("Введіть задачу: "))
        print("Задачу додано!\n")
    
    elif choice == "3":
        if not tasks:
            print("Ваш список задач порожній. Немає чого видаляти.\n")
        else:
            print("\nВаші задачі:")
            for i in range(len(tasks)):
                print(f"{i+1}. {tasks[i]}")
            print()
            task_number = int(input("Введіть номер задачі для видалення: "))
            if 0 < task_number <= len(tasks):
                print(f"Задачу '{tasks.pop(task_number - 1)}' видалено!\n")
            else:
                print("Невірний номер задачі.\n")
    
    elif choice == "4":
        print("До побачення!")
        break
    
    else:
        print("Невірний вибір. Спробуйте ще раз.\n")
