class BankAccount:
    def __init__(self, owner, account_type, balance=0):
        self.owner = owner
        self.account_type = account_type
        self.balance = balance
        self.last_actions = ["account created"]

    def deposit(self, amount):
        if amount > 0:
            self.balance += amount
            response = f"{self.owner} deposited {amount}$"
            self.last_actions.append(response)
            return response
        else:
            response = "Deposit amount must be positive"
            self.last_actions.append(response)
            return response

    def withdraw(self, amount):
        if amount > 0 and amount <= self.balance:
            self.balance -= amount
            response = f"{self.owner} withdrew {amount}$"
            self.last_actions.append(response)
            return response
        else:
            response = "Insufficient funds or invalid amount"
            self.last_actions.append(response)
            return response

    def __str__(self):
        return f"{self.owner}'s {self.account_type} account: {self.balance}$"

class SavingsAccount(BankAccount):
    def __init__(self, owner, balance=0, interest_rate=0.03):
        super().__init__(owner, 'saving', balance)
        self.interest_rate = interest_rate
        self.last_actions = [f"account type is {self.account_type} ({self.interest_rate * 100}% interest rate)"]

    def withdraw(self, amount):
        if amount > 0 and amount <= self.balance:
            self.balance -= amount
            response = f"{self.owner} withdrew {amount}$ from savings account"
            self.last_actions.append(response)
            return response
        else:
            response = "Cannot withdraw: insufficient funds in savings account"
            self.last_actions.append(response)
            return response

    def add_interest(self):
        interest = self.balance * self.interest_rate
        self.balance += interest
        response = f"{self.owner} earned {interest}$ interest"
        self.last_actions.append(response)
        return response

class CreditAccount(BankAccount):
    def __init__(self, owner, balance=0, credit_limit=1000):
        super().__init__(owner, 'credit', balance)
        self.credit_limit = credit_limit
        self.last_actions = [f"account type is {self.account_type} ({self.credit_limit}$ credit limit)"]

    def withdraw(self, amount):
        if amount <= self.balance + self.credit_limit:
            self.balance -= amount
            response = f"{self.owner} withdrew {amount}$ from credit account"
            self.last_actions.append(response)
            return response
        else:
            response = "Exceeded credit limit"
            self.last_actions.append(response)
            return response

class DepositAccount(BankAccount):
    def __init__(self, owner, balance=0, term_months=12):
        super().__init__(owner, 'deposit', balance)
        self.term_months = term_months
        self.locked = False
        self.last_actions = [f"account type is {self.account_type} ({self.term_months} months term)"]

    def withdraw(self, amount):
        if self.locked:
            response = "Cannot withdraw: deposit account is locked"
            self.last_actions.append(response)
            return response
        elif amount <= self.balance:
            self.balance -= amount
            response = f"{self.owner} withdrew {amount}$ from deposit account"
            self.last_actions.append(response)
            return response
        else:
            response = "Insufficient funds"
            self.last_actions.append(response)
            return response

    def lock(self):
        self.locked = True
        response = f"{self.owner}'s deposit account is now locked"
        self.last_actions.append(response)
        return response

    def unlock(self):
        self.locked = False
        response = f"{self.owner}'s deposit account is now unlocked"
        self.last_actions.append(response)
        return response