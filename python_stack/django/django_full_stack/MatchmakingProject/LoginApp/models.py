from django.db import models
import re, bcrypt

# Create your models here.

class UserManager(models.Manager):
    def reg_validator(self, post_data):
        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        PASS_REGEX = re.compile(r"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,16}$")
        errors = {}

        # first name validations
        if len(post_data['first_name']) == 0:
            errors['first_name'] = "Your first name cannot be blank"
        elif len(post_data['first_name']) < 2:
            errors['first_name'] = "Your first name should be at least 2 characters long."

        # last name validations
        if len(post_data['last_name']) == 0:
            errors['last_name'] = "Your last name cannot be blank."
        elif len(post_data['last_name']) < 2:
            errors['last_name'] = "Your last name should be at least 2 characters long."

        # email validations
        if len(post_data['email']) == 0:
            errors['email'] = "Your email cannot be blank."
        elif len(post_data['email']) < 6:
            errors['email_format'] == "Invalid email address."
        elif not EMAIL_REGEX.match(post_data['email']):            
            errors['email'] = "Email is invalid."
        else:
            same_email = User.objects.filter(email=post_data['email'])
            if len(same_email) > 0:
                errors['email_taken'] = "This email already exists. Register with a different email."
        if len(post_data['password']) == 0:
            errors['password'] = "You must enter a password."
        elif len(post_data['password']) < 8:
            errors['password'] = "Password must be minimum 8 characters in length."
        if post_data['password'] != post_data['confirmpw']:
            errors['confirmpw'] = "Passwords must match."

        return errors

        #Validations for password. 
        if len(postData['password']) == 0:
            errors['password'] = "This field can't be left blank."
        elif len(postData['password']) < 8:
            errors['password'] = "Password must be min of 8 characters in length"
        elif not PASS_REGEX.match(postData['password']):
            errors['password'] = "Password must contain min 1 uppercase, 1 lowercase, 1 special character."
        elif postData['password'] != postData['pw_confirm']:
            errors['password'] = "Passwords don't match! Please try again."
        
        return errors
    

    def login_validator(self, post_data):
        errors = {}
        if len(post_data['email']) < 1:
            errors['email'] = "Email is required to log in."
        emailExists = User.objects.filter(email=post_data['email'])
        if len(emailExists) == 0:
            errors['email_not_found'] = "This email doesn't exist. Please register for an account first."
        else:
            user = emailExists[0]
            if not bcrypt.checkpw(post_data['password'].encode(), user.password.encode()):
                errors['password'] = "Password incorrect. Try again."  

        return errors


class User(models.Model):
    first_name = models.CharField(max_length=30)
    last_name = models.CharField(max_length=30)
    email = models.CharField(max_length=50)
    password = models.CharField(max_length=100)
    friend = models.ManyToManyField('self', symmetrical=False)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    objects = UserManager()
