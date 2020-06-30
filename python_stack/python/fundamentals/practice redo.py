class User:
    def __init__(self, username, email_address):# now our method has 2 parameters!
        self.name = username			# and we use the values passed in to set the name attribute
        self.email = email_address		# and the email attribute
        self.account_balance = 0		# the account balance is set to $0, so no need for a third parameter

    def make_deposit(self, amount):	# takes an argument that is the amount of the deposit
        self.account_balance += amount	# the specific user's account increases by the amount of the value received

guido = User("Guido van Rossum", "guido@python.com")
monty = User("Monty Python", "monty@python.com")

print(guido.name)	# output: Michael
print(monty.name)	# output: Michael
print(guido.email)

guido.make_deposit(100)
guido.make_deposit(200)
monty.make_deposit(50)
