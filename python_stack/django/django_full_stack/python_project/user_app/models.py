from django.db import models
# from matchmaking_app.models import *
import re, bcrypt

# Create your models here.

class UserManager(models.Manager):
    def reg_validator(self, post_data):
        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
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

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    
    objects = UserManager()

class Friend(models.Model):
    users = models.ManyToManyField(User, related_name="friends")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)