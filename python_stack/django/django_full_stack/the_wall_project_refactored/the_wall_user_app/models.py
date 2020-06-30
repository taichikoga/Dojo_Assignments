from django.db import models
import re

# Create your models here.

class UsersManager(models.Manager):
    def users_validator(self, postData):
        errors = {}

        if len(postData['first_name']) == 0:
            errors['first_name'] = "All fields are required"
        elif len(postData['first_name']) < 2:
            errors['first_name'] = "Entry must be at least 2 characters."

        if len(postData['last_name']) == 0:
            errors['last_name'] = "All fields are required"
        elif len(postData['last_name']) < 2:
            errors['last_name'] = "Entry must be at least 2 characters."

        if len(postData['email']) == 0:
            errors['email'] = "All fields are required"
        elif len(Users.objects.filter(email=postData['email'])) > 0:
            errors['email'] = "This email is already being used for an existing account"

        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Invalid email address!"

        if len(postData['password']) == 0:
            errors['password'] = "All fields are required"
        elif len(postData['password']) < 8:
            errors['password'] = "Password must be at least 8 characters."

        if len(postData['confirm_pw']) == 0:
            errors['confirm_pw'] = "All fields are required"
        elif len(postData['confirm_pw']) < 8:
            errors['confirm_pw'] = "Password must be at least 8 characters."

        if postData['password'] != postData['confirm_pw']:
            errors['confirm_pw'] = "entry for password and confirm pw does not match."

        return errors

    def login_validator(self, postData):
        errors = {}

        if len(postData['email']) == 0:
            errors['email'] = "All fields are required"

        EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
        if not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Invalid email address!"

        if len(postData['password']) == 0:
            errors['password'] = "All fields are required"

        return errors

class Users(models.Model):
    first_name = models.CharField(max_length=45)
    last_name = models.CharField(max_length=45)
    email = models.CharField(max_length=45)
    password = models.CharField(max_length=255)
    confirm_pw = models.CharField(max_length=255)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = UsersManager()