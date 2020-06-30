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
            "User_registration_info": Users.objects.get(id=user_id),
            "all_the_messages": Messages.objects.all().order_by("-created_at"),
        }
        return render(request, "success.html", context)
    return redirect("/")

def create_message(request, user_id):
    if request.method == "GET":
        return render(request, "success.html")
    elif request.method == "POST":
        this_user = Users.objects.get(id=user_id)
        this_message = Messages.objects.create(
            user = this_user,
            message = request.POST['message']
        )
        return redirect(f"/success/{user_id}")
    else:
        return redirect("")

def create_comment(request, user_id, message_id):
    if request.method == "GET":
        return render(request, "success.html")
    elif request.method == "POST":
        this_user = Users.objects.get(id=user_id)
        this_message = Messages.objects.get(id=message_id)
        this_comment = Comments.objects.create(
            user_of_comment = this_user,
            message_of_comment = this_message,
            comment = request.POST['comment']
        )
        return redirect(f"/success/{user_id}")

def logout(request):
    request.session.clear()
    request.session.flush()
    return redirect("/")