from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('addtocount', views.addtocount),
    path('resetcount', views.resetcount)
]