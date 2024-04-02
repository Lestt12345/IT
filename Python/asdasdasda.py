import tkinter as tk
import threading
from tkinter import *
from threading import Thread
import time

root = tk.Tk()
root.geometry("1600x900")
root.minsize(50, 50)
root.resizable(True, True)
root.title("ya ne diziner xd")

range_in_kilometrs = float(5)
speed_in_kilometrsPerHour = float(60)
speed_in_metrsPerSecond = float(speed_in_kilometrsPerHour * 1000 / 3600)
range_in_meter = float(range_in_kilometrs * 1000)
total_time_wait = float(range_in_meter / speed_in_metrsPerSecond)
minuts = int(total_time_wait / 60)
seconds = int(100 * (total_time_wait % 60))

label_status_driver = tk.Label(root, text="Водій у дорозі\nПрибуття через:", font="Arial 18", foreground="black")
label_status_time = tk.Label(root, text=f"{minuts} хвилин {seconds} секунд", font="Arial 18", foreground="black")
label_status_range = tk.Label(root, text=f"Дистанція від вас {(range_in_meter/1000)}.{int(100*(range_in_meter%1000))}", font="Arial 18", foreground="black")

def strt():
    for i in range(999999):
    global total_time_wait
    global range_in_kilometrs
    global speed_in_kilometrsPerHour
    time.sleep(1)
    total_time_wait-=1
    minuts = int(total_time_wait / 60)
    seconds = int((total_time_wait % 60))
    label_status_time.configure(text=(str(minuts))+" хвилин "+(str(seconds))+" секунд")
    root.after(1000)

button_stsrt=tk.Button(root, text="test", command=strt)

button_stsrt.pack()
label_status_driver.pack()
label_status_time.pack()



root.mainloop()
