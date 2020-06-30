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

    if request.method == "GET":
        return render(request, "index.html")
    elif request.method == "POST":
        pw_hash = bcrypt.hashpw(request.POST['password'].encode(), bcrypt.gensalt()).decode()
        new_user = User.objects.create(
            first_name = request.POST['first_name'],
            last_name = request.POST['last_name'],
            email = request.POST['email'],
            password = pw_hash
        )
        request.session['user_id'] = new_user.id
        return redirect(f"/quotes/{request.session['user_id']}")

def login(request):
    if request.method == "GET":
        return redirect('/')

    current_user = User.objects.filter(email=request.POST['login_email'])
    if current_user:
        if bcrypt.checkpw(request.POST['login_pw'].encode(), current_user[0].password.encode()):
            request.session['user_id'] = current_user[0].id
            return redirect(f"/quotes/{request.session['user_id']}")

    messages.error(request, "Invalid email/password", extra_tags="login_email")
    return redirect('/')

def myaccount(request, user_id):
    if request.session['user_id'] == user_id:
        context={
            "current_user": User.objects.get(id=user_id)
        }
        return render(request, "myaccount.html", context)
    return redirect(f"/myaccount/{request.session['user_id']}")

def update(request, user_id):
    if request.method == "POST":
        user = User.objects.get(id=user_id)
        user.first_name = request.POST["first_name"]
        user.last_name = request.POST["last_name"]
        user.email = request.POST["email"]
        user.save()
        return redirect(f"/quotes/{request.session['user_id']}")

def logout(request):
    request.session.flush()
    return redirect("/")