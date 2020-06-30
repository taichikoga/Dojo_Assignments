from django.urls import path
from . import views

urlpatterns = [
    path('', views.show_things),
    path('<int:thing_id>', views.one_thing),
    path('new', views.new_thing),
    path('create', views.create_thing),
    path('<int:thing_id>/edit', views.edit_thing),
    path('<int:thing_id>/update', views.update_thing), 
    path('<int:thing_id>/delete', views.delete_thing)
]