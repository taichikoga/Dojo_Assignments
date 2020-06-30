from django.shortcuts import render, redirect
from django.contrib import messages
import bcrypt
from .models import *

# Create your views here.

def index(request):
    return render (request, "index.html")

def register(request):
    errors = User.objects.reg_validator(request.POST)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/")

    hashedpw = bcrypt.hashpw(request.POST['password'].encode(), bcrypt.gensalt()).decode()
    new_user = User.objects.create(
        first_name = request.POST['first_name'],
        last_name = request.POST['last_name'],
        email = request.POST['email'],
        password = hashedpw,
        lobbies = None
    )
    request.session['loggedinId'] = new_user.id
    return redirect("/success")


def success(request):
    if 'loggedinId' not in request.session:
        return redirect("/")
    # context = {
    #     'loggedinUser' : User.objects.get(id=request.session['loggedinId'])
    # }
    return redirect('/dashboard')


def login(request):
    errors = User.objects.login_validator(request.POST)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/success")

    user = User.objects.get(email=request.POST['email'])
    request.session['loggedinId'] = user.id
    print(user.id)
    return redirect('/success')


def logout(request):
    request.session.clear()
    return render(request, "logout.html")