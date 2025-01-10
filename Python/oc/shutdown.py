import os
import tkinter as tk
import time
import threading
from threading import Thread
root=tk.Tk()
root.title("")
root.geometry(f"{1920}x{1080}+{0}+{0}")
root.configure(background="lightgray")
root.attributes('-fullscreen', True)

def on_enter(event):
    close_button.config(bg='#DC244C')

def on_leave(event):
    close_button.config(bg='gray')

def on_enter_c(event):
    cenel_button.config(bg='#DC244C')

def on_leave_c(event):
    cenel_button.config(bg='gray')

def close_window():
    exit
    root.destroy()

def on_enter_sh(event):
    label.config(bg='gray')

def on_leave_sh(event):
    label.config(bg='lightgray')

def on_enter_r(event):
    label1.config(bg='gray')

def on_leave_r(event):
    label1.config(bg='lightgray')

def on_enter_s(event):
    label2.config(bg='gray')

def on_leave_s(event):
    label2.config(bg='lightgray')

def sh(event):
    threading.Thread(target=shutdown, daemon=True).start()
def r(event):
    threading.Thread(target=restart, daemon=True).start()
def s(event):
    threading.Thread(target=sleep, daemon=True).start()
def shutdown():
    label.destroy()
    label1.destroy()
    label2.destroy()
    lab_shutdown.pack(pady=380)
    cenel_button.place(x=890, y=450)
    time.sleep(1)
    lab_shutdown.configure(text="Вимкнення через 2с.")
    time.sleep(1)
    lab_shutdown.configure(text="Вимкнення через 1с.")
    time.sleep(1)
    lab_shutdown.configure(text="Вимкнення через 0с.")
    time.sleep(1)
    lab_shutdown.configure(text="Вимкнення...")
    time.sleep(2)
    os.system('shutdown /s /f /t 0')
def restart():
    label.destroy()
    label1.destroy()
    label2.destroy()
    lab_restart.pack(pady=380)
    cenel_button.place(x=890, y=450)
    time.sleep(1)
    lab_restart.configure(text="Перезупаск через 2с.")
    time.sleep(1)
    lab_restart.configure(text="Перезупаск через 1с.")
    time.sleep(1)
    lab_restart.configure(text="Перезупаск через 0с.")
    time.sleep(1)
    lab_restart.configure(text="Перезупаск...")
    time.sleep(2)
    os.system('shutdown /r /f /t 0')
def sleep():
    label.destroy()
    label1.destroy()
    label2.destroy()
    lab_sleep.pack(pady=380)
    cenel_button.place(x=890, y=450)
    time.sleep(1)
    lab_sleep.configure(text="Перехід у режим сну через 2с.")
    time.sleep(1)
    lab_sleep.configure(text="Перехід у режим сну через 1с.")
    time.sleep(1)
    lab_sleep.configure(text="Перехід у режим сну через 0с.")
    time.sleep(1)
    lab_sleep.configure(text="Перехід у режим сну...")
    time.sleep(2)
    root.destroy()
    os.system('rundll32.exe powrprof.dll, SetSuspendState Sleep')

close_button = tk.Button(root, text=" × ", font=("Arial 20"), bg='gray', command=close_window, bd=0)
close_button.place(x=1868)

close_button.bind("<Enter>", on_enter)
close_button.bind("<Leave>", on_leave)

lab_shutdown=tk.Label(root, text="Вимкнення через 3с.", font="Arial 30", foreground="black", bg='lightgray')
lab_restart=tk.Label(root, text="Перезупаск через 3с.", font="Arial 30", foreground="black", bg='lightgray')
lab_sleep=tk.Label(root, text="Перехід у режим сну через 3с.", font="Arial 30", foreground="black", bg='lightgray')

cenel_button = tk.Button(root, text="Відміна", font=("Arial 25"), foreground="black", bg='gray', command=close_window, bd=0)

cenel_button.bind("<Enter>", on_enter_c)
cenel_button.bind("<Leave>", on_leave_c)

photo_shutdown = tk.PhotoImage(file="shutdown.gif")  # Укажите путь к файлу GIF
label = tk.Label(root, image=photo_shutdown, width=260, height=260, bg='lightgray')
label.place(x=500, y=360)
photo_restart = tk.PhotoImage(file="restart.gif")  # Укажите путь к файлу GIF
label1 = tk.Label(root, image=photo_restart, width=260, height=260, bg='lightgray')
label1.place(x=810, y=355)
photo_sleep = tk.PhotoImage(file="sleep.gif")  # Укажите путь к файлу GIF
label2 = tk.Label(root, image=photo_sleep, bg='lightgray')
label2.place(x=1100, y=335)

label.bind("<Enter>", on_enter_sh)
label.bind("<Leave>", on_leave_sh)
label.bind("<Button-1>", sh)

label1.bind("<Enter>", on_enter_r)
label1.bind("<Leave>", on_leave_r)
label1.bind("<Button-1>", r)

label2.bind("<Enter>", on_enter_s)
label2.bind("<Leave>", on_leave_s)
label2.bind("<Button-1>", s)

root.mainloop()