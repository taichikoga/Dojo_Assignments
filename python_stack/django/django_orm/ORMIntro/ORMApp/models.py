from django.db import models

class BasketballPlayer(models.Model):
    name = models.CharField(max_length=50)
    jersey_num = models.IntegerField()
    weight = models.DecimalField(decimal_places=2, max_digits=3)
    retired = models.BooleanField()
    first_game = models.DateField()
    bio = models.TextField()
    some_field = models.CharField(max_length=25)

    age = models.IntegerField()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
