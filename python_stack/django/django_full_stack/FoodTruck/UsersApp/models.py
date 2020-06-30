from django.db import models
import re

# Create your models here.
class UserManager(models.Manager):
    def reg_val(self, postData):
        EMAIL_REGEX = re.compile(r'^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$')
        PASS_REGEX = re.compile(r"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,16}$")
        errors = {}

        # Validations for First Name
        if len(postData['first_name']) == 0:
            errors['first_name'] = "This field cannot be left blank."
        elif len(postData['first_name']) < 2:
            errors['first_name'] = "This field cannot be fewer than 2 characters in length."
        elif len(postData['first_name']) > 30:
            errors['first_name'] = "This field cannot be longer than 30 characters in length."

        # Validations for Last Name
        if len(postData['last_name']) == 0:
            errors['last_name'] = "This field cannot be left blank."
        elif len(postData['last_name']) < 2:
            errors['last_name'] = "This field cannot be fewer than 2 characters in length."
        elif len(postData['last_name']) > 30:
            errors['last_name'] = "This field cannot be longer than 30 characters in length."

        # Validations for Email
        user = User.objects.filter(email=postData['email'])
        if len(postData['email']) == 0:
            errors['email'] = "This field cannot be left blank."
        elif len(postData['email']) < 6:
            errors['email'] = "Invalid email address."
        elif not EMAIL_REGEX.match(postData['email']):
            errors['email'] = "Invalid email address."
        elif user:
            errors['email'] = "Please use another email address."

        # Validations for Password
        if len(postData['password']) == 0:
            errors['password'] = "This field cannot be left blank."
        elif len(postData['password']) < 8:
            errors['password'] = "Password must be minimum 8 characters in length."
        elif not PASS_REGEX.match(postData['password']):
            errors['password'] = "Password must contain minimum 1 uppercase, 1 lowercase, 1 number, and 1 special character."
        elif postData['password'] != postData['pw_confirm']:
            errors['password'] = "Passwords do not match."

        return errors


class User(models.Model):
    first_name = models.CharField(max_length=30)
    last_name = models.CharField(max_length=30)
    email = models.CharField(max_length=50)
    password = models.CharField(max_length=100)

    objects = UserManager()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)