import tkinter as tk
root=tk.Tk()
root.geometry("600x600")
root.resizable(False, False)
root.configure(background="grey")
def destroy():
    root.destroy()
button_destroy=tk.Button(root, text="click🤡", font="Arial 20", foreground="black", background="red", command=destroy)
button_destroy.pack()
button_destroy.place(x=250, y=260)
root.mainloop()