import tkinter as tk
from tkinter import messagebox
from tkinter import font
root=tk.Tk()
def show_message():
    user_input=entry.get()
    message=f"Привіт, радий тебе знов бачити {user_input}"
    if user_input:
        messagebox.showinfo("Сюда", message)
    else:
        messagebox.showerror("Error", "Error")
root.geometry("1920x1200")
root.minsize(50, 50)
root.resizable(True, True)
root.title("☭ vs 卐")
label=tk.Label(root, text="Введідть своє ім'я", font="Arial 18", foreground="black")
entry=tk.Entry(root)
button=tk.Button(root, text="ОК", command=show_message)
label.pack()
entry.pack()
button.pack()
root.mainloop()