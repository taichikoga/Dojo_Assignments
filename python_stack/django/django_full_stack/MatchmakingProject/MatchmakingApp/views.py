from django.shortcuts import render, redirect
from LoginApp.views import *
from .models import *

# Create your views here.

def dashboard(request):
    if 'loggedinId' not in request.session:
        return redirect("/")
    context = {
        'loggedinUser' : User.objects.get(id=request.session['loggedinId']),
        'all_users' : User.objects.all(),
        'all_lobbies' : Lobby.objects.all(),
        'all_friends': User.objects.get(id=request.session['loggedinId']).friend.all()
    }
    return render(request, "dashboard.html", context)

def add_lobby(request):
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
        competitiveness = request.POST['competitiveness'],
        preferred_game_type = request.POST['preferred_game_type'],
        lobby_size = request.POST['lobby_size'],
        description = request.POST['description']
    )
    return redirect('/dashboard')

def join_lobby(request, lobby_id):
    user_id = request.session['loggedinId']
    lobby = Lobby.objects.get(id=lobby_id)
    User.objects.get(id=user_id).lobbies.add(lobby)
    return redirect(f"/dashboard/{lobby_id}/view")


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


def leave(request, lobby_id):
    user_id = request.session['loggedinId']
    lobby = Lobby.objects.get(id=lobby_id)
    User.objects.get(id=user_id).lobbies.remove(lobby)
    return redirect(f"/dashboard")
    


def lobbyinfo(request, lobby_id):
    context = {
        'loggedinUser' : User.objects.get(id=request.session['loggedinId']),
        "lobby" : Lobby.objects.get(id=lobby_id),
        "all_users" : User.objects.all(),
        # "all_friends" : User.objects.get(id=request.session['loggedinId']).friend.all()
    }
    return render(request, "viewlobby.html", context)

# def create_friends(request):
#     # if request.method == "GET":
#     #     return render(request, "dashboard.html")  
    
#     new_friend_list = Friend.objects.create(
#         created_by = request.session['loggedinId']
#     )
#     return redirect("/success")


def add_friend(request, user_id):
    # user_id = request.session['loggedinId']
    # friend = Friend.objects.get(id=friend_id)
    # User.objects.get(id=user_id).friends.add(friend)
    # return redirect("/dashboard")

    them = User.objects.get(id=user_id)
    you = User.objects.get(id=request.session['loggedinId'])
    you.friend.add(them)
    you.save()
    return redirect("/dashboard")


