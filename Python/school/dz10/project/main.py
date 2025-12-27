import tkinter as tk
from tkinter import messagebox
from nu_tipa_databaseTedEdition_XD import SavingsAccount, CreditAccount, DepositAccount

class BankApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Bank System")

        # Створюємо рахунки
        self.accounts = {
            'Alice': SavingsAccount("Alice", 1000),
            'Bob': CreditAccount("Bob", 200),
            'Charlie': DepositAccount("Charlie", 5000)
        }

        # Основний фрейм для лівого блоку
        self.left_frame = tk.Frame(root)
        self.left_frame.grid(row=0, column=0, padx=20, pady=10, sticky='n')

        # Вибір рахунку
        tk.Label(self.left_frame, text="Select account:").grid(row=0, column=0, pady=5)
        self.selected_account = tk.StringVar(value='Alice')
        self.account_menu = tk.OptionMenu(self.left_frame, self.selected_account, *self.accounts.keys(), command=self.update_ui)
        self.account_menu.grid(row=0, column=1, pady=5)

        # Введення суми
        tk.Label(self.left_frame, text="Amount:").grid(row=1, column=0, pady=5)
        self.amount_entry = tk.Entry(self.left_frame)
        self.amount_entry.grid(row=1, column=1, pady=5)

        # Кнопки операцій
        self.buttons = {}
        self.buttons['deposit'] = tk.Button(self.left_frame, text="Deposit", command=self.deposit)
        self.buttons['deposit'].grid(row=2, column=0, pady=5)

        self.buttons['withdraw'] = tk.Button(self.left_frame, text="Withdraw", command=self.withdraw)
        self.buttons['withdraw'].grid(row=2, column=1, pady=5)

        self.buttons['interest'] = tk.Button(self.left_frame, text="Add Interest", command=self.add_interest)
        self.buttons['interest'].grid(row=3, column=0, pady=5)

        self.buttons['lock'] = tk.Button(self.left_frame, text="Lock/Unlock Deposit", command=self.toggle_deposit)
        self.buttons['lock'].grid(row=3, column=0, pady=5)

        # Правий блок для інформації
        self.right_frame = tk.Frame(root)
        self.right_frame.grid(row=0, column=1, padx=20, pady=10, sticky='n')

        # Тип рахунку
        self.account_type_label = tk.Label(self.right_frame, text="")
        self.account_type_label.grid(row=0, column=0, padx=10)

        # Баланс
        self.balance_label = tk.Label(self.right_frame, text="")
        self.balance_label.grid(row=1, column=0, padx=10)

        # Історія рахунку
        tk.Label(self.right_frame, text="Account History:").grid(row=2, column=0)
        self.history_text = tk.Text(self.right_frame, width=40, height=15, state='disabled')
        self.history_text.grid(row=3, column=0, rowspan=3, padx=10, pady=5)
        self.scrollbar = tk.Scrollbar(self.right_frame, command=self.history_text.yview)
        self.scrollbar.grid(row=3, column=1, rowspan=3, sticky='ns')
        self.history_text.config(yscrollcommand=self.scrollbar.set)

        self.update_ui('Alice')  # Початкове оновлення UI

    def get_account(self):
        return self.accounts[self.selected_account.get()]

    def update_ui(self, selected_name):
        account = self.get_account()
        self.account_type_label.config(text=f"Type: {account.account_type}")
        self.balance_label.config(text=f"Balance: {account.balance}$")

        # Оновлення історії
        self.history_text.config(state='normal')
        self.history_text.delete(1.0, tk.END)
        for action in account.last_actions[-20:]:
            self.history_text.insert(tk.END, action + "\n")
        self.history_text.config(state='disabled')

        # Сховати або показати кнопки залежно від типу рахунку
        if isinstance(account, SavingsAccount):
            self.buttons['interest'].grid()
        else:
            self.buttons['interest'].grid_remove()

        if isinstance(account, DepositAccount):
            self.buttons['lock'].grid()
        else:
            self.buttons['lock'].grid_remove()

    def update_history(self):
        account = self.get_account()
        self.history_text.config(state='normal')
        self.history_text.delete(1.0, tk.END)
        for action in account.last_actions[-20:]:
            self.history_text.insert(tk.END, action + "\n")
        self.history_text.config(state='disabled')
        self.history_text.see(tk.END)
        self.balance_label.config(text=f"Balance: {account.balance}$")  # оновлюємо баланс

    def deposit(self):
        account = self.get_account()
        try:
            amount = float(self.amount_entry.get())
            account.deposit(amount)
            self.update_history()
        except ValueError:
            messagebox.showerror("Error", "Enter a valid number")

    def withdraw(self):
        account = self.get_account()
        try:
            amount = float(self.amount_entry.get())
            account.withdraw(amount)
            self.update_history()
        except ValueError:
            messagebox.showerror("Error", "Enter a valid number")

    def add_interest(self):
        account = self.get_account()
        if isinstance(account, SavingsAccount):
            account.add_interest()
            self.update_history()

    def toggle_deposit(self):
        account = self.get_account()
        if isinstance(account, DepositAccount):
            if account.locked:
                account.unlock()
            else:
                account.lock()
            self.update_history()

    def show_balance(self):
        account = self.get_account()
        messagebox.showinfo("Balance", str(account))


root = tk.Tk()
root.resizable(False, False)
app = BankApp(root)
root.mainloop()
