import random
import tkinter as tk
from tkinter import messagebox
#1
numbers = []
numbers_len=random.randint(1,10)
count_plus = 0
count_minus = 0
count_zero =0
print(f"Len: {numbers_len}")
for i in range(0, numbers_len):
    n = random.randint(-100, 100)
    numbers.append(n)
    if n>0:
        count_plus += 1
    elif n<0:
        count_minus += 1
    else:
        count_zero += 1
print(f"Додатних={count_plus}")
print(f"Від'ємних={count_minus}")
print(f"Рівних нулю={count_zero}")
print(f"Мінімальне число={min(numbers)}")
print(f"Максимальне число={max(numbers)}")


#2
a=0
b=0
do_ch=None
root=tk.Tk()

def plus():
    global do_ch
    do_ch="+"
    label_do.config(text="+")
def minus():
    global do_ch
    do_ch="-"
    label_do.config(text="-")
def mnosh():
    global do_ch
    do_ch="*"
    label_do.config(text="*")
def dil():
    global do_ch
    do_ch="/"
    label_do.config(text="/")

def resault():
    global do_ch
    a=entry_a.get()
    b=entry_b.get()
    if not a or not b:
            messagebox.showerror("error", "Перевірте чи ви додали значення")
    else:
        try:
            a=float(a)
            b=float(b)
        except:
            messagebox.showerror("error", "Перевірте чи значення є числовим")
        if a>=9999 or a<=(-9999) or b>=9999 or b<=(-9999):
            messagebox.showerror("error", "У якогось із значень забагато символів\nПриклад значення: 1234")
        else:
            if do_ch=="+":
                do=a+b
                label_answ.config(text=f"Відповідь: {do}")
            elif do_ch=="-":
                do=a-b
                label_answ.config(text=f"Відповідь: {do}")
            elif do_ch=="*":
                do=a*b
                label_answ.config(text=f"Відповідь: {do}")
            elif do_ch=="/":
                if b==0:
                    messagebox.showerror("error", "На 0 ділити не можна")
                else:
                    do=a/b
                    label_answ.config(text=f"Відповідь: {do}")
            else:
                messagebox.showerror("error", "Оберіть дію")


label=tk.Label(root, text="Оберіть дію:", font="Arial 18", foreground="black")

button_plus=tk.Button(root, text="Додавання +", command=plus)
button_minus=tk.Button(root, text="Віднімання - ", command=minus)
button_mnosh=tk.Button(root, text="Множення *  ", command=mnosh)
button_dil=tk.Button(root, text="Ділення /        ", command=dil)

label_space=tk.Label(root, text="", font="Arial 18", foreground="red")

entry_a=tk.Entry(root)
entry_b=tk.Entry(root)

label_do=tk.Label(root, text="Дію не обрано...", font="Arial 18", foreground="black")

label_answ=tk.Label(root, text=" ", font="Arial 18", foreground="black")

button_chek_answ=tk.Button(root, text="=", command=resault)


label.pack()

button_plus.pack()
button_minus.pack()
button_mnosh.pack()
button_dil.pack()

label_space.pack()
label_space.pack()
label_space.pack()

entry_a.pack()
label_do.pack()
entry_b.pack()

label_space.pack()
label_space.pack()

button_chek_answ.pack()

label_space.pack()

label_answ.pack()


root.geometry("500x500")
root.resizable(False, False)

root.mainloop()