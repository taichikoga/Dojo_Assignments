from django.db import models
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


class LobbyManager(models.Manager):
    def lobby_validator(self, post_data):
        errors = {}

        if len(post_data['title']) == 0:
            errors['no_title'] = "The lobby name cannot be blank."
        if len(post_data['title']) < 5:
            errors['some_title'] = "The lobby name cannot be less than 5 characters."
        if len(post_data['title']) > 30:
            errors['toomuch_title'] = "The lobby name cannot be more than 30 characters."
        if len(post_data['preferred_game_type']) == 0:
            errors['no_preferred_game_type'] = "The game field cannot be blank."
        if len(post_data['preferred_game_type']) < 3:
            errors['some_preferred_game_type'] = "The game field cannot be less than 3 characters."

        if int(post_data['lobby_size']) == 0:
            errors['lobby_size'] = "The lobby size cannot be blank."
        if int(post_data['lobby_size']) < 2:
            errors['lobby_size'] = "The lobby size cannot be less than 2."
        if int(post_data['lobby_size']) > 20:
            errors['lobby_size'] = "The lobby size cannot be more than 20."
        return errors


class Lobby(models.Model):
    title = models.CharField(max_length=30)
    competitiveness = models.IntegerField()
    preferred_game_type = models.CharField(max_length=30)
    lobby_size = models.IntegerField()
    description = models.TextField()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = LobbyManager()

class User(models.Model):
    first_name = models.CharField(max_length=30)
    last_name = models.CharField(max_length=30)
    email = models.CharField(max_length=50)
    password = models.CharField(max_length=100)
    lobbies = models.ForeignKey(Lobby, related_name="users", on_delete = models.CASCADE)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = UserManager()