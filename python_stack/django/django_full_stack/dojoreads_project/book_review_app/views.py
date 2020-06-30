from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages
import bcrypt

# Create your views here.

def dashboard(request):
    if "user_id" not in request.session:
        return redirect("/")

    if request.method == "GET":
        context = {
            "current_user": User.objects.get(id=request.session["user_id"]),
        }
        return render(request, "dashboard.html", context)

    if request.method == "POST":
        book_errors = Book.objects.book_validations(request.POST)
        review_errors = Review.objects.review_validations(request.POST)

        if len(book_errors) > 0:
            for key, value in book_errors.items():
                messages.error(request, value, extra_tags=key)
            return redirect("/books/add")

        if len(review_errors) > 0:
            for key, value in review_errors.items():
                messages.error(request, value, extra_tags=key)
            return redirect("/books/add")
        
        Book.objects.create(
            title = request.POST['title'],
            author = request.POST['author'],
            reviewed_by = request.session['user_id']
        )
        Review.objects.create(
            book =
            reviewer =
            review =
            rating =
        )
        return redirect(f"/books/")

def add(request):
    return render(request, "add.html")