from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages
import bcrypt

# Create your views here.

def index(request):
    return render(request, "index.html")

def register(request):
    if request.method == "GET":
        return redirect("/")

    errors = User.objects.basic_validations(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect("/")

    pw_hash = bcrypt.hashpw(request.POST['password'].encode(), bcrypt.gensalt()).decode()
    new_user = User.objects.create(
        name = request.POST['name'],
        alias = request.POST['alias'],
        email = request.POST['email'],
        password = pw_hash
    )
    request.session['user_id'] = new_user.id
    return redirect("/books")

def login(request):
    if request.method == "GET":
        return redirect('/')
    
    current_user = User.objects.filter(email=request.POST['login_email'])
    if current_user:
        if bcrypt.checkpw(request.POST['login_pw'].encode(), current_user[0].password.encode()):
            request.session['user_id'] = current_user[0].id
            return redirect('/books')

    messages.error(request, "Invalid email/password", extra_tags="login_email")
    return redirect('/')

def logout(request):
    request.session.flush()
    return redirect("/")