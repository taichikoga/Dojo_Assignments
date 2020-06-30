from django.urls import path
from . import views

urlpatterns = [
    path('/<int:user_id>', views.wall),
    path('/create_message', views.create_message),
    path('/create_comment/<int:message_id>', views.create_comment),
    path('/delete_message/<int:message_id>', views.delete_message),
]