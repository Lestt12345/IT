import tkinter as tk
from tkinter import messagebox
import random
root=tk.Tk()
r_numb=random.randint(1,10)
tries=0
def show_message():
    numb=entry.get()
    message_correct=f"Ти вгадав! Це було число: {r_numb}"
    message_incorrect_bigger=f"Ти не вгадав, число більше."
    message_incorrect_smaller=f"Ти не вгадав, число менше."
    message_incorrect_numbNotInDiapason=f"Число повинно бути в діапазоні від 1 до 10."
    message_incorrect_noneInf=f"Поле не може бути пустим."
    if int(numb)==r_numb:
        messagebox.showinfo("Correct", message_correct)
    elif int(numb)<1 or int(numb)>10:
        messagebox.showerror("Error", message_incorrect_numbNotInDiapason)
    elif int(numb)>r_numb:
        messagebox.showwarning("I know you can", message_incorrect_smaller)
    elif int(numb)<r_numb:
        messagebox.showwarning("I know you can", message_incorrect_bigger)
    else:
        messagebox.showerror("error", "Error")
root.geometry("1600x900")
root.minsize(50, 50)
root.resizable(True, True)
root.title("Chek your luck xd")
label=tk.Label(root, text="Введідть число", font="Arial 18", foreground="black")
entry=tk.Entry(root)
button = tk.Button(root, text="Click me", command=show_message)
label.pack()
entry.pack()
button.pack()
root.iconbitmap("perspective-dice-random-icon-469x512-mm6xb9so.ico")
root.mainloop()