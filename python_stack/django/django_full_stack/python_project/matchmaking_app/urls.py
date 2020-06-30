from django.urls import path
from . import views

urlpatterns = [
    path('', views.dashboard),
    path('add_lobby', views.add_lobby),
    path('create_lobby', views.create_lobby),
    path('remove', views.remove),
    path('edit', views.editinfo),
]