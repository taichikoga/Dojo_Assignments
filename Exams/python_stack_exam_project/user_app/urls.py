from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('register', views.register),
    path('login', views.login),
    path('logout', views.logout),
    path('myaccount/<int:user_id>', views.myaccount),
    path('update/<int:user_id>', views.update),
]