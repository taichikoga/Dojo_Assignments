class User:
    def __init__(self, name):
        self.Name = name
        self.Account_balance = 0

    def make_deposit(self, amount):
        self.Account_balance += amount
        return self

    def make_withdrawal(self, amount):
        self.Account_balance -= amount
        return self

    def display_user_balance(self):
        print(f"User: {self.Name}, Balance: {self.Account_balance}")
        return self

jim = User("Jim")

jim.make_deposit(200).make_deposit(200).make_deposit(200).make_withdrawal(100).display_user_balance()

dwight = User("Dwight")

dwight.make_deposit(200).make_deposit(200).make_withdrawal(100).make_withdrawal(100).display_user_balance()

pam = User("Pam")

pam.make_deposit(400).make_withdrawal(100).make_withdrawal(100).make_withdrawal(100).display_user_balance()