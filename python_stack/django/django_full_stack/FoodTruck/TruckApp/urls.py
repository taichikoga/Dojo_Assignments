from django.urls import path
from . import views
urlpatterns = [
    path('', views.dashboard),
    path('/new', views.new_truck),
    path('/<int:truck_id>', views.one_truck),
    path('/<int:truck_id>/review', views.leave_review),
    path('/<int:truck_id>/favorite', views.favorite_truck),
    path('/<int:truck_id>/edit', views.edit_truck),
    path('/<int:truck_id>/delete', views.delete_truck)
]