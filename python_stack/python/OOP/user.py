class User:
    def __init__(self, name):
        self.Name = name
        self.Account_balance = 0

    def make_deposit(self, amount):
        self.Account_balance += amount

    def make_withdrawal(self, amount):
        self.Account_balance -= amount

    def display_user_balance(self):
        print(f"User: {self.Name}, Balance: {self.Account_balance}")

jim = User("Jim")

jim.make_deposit(200)
jim.make_deposit(200)
jim.make_deposit(200)
jim.make_withdrawal(100)
jim.display_user_balance()

dwight = User("Dwight")

dwight.make_deposit(200)
dwight.make_deposit(200)
dwight.make_withdrawal(100)
dwight.make_withdrawal(100)
dwight.display_user_balance()

pam = User("Pam")

pam.make_deposit(400)
pam.make_withdrawal(100)
pam.make_withdrawal(100)
pam.make_withdrawal(100)
pam.display_user_balance()