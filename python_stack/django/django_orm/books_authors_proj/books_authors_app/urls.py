from django.urls import path
from . import views

urlpatterns = [
    path('', views.index),
    path('add_book', views.add_book),
    path('books/<int:book_id>', views.one_book),
    path('book/<int:book_id>/add_book_to_author', views.add_book_to_author)
]