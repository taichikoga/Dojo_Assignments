from django.urls import path
from . import views

urlpatterns = [
    path('', views.dashboard),
    path('add_lobby', views.add_lobby),
    path('create_lobby', views.create_lobby),
    path('<int:lobby_id>/leave', views.leave),
    path('<int:lobby_id>/edit', views.editinfo),
    path('<int:lobby_id>/view', views.lobbyinfo),
    path('<int:lobby_id>/join', views.join_lobby),
    path('<int:user_id>/add', views.add_friend),
    # path('create_friends', views.create_friends),
]