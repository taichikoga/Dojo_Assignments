from django.urls import path
from . import views

urlpatterns = [
    path('', views.dashboard), # renders the homepage dashboard
    path('/add', views.add), # renders the add book & review page
]