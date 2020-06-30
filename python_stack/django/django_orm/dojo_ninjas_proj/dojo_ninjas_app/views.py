from django.shortcuts import render, redirect
from .models import *

# Create your views here.

def index(request): 
    context={
        "all_the_dojos": Dojos.objects.all(),
        "all_the_users": Ninjas.objects.all()
    }
    return render(request, "index.html", context)

def add_dojo(request):
    new_dojo = Dojos.objects.create(
        name = request.POST['name'],
        city = request.POST['city'],
        state = request.POST['state']
    )
    return redirect('/')

def add_user(request):
    Ninjas.objects.create(
        dojo_id = request.POST['dojo_id'],
        first_name = request.POST['first_name'],
        last_name = request.POST['last_name']
    )
    return redirect('/')