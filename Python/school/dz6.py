import tkinter as tk
from tkinter import ttk

class Task:
    def __init__(self, title, status="Pending"):
        self.title = title
        self.status = status


class TaskManager:
    def __init__(self):
        self.tasks = []

    def add_task(self, title):
        task = Task(title)
        self.tasks.append(task)

    def update_status(self, index, new_status):
        if 0 <= index < len(self.tasks):
            self.tasks[index].status = new_status

    def get_tasks(self):
        return self.tasks


class TaskApp:
    def __init__(self, root):
        self.manager = TaskManager()

        root.title("Task Manager")
        root.geometry("450x300")
        root.resizable(False, False)

        self.entry = tk.Entry(root, width=40)
        self.entry.pack(pady=10)

        self.add_button = tk.Button(root, text="Add Task", command=self.add_task)
        self.add_button.pack()

        self.tree = ttk.Treeview(root, columns=("Status"), show="headings")
        self.tree.heading("Status", text="Status")
        self.tree.pack(fill="both", expand=True, pady=10)

        self.tree.bind("<Double-1>", self.change_status)

    def add_task(self):
        title = self.entry.get()
        if title.strip():
            self.manager.add_task(title)
            self.update_list()
            self.entry.delete(0, tk.END)

    def update_list(self):
        for row in self.tree.get_children():
            self.tree.delete(row)

        for i, task in enumerate(self.manager.get_tasks()):
            self.tree.insert("", "end", iid=i, values=(f"{task.title}  |  {task.status}",))

    def change_status(self, event):
        item_id = self.tree.focus()
        if item_id:
            index = int(item_id)
            task = self.manager.tasks[index]

            if task.status == "Pending":
                task.status = "In Progress"
            elif task.status == "In Progress":
                task.status = "Done"
            else:
                task.status = "Pending"

            self.update_list()


root = tk.Tk()
app = TaskApp(root)
root.mainloop()
