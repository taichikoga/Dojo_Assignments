from django.urls import path
from . import views

urlpatterns = [
    path('', views.index), # rendering the log/reg page
    path('register', views.register), # processing the submitted register form
    path('login', views.login), # processing the submitted login form
    path('logout', views.logout) # logging out the user
]