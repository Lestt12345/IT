from ast import Delete
import tkinter as tk
from tkinter import messagebox
from tkinter import font
root=tk.Tk()
def show_message():
    user_login=entry_login.get()
    user_password=entry_pass.get()
    user_password_chek=entry_pass2.get()
    user_email=entry_email.get()
    message=f"Реєстрація успішна, вітаємо {user_login}!"
    if user_login and user_password and user_password_chek and user_password==user_password_chek:
        messagebox.showinfo("Login", message)
    else:
        messagebox.showerror("Error", "Перевірте чи правильно ви все ввели.")
def delete_form():
    entry_login.delete(0,999)
    entry_pass.delete(0,999)
    entry_pass2.delete(0,999)
    entry_email.delete(0,999)
root.geometry("1600x900")
root.minsize(50, 50)
root.resizable(True, True)
root.title("Logo")
label_login=tk.Label(root, text="Введідть логін", font="Arial 18", foreground="black")
entry_login=tk.Entry(root)
label_pass=tk.Label(root, text="Введідть пароль", font="Arial 18", foreground="black")
entry_pass=tk.Entry(root)
label_pass2=tk.Label(root, text="Введідть пароль повторно", font="Arial 18", foreground="black")
entry_pass2=tk.Entry(root)
label_email=tk.Label(root, text="Введідть email (не обов'язково)", font="Arial 18", foreground="black")
entry_email=tk.Entry(root)
button=tk.Button(root, text="Login", command=show_message)
button_reset=tk.Button(root, text="Reset", command=delete_form)
label_login.pack()
entry_login.pack()
label_pass.pack()
entry_pass.pack()
label_pass2.pack()
entry_pass2.pack()
label_email.pack()
entry_email.pack()
button_reset.pack()
button.pack()
root.iconbitmap("30,11\sd.ico")
root.mainloop()