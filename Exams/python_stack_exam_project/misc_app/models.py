from django.db import models
from user_app.models import *

# Create your models here.

class QuoteManager(models.Manager):
    def quote_validations(self,postData):
        errors = {}

        # validations for Author
        if len(postData['author']) == 0:
            errors['author'] = "This field cannot be blank"
        elif len(postData['author']) < 4:
            errors['author'] = "This field must be longer than 3 characters"
        elif len(postData['author']) > 30:
            errors['author'] = "This field cannot be longer than 30 characters"

        #validations for Quote
        if len(postData['quote']) == 0:
            errors['quote'] = "This field cannot be blank"
        elif len(postData['quote']) < 11:
            errors['quote'] = "This field must be longer than 10 characters"

        return errors

class Quote(models.Model):
    author = models.CharField(max_length=30)
    quote = models.TextField()
    posted_by = models.ForeignKey(User, related_name="quotes_posted", on_delete=models.CASCADE)

    objects = QuoteManager()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)