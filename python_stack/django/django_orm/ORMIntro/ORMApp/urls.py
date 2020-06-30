from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('player/<int:player_id>', views.one_player),
    path('player/new', views.new_player),
    path('player/create', views.create_player)
]