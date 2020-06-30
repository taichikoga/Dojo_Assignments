from django.db import models

# Create your models here.

class ShowsManager(models.Manager):
    def shows_validator(self, postData):
        errors = {}

        if len(postData['title']) == 0:
            errors['title'] = "All fields are required"
        elif len(postData['title']) < 2:
            errors['title'] = "Title entry must be at least 2 characters."

        if len(postData['network']) == 0:
            errors['network'] = "All fields are required"
        elif len(postData['network']) < 3:
            errors['network'] = "Network entry must be at least 3 characters."

        if len(postData['release_date']) == 0:
            errors['release_date'] = "All fields are required"

        if len(postData['description']) == 0:
            errors['description'] = "All fields are required"
        elif len(postData['description']) < 10:
            errors['description'] = "Description entry must be at least 10 characters"

        return errors

class Shows(models.Model):
    title = models.CharField(max_length=45)
    network = models.CharField(max_length=45)
    release_date = models.DateField(null=True)
    description = models.CharField(max_length=255)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = ShowsManager()