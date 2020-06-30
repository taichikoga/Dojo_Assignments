from django.shortcuts import render, redirect
from django.contrib import messages
from .models import *
import bcrypt

# Create your views here.

def index(request):
    return render(request, "index.html")

def create(request):    
    errors = Users.objects.users_validator(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect("/")

    if request.method == "GET":
        return render(request, "index.html")
    elif request.method == "POST":
        raw_password = request.POST['password']
        pw_hash = bcrypt.hashpw(raw_password.encode(), bcrypt.gensalt()).decode()
        print(pw_hash)
        new_user = Users.objects.create(
            first_name = request.POST['first_name'],
            last_name = request.POST['last_name'],
            email = request.POST['email'],
            password = pw_hash,
            confirm_pw = pw_hash
        )
        request.session['id'] = new_user.id
        return redirect(f"/success/{new_user.id}")
    else:
        return redirect("/")

def login(request):
    user = Users.objects.filter(email=request.POST['email'])
    if user:
        logged_user = user[0]
        # use bcrypt's check_password_hash method, passing the hash from our database and the password from the form
        if bcrypt.checkpw(request.POST['password'].encode(), logged_user.password.encode()):
            request.session['id'] = logged_user.id
            return redirect(f'/success/{logged_user.id}')

    errors = Users.objects.login_validator(request.POST)
    errors['email'] = "Invalid login entry"
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect("/")
    return redirect("/")

def success(request, user_id):
    if request.session['id'] == user_id:
        context={
            "User_registration_info": Users.objects.get(id=user_id)
        }
        return render(request, "success.html", context)
    return redirect("/")

def logout(request):
    request.session.clear()
    request.session.flush()
    return redirect("/")