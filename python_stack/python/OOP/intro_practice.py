class User:
    def __init__(self, username, email_address):    # now our method has 2 parameters!
        self.name = username			            # and we use the values passed in to set the name attribute
        self.email = email_address		            # and the email attribute
        self.account_balance = 0		            # the account balance is set to $0, so no need for a third parameter


guido = User("Guido van Rossum", "guido@python.com")
monty = User("Monty Python", "monty@python.com")
print(guido.name)	# output: Guido van Rossum
print(monty.name)	# output: Monty Python



class User:		# here's what we have so far
    def __init__(self, name, email):
        self.name = name
        self.email = email
        self.account_balance = 0
    # adding the deposit method
    def make_deposit(self, amount):	# takes an argument that is the amount of the deposit
    	self.account_balance += amount	# the specific user's account increases by the amount of the value received



class Ninja:
    def __init__(self, name, age):
        self.Name = name
        self.Age = age
        self.Snowballs = 25
        self.Health = 100

    def throwSnowball(self, target):
        self.Snowballs -= 1
        target.Health -= 5
        print(f"{self.Name} threw a snowball at {target.Name} for 5 damage")

    def __repr__(self):
        return f"name: {self.Name}\nAge: {self.Age}\nSnowballs Remaining: {self.Snowballs}"

jim = Ninja("Jimothy", 29)
dwight = Ninja("Dwight", 30)

print(jim)
print(dwight)

jim.throwSnowball(dwight)

print(jim)
print(dwight)