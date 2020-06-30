from django.shortcuts import render, redirect
from django.contrib import messages
from .models import *

# Create your views here.

def index(request):
    return redirect("/shows")

def shows(request):
    context = {
        "all_shows": Shows.objects.all()
    }
    return render(request, "shows.html", context)

def new(request):
    return render(request, "new.html")

def create(request):
    errors = Shows.objects.shows_validator(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect("/shows/new")

    if request.method == "GET":
        return render(request, "new.html")
    elif request.method == "POST":
        new_show = Shows.objects.create(
            title = request.POST['title'],
            network = request.POST['network'],
            description = request.POST['description'],
            release_date = request.POST['release_date']
        )
        return redirect (f"/shows/{new_show.id}")
    else:
        return redirect (f"/shows")

def one_show(request, shows_id):
    context={
        "one_show": Shows.objects.get(id=shows_id)
    }
    return render(request, "one_show.html", context)

def edit(request, shows_id):
    context = {
        "show_to_edit": Shows.objects.get(id=shows_id)
    }
    return render(request, "edit.html", context)

def update(request, shows_id):
    errors = Shows.objects.shows_validator(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect(f"/shows/{shows_id}/edit")
    
    if request.method == "GET":
        context = {
            "show_to_edit": Shows.objects.get(id=shows_id)
        }
        return render(request, "edit.html", context)
    elif request.method == "POST":
        edit = Shows.objects.get(id=shows_id)
        edit.title = request.POST['title']
        edit.network = request.POST['network']
        edit.release_date = request.POST['release_date']
        edit.description = request.POST['description']
        edit.save()
        return redirect(f"/shows/{shows_id}")
    else: 
        return redirect(f"/shows/{shows_id}")

def delete(request, shows_id):
    delete = Shows.objects.get(id=shows_id)
    delete.delete()
    return redirect("/shows")