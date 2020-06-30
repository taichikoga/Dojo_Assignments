from django.db import models
from user_app.models import *

# Create your models here.

class BookManager(models.Manager):
    def book_validations(self, postData):
        errors = {}

        book_title = Book.objects.filter(title=postData['title'])
        book_author = Book.objects.filter(author=postData['author'])

        # validations for the book's title
        if len(postData['title']) == 0:
            errors['title'] = "This field cannot be blank"
        elif len(postData['title']) < 3:
            errors['title'] = "This field must be longer than 2 characters"
        elif len(postData['title']) > 30:
            errors['title'] = "This field cannot be longer than 30 characters"
        elif book_title:
            errors['title'] = "A Book with that name already exists!"

        # validations for the book's author
        if len(postData['author']) == 0:
            errors['author'] = "This field cannot be blank"
        elif len(postData['author']) < 3:
            errors['author'] = "This field must be longer than 2 characters"
        elif len(postData['author']) > 30:
            errors['author'] = "This field cannot be longer than 30 characters"
        elif book_author:
            errors['author'] = "An Author with that name already exists!"
        
        return errors

class ReviewManager(models.Manager):
    def review_validations(self, postData):
        errors = {}

        # validations for text review
        if len(postData['review']) == 0:
            errors['review'] = "This field cannot be blank."
        elif len(postData['review']) < 10:
            errors['review'] = "This field must be longer than 10 characters in length."
        elif len(postData['review']) > 100:
            errors['review'] = "This field must be longer than 100 characters in length."

        # validations for rating
        try:
            if int(postData['rating']) > 5 or int(postData['rating']) < 1:
                errors['rating'] = "Your rating can only be between 1 and 5 stars"
        except:
            errors['rating'] = "Invalid rating."
        
        return errors

class Book(models.Model):
    title = models.CharField(max_length=30)
    author = models.CharField(max_length=30)
    reviewed_by = models.ManyToManyField(User, related_name="reviewed_books")

    objects = BookManager()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

class Review(models.Model):
    book = models.ForeignKey(Book, related_name="reviews", on_delete=models.CASCADE)
    reviewer = models.ForeignKey(User, related_name="reviews_left", on_delete=models.CASCADE)
    review = models.TextField()
    rating = models.IntegerField()

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)