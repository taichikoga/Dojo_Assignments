from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('create', views.create),
    path('success/<int:user_id>', views.success),
    path('login', views.login),
    path('logout', views.logout),
    path('success/<int:user_id>/create_message', views.create_message),
    path('success/<int:user_id>/<int:message_id>/create_comment', views.create_comment)
]