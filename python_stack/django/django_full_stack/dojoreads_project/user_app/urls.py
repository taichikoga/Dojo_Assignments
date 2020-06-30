from django.urls import path
from . import views

urlpatterns = [
    path('', views.index), # rendering the register/login page
    path('register', views.register), # processing the submitted register form
    path('login', views.login), # processing the submitted register form
    path('logout', views.logout) # logging out the user and flushing session
]