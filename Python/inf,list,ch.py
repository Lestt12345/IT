import tkinter as tk
from tkinter import Listbox
root=tk.Tk()
lBox=Listbox(width=15, heigh=6, background="grey", foreground="black")
lBox.pack()
for i in ("Труди", "Укр. мова", "Геометрія", "Інформатика", "Хімія", "Заруб. літ."):
    lBox.insert(0, i)
root.mainloop()