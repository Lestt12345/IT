import os
import tkinter as tk
from tkinter import filedialog

def get_directory_tree(start_path, indent=''):
    tree = ''
    for item in os.listdir(start_path):
        item_path = os.path.join(start_path, item)
        tree += indent + '|-- ' + item + '\n'
        if os.path.isdir(item_path):
            tree += get_directory_tree(item_path, indent + '    ')
    return tree

# Окно не отображается
root = tk.Tk()
root.withdraw()

# Выбор папки
folder_path = filedialog.askdirectory(title="Выберите папку")

if folder_path:
    result = f"Дерево директорий для: {folder_path}\n\n"
    result += get_directory_tree(folder_path)

    # Сохранение в файл
    save_path = os.path.join(folder_path, "C:\IT\directory_tree.txt")
    with open(save_path, 'w', encoding='utf-8') as f:
        f.write(result)

    print(f"Дерево директорий сохранено в файл:\n{save_path}")
else:
    print("Папка не выбрана.")
