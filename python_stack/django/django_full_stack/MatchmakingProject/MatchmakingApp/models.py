from django.db import models
from LoginApp.models import User

# Create your models here.

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
    users = models.ManyToManyField(User, related_name="lobbies")
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = LobbyManager()


# class Friend(models.Model):
#     created_by = models.ForeignKey(User, related_name="friendslist", on_delete=models.CASCADE)
#     users = models.ManyToManyField(User, related_name="friends")
#     created_at = models.DateTimeField(auto_now_add=True)
#     updated_at = models.DateTimeField(auto_now=True)