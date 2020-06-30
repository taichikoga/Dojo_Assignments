from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('shows', views.shows),
    path('shows/new', views.new),
    path('shows/create', views.create),
    path('shows/<int:shows_id>', views.one_show),
    path('shows/<int:shows_id>/edit', views.edit),
    path('shows/<int:shows_id>/update', views.update),
    path('shows/<int:shows_id>/delete', views.delete)
]