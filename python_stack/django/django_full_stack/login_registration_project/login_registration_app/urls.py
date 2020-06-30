from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('create', views.create),
    path('success/<int:user_id>', views.success),
    path('login', views.login),
    path('logout', views.logout)
]