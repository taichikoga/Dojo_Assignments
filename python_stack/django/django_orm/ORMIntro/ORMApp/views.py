from django.shortcuts import render, redirect
from .models import *

# Create your views here.
def index(request):
    context = {
        "list_of_players": BasketballPlayer.objects.all()
    }
    return render(request, 'index.html', context)

def one_player(request, player_id):
    context = {
        "one_player": BasketballPlayer.objects.get(id=player_id)
    }
    return render(request, 'oneplayer.html', context)

def new_player(request):
    return render(request, 'newplayer.html')

def create_player(request):
    retired = False
    if 'retired' in request.POST:
        retired = True
    new_player = BasketballPlayer.objects.create(
        name=request.POST['name'],
        jersey_num=request.POST['jersey_num'],
        height=request.POST['height'],
        retired=retired,
        first_game=request.POST['first_game'],
        bio=request.POST['bio']
    )
    return redirect(f"/player/{new_player.id}")