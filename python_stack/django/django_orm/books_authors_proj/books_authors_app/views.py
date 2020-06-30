from django.shortcuts import render, redirect
from .models import *

# Create your views here.

def index(request):
    context={
        "all_the_books": Books.objects.all()
    }
    return render(request, "index.html", context)

def add_book(request):
    new_book = Books.objects.create(
        title = request.POST['title'],
        description = request.POST['description']
    )
    return redirect('/')

def one_book(request, book_id):
    context={
        "one_book": Books.objects.get(id=book_id),
        "all_the_authors": Authors.objects.all()
    }
    return render(request, "one_book.html", context)

def add_book_to_author(request, book_id):
    
    return redirect('/')