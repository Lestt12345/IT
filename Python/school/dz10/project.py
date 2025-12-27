class BankAccount:
    def __init__(self, owner, account_type, balance=0):
        self.owner = owner
        self.account_type = account_type
        self.balance = balance

    def deposit(self, amount):
        if amount > 0:
            self.balance += amount
            print(f"{self.owner} deposited {amount}$")
        else:
            print("Deposit amount must be positive")

    def withdraw(self, amount):
        if amount > 0 and amount <= self.balance:
            self.balance -= amount
            print(f"{self.owner} withdrew {amount}$")
        else:
            print("Insufficient funds or invalid amount")

    def __str__(self):
        return f"{self.owner}'s account balance ({self.account_type} account): {self.balance}$"


# Ощадний рахунок
class SavingsAccount(BankAccount):
    def __init__(self, owner, balance=0, interest_rate=0.03):
        super().__init__(owner, 'saving', balance)
        self.interest_rate = interest_rate

    def withdraw(self, amount):
        if amount > 0 and amount <= self.balance:
            self.balance -= amount
            print(f"{self.owner} withdrew {amount}$ from savings account")
        else:
            print("Cannot withdraw: insufficient funds in savings account")

    def add_interest(self):
        interest = self.balance * self.interest_rate
        self.balance += interest
        print(f"{self.owner} earned {interest}$ interest")


# Кредитний рахунок
class CreditAccount(BankAccount):
    def __init__(self, owner, balance=0, credit_limit=1000):
        super().__init__(owner, 'credit', balance)
        self.credit_limit = credit_limit

    def withdraw(self, amount):
        if amount <= self.balance + self.credit_limit:
            self.balance -= amount
            print(f"{self.owner} withdrew {amount}$ from credit account")
        else:
            print("Exceeded credit limit")


# Депозитний рахунок
class DepositAccount(BankAccount):
    def __init__(self, owner, balance=0, term_months=12):
        super().__init__(owner, 'deposit', balance)
        self.term_months = term_months
        self.locked = False

    def withdraw(self, amount):
        if self.locked:
            print("Cannot withdraw: deposit account is locked until maturity")
        elif amount <= self.balance:
            self.balance -= amount
            print(f"{self.owner} withdrew {amount}$ from deposit account")
    
    def lock(self):
        self.locked = True

    def unlock(self):
        self.locked = False


print("--------------------------------------------")

# Приклад використання
savings = SavingsAccount("Alice", 1000)
credit = CreditAccount("Bob", 200)
deposit = DepositAccount("Charlie", 5000)

print(savings)
savings.deposit(200)
savings.withdraw(50)
savings.add_interest()
print(savings, "\n")

print(credit)
credit.withdraw(1000)
credit.deposit(500)
print(credit, "\n")

print(deposit)
deposit.withdraw(1000)
deposit.lock()
deposit.withdraw(1000)
deposit.unlock()
deposit.withdraw(1000)
print(deposit)