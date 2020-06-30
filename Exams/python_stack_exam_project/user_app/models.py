from django.db import models
import re

# Create your models here.
class UserManager(models.Manager):
    def basic_validations(self, postData):
        PASS_REGEX = re.compile(r"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,16}$")
        EMAIL_REGEX = re.compile(r'^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$')
        errors = {}

        # validations for Name
        if len(postData['first_name']) == 0:
            errors['first_name'] = "This field cannot be blank"
        elif len(postData['first_name']) < 3:
            errors['first_name'] = "This field must be longer than 2 characters"
        elif len(postData['first_name']) > 30:
            errors['first_name'] = "This field cannot be longer than 30 characters"

        # validations for alias
        if len(postData['last_name']) == 0:
            errors['last_name'] = "This field cannot be blank"
        elif len(postData['last_name']) < 3:
            errors['last_name'] = "This field must be longer than 2 characters"
        elif len(postData['last_name']) > 30:
            errors['last_name'] = "This field cannot be longer than 30 characters"

        # validations for email
        user = User.objects.filter(email=postData['email'])
        if len(postData['email']) == 0:
            errors['email'] = "This field cannot be blank"
        elif len(postData['email']) < 3:
            errors['email'] = "This field must be longer than 2 characters"
        elif len(postData['email']) > 30:
            errors['email'] = "This field cannot be longer than 30 characters"
        elif not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Invalid email address format."
        elif user:
            errors['email'] = "This email address is already being used."

        # validations for password & confirm_pw
        if len(postData['password']) == 0:
            errors['password'] = "This field cannot be blank"
        elif len(postData['password']) < 3:
            errors['password'] = "This field must be longer than 2 characters"
        elif len(postData['password']) > 30:
            errors['password'] = "This field cannot be longer than 30 characters"

        if len(postData['confirm_pw']) == 0:
            errors['confirm_pw'] = "This field cannot be blank"
        elif len(postData['confirm_pw']) < 3:
            errors['confirm_pw'] = "This field must be longer than 2 characters"
        elif len(postData['confirm_pw']) > 30:
            errors['confirm_pw'] = "This field cannot be longer than 30 characters"

        elif postData['password'] != postData['confirm_pw']:
            errors['password'] = "Password & confirm password must match"
        elif not PASS_REGEX.match(postData['password']):
            errors['password'] = "Password must contain minimum 1 uppercase, 1 lowercase, 1 number, and 1 special character."

        return errors

class User(models.Model):
    first_name = models.CharField(max_length=30)
    last_name = models.CharField(max_length=30)
    email = models.CharField(max_length=30)
    password = models.CharField(max_length=30)

    objects = UserManager()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)