from django.db import models
from the_wall_user_app.models import *

# Create your models here.

class Messages(models.Model):
    user = models.ForeignKey(Users, related_name="messages", on_delete = models.CASCADE)
    message = models.TextField()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

class Comments(models.Model):
    user_of_comment = models.ForeignKey(Users, related_name="comments_user", on_delete = models.CASCADE)
    message_of_comment = models.ForeignKey(Messages, related_name="comments_message", on_delete = models.CASCADE)
    comment = models.TextField()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)