import tkinter as tk
from tkinter import messagebox
import os
import time
root=tk.Tk()
def good():
    label.destroy()
    button.destroy()
    button2.destroy()
    label2.pack()
    ok.pack()
def not_good():
    label.destroy()
    button.destroy()
    button2.destroy()
    label3.pack()
    button3.pack()
def ok():
    root.destroy()
def shD():
    os.system("shutdown -s -t 00")
root.geometry("1600x900")
root.minsize(50, 50)
root.resizable(True, True)
label=tk.Label(root, text="Слава...", font="Arial 18", foreground="black")
button = tk.Button(root, text="Україні", command=good)
button2 = tk.Button(root, text="росії", command=not_good)
label2=tk.Label(root, text="Молодець", font="Arial 25", foreground="black")
button3 = tk.Button(root, text="Думаєш інакше?", command=shD)
ok = tk.Button(root, text="Ок", command=ok)
label3=tk.Label(root, text="Слава Україні!", font="Arial 25", foreground="black")
label.pack()
button.pack()
button2.pack()
root.mainloop()