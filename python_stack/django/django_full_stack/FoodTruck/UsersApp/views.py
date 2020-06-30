from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages
import bcrypt

# Create your views here.
def index(request):
    return render(request, "index.html")

def register(request):
    if request.method == "GET":
        return redirect('/')

    errors = User.objects.reg_val(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect('/')

    pw_hash = bcrypt.hashpw(request.POST['password'].encode(), bcrypt.gensalt()).decode()
    new_user = User.objects.create(
        first_name = request.POST['first_name'],
        last_name = request.POST['last_name'],
        email = request.POST['email'],
        password = pw_hash
    )
    request.session['user_id'] = new_user.id
    return redirect('/trucks')

def login(request):
    if request.method == "GET":
        return redirect('/')
    
    user = User.objects.filter(email=request.POST['log_email'])
    if user:
        if bcrypt.checkpw(request.POST['log_pass'].encode(), user[0].password.encode()):
            request.session['user_id'] = user[0].id
            return redirect('/trucks')
            
    messages.error(request, "Invalid email/password", extra_tags="log_email")
    return redirect('/')

def logout(request):
    request.session.flush()
    return redirect('/')