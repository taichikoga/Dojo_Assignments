from django.urls import path
from . import views

urlpatterns = [
    path('/<int:user_id>', views.dashboard),
    path('/add', views.add),
    path('/user/<int:user_id>', views.user),
    path('/delete/<int:quote_id>', views.delete),
]