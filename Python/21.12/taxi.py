import tkinter as tk
import threading
from tkinter import messagebox
from tkinter import *
from threading import Thread
import time
root=tk.Tk()
root.geometry("1600x900")
root.minsize(50, 50)
root.resizable(True, True)
root.title("ya ne diziner xd")
range_in_kilometrs=float(5)#км це у данних водія
speed_in_kilometrsPerHour=float(60)#км/ч це у данних водія
speed_in_metrsPerSecond=float(speed_in_kilometrsPerHour*1000/3600)
range_in_meter=float(range_in_kilometrs*1000)
total_time_wait=float(range_in_meter/speed_in_metrsPerSecond)
minuts=int(total_time_wait/60)
seconds=int(100*(total_time_wait%60))

label_status_driver = tk.Label(root, text="Водій у дорозі\nПрибуття через:", font="Arial 18", foreground="black")
label_status_time = tk.Label(root, text=f"{minuts} хвилин {seconds} секунд", font="Arial 18", foreground="black")
label_status_range = tk.Label(root, text=f"Дистанція від вас {range_in_kilometrs}", font="Arial 18", foreground="black")

def strt():
    button_stsrt.destroy()
    label_status_driver.pack()
    label_status_time.pack()
    label_status_range.pack()
    global total_time_wait
    global range_in_meter
    for i in range(int(total_time_wait)):
        if total_time_wait==0:
            messagebox.showinfo("Прибуття", "Водій очікує вас...")
            break
        range_in_meter-=speed_in_metrsPerSecond
        total_time_wait-=1
        minuts = int(total_time_wait / 60)
        seconds = int((total_time_wait % 60))
        km = int(range_in_meter / 1000)
        m = int((range_in_meter % 1000))
        label_status_time.configure(text=(str(minuts))+" хвилин "+(str(seconds))+" секунд")
        label_status_range.configure(text=f"Дистанція від вас: "+str(km)+"км "+str(m)+"м")
        time.sleep(1)

def start():
    threading.Thread(target=strt, daemon=True).start()

button_stsrt=tk.Button(root, text="test", command=start)

button_stsrt.pack()

root.mainloop()



# why tkinter not дружит whith "loops" and "'time.sleep'"?, and не любить MY FREE TIME!!!!!!!!!!