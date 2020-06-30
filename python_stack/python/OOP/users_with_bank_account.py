class User:
    def __init__(self, name):
        self.Name = name
        self.account = BankAccount(int_rate=0.01, balance=0)

    def make_deposit(self, amount):
        self.account.deposit(amount)
        print(self.account.balance)
        return self

    def make_withdrawal(self, amount):
        self.account.withdraw(amount)
        return self

    def display_user_balance(self):
        print(f"User: {self.Name}, Balance: {self.account.display_account_info()}")
        return self


class BankAccount:
    def __init__(self, int_rate=0.01, balance=0):
        self.Interests = int_rate
        self.Account_balance = balance

    def deposit(self, amount):
        self.Account_balance += amount
        return self
    
    def withdraw(self, amount):
        if self.Account_balance >= amount:
            self.Account_balance -= amount
        else:
            print("Insufficient funds: Charging a $5 fee")
            self.Account_balance -= 5
        return self

    def display_account_info(self):
        print(f"Balance: {self.Account_balance}")
        return self

    def yield_interest(self):
        if self.Account_balance > 0:
            self.Account_balance += self.Account_balance*self.Interests
        return self

jim = User("Jim")
jim.make_deposit(200).make_withdrawal(100).display_user_balance()