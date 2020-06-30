from django.db import models
from UsersApp.models import *

# Create your models here.
class TruckManager(models.Manager):
    def truck_val(self, postData):
        errors = {}

        trucks = Truck.objects.filter(name=postData['name'])

        # Validations for the Food Truck's name
        if len(postData['name']) == 0:
            errors['name'] = "Field cannot be left blank."
        elif len(postData['name']) < 5:
            errors['name'] = "Truck name cannot be fewer than 5 characters in length."
        elif len(postData['name']) > 50 :
            errors['name'] = "Truck name cannot be longer than 50 characters in length."
        elif trucks:
            errors['name'] = "A truck with that name already exists!"

        # Validations for the Food Truck's style
        if len(postData['style']) == 0:
            errors['style'] = "Field cannot be left blank."
        elif len(postData['style']) < 3:
            errors['style'] = "Cuisine style cannot be fewer than 3 characters in length."
        elif len(postData['style']) > 30:
            errors['style'] = "Cuisine style cannot be longer than 30 characters in length."
        
        # Validations for the Food Truck's description
        if len(postData['description']) == 0:
            errors['description'] = "Field cannot be left blank."
        elif len(postData['description']) < 10:
            errors['description'] = "Description cannot be fewer than 10 characters in length."
        elif len(postData['description']) > 100:
            errors['description'] = "Description cannot be longer than 100 characters in length."

        return errors

    def edit_val(self, postData, truck_id):
        errors = {}

        trucks = Truck.objects.filter(name=postData['name'])

        # Validations for the Food Truck's name
        if len(postData['name']) == 0:
            errors['name'] = "Field cannot be left blank."
        elif len(postData['name']) < 5:
            errors['name'] = "Truck name cannot be fewer than 5 characters in length."
        elif len(postData['name']) > 50 :
            errors['name'] = "Truck name cannot be longer than 50 characters in length."
        elif trucks and trucks[0].id != truck_id:
            errors['name'] = "A truck with that name already exists!"

        # Validations for the Food Truck's style
        if len(postData['style']) == 0:
            errors['style'] = "Field cannot be left blank."
        elif len(postData['style']) < 3:
            errors['style'] = "Cuisine style cannot be fewer than 3 characters in length."
        elif len(postData['style']) > 30:
            errors['style'] = "Cuisine style cannot be longer than 30 characters in length."
        
        # Validations for the Food Truck's description
        if len(postData['description']) == 0:
            errors['description'] = "Field cannot be left blank."
        elif len(postData['description']) < 10:
            errors['description'] = "Description cannot be fewer than 10 characters in length."
        elif len(postData['description']) > 100:
            errors['description'] = "Description cannot be longer than 100 characters in length."

        return errors
        
class ReviewManager(models.Manager):
    def rev_val(self, postData):
        errors = {}

        # Validations for the text review
        if len(postData['text']) == 0:
            errors['text'] = "Field cannot be left blank."
        elif len(postData['text']) < 10:
            errors['text'] = "Review cannot be fewer than 10 characters in length."
        elif len(postData['text']) > 100:
            errors['text'] = "Review cannot be longer than 100 characters in length."

        # Validations for rating
        try:
            if int(postData['rating']) > 5 or int(postData['rating']) < 1:
                errors['rating'] = "Your rating can only be between 1 and 5 stars"
        except:
            errors['rating'] = "Invalid rating. Stop hacking."
        
        return errors

class Truck(models.Model):
    name = models.CharField(max_length=50)
    style = models.CharField(max_length=30)
    description = models.TextField()
    owner = models.ForeignKey(User, related_name="trucks_owned", on_delete=models.CASCADE)
    favorited_by = models.ManyToManyField(User, related_name="favorite_trucks")

    objects = TruckManager()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)


class Review(models.Model):
    reviewer = models.ForeignKey(User, related_name="reviews_left", on_delete=models.CASCADE)
    rating = models.IntegerField()
    text = models.TextField()
    truck = models.ForeignKey(Truck, related_name="reviews", on_delete=models.CASCADE)

    objects = ReviewManager()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)