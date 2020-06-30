from django.shortcuts import render, redirect
from user_app.views import *
from .models import *

# Create your views here.

def dashboard(request):
    if 'loggedinId' not in request.session:
        return redirect("/")
    context = {
        'loggedinUser' : User.objects.get(id=request.session['loggedinId']),
        'all_lobbies' : Lobby.objects.all()
    }
    return render(request, "dashboard.html", context)

def add_lobby(request):
    errors = Lobby.objects.lobby_validator(request.POST)

    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect('/dashboard/add_lobby')

    if 'loggedinId' not in request.session:
        return redirect("/")
    context = {
        'loggedinUser' : User.objects.get(id=request.session['loggedinId']),
        'all_lobbies' : Lobby.objects.all()
    }
    return render(request, "addlobby.html", context)


def create_lobby(request):
    errors = Lobby.objects.lobby_validator(request.POST)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect('/dashboard/add_lobby') #goes to home page, not adjusted

    if 'loggedinId' not in request.session:
        return redirect("/")

    if request.method == "GET":
        return render(request, "dashboard.html")  

    new_lobby = Lobby.objects.create(
        title = request.POST['title'],
        competiteveness = request.POST['competitveness'],
        preferred_game_type = request.POST['preferred_game_type'],
        lobby_size = request.POST['lobby_size'],
        description = request.POST['description'],
        user_id = request.session['loggedinId']
    )
    return redirect('/dashboard')


def editinfo(request, lobby_id):
    context = {
        'loggedinUser' : User.objects.get(id=request.session['loggedinId']),
        "lobby" : Lobby.objects.get(id=lobby_id)
    }
    return render(request, "editlobby.html", context)


def updatelobby(request, lobby_id):
    errors = Lobby.objects.lobby_validator(request.POST)
    if len(errors) > 0:
        for key, value in errors.items():
            messages.error(request, value)
        return redirect("/")

    updatelobby = Lobby.objects.get(id=lobby_id)
    updatelobby.title = request.POST['title']
    updatelobby.competitiveness = request.POST['competitiveness']
    updatelobby.preferred_game_type = request.POST['preferred_game_type']
    updatelobby.lobby_size = request.POST['lobby_size']
    updatelobby.description = request.POST['description']
    updatelobby.save()
    return redirect("/dashboard")


def remove(request, lobby_id):
    delete_lobby = Lobby.objects.get(id=lobby_id).delete()
    return redirect('/dashboard')