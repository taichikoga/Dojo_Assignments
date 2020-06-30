from django.shortcuts import render, redirect
from django.contrib import messages
from .models import *

# Create your views here.

def wall(request, user_id):
    if request.session['id'] == user_id:
        context={
            "User_registration_info": Users.objects.get(id=request.session['id']),
            "all_the_messages": Messages.objects.all().order_by("-created_at"),
        }
    return render(request, "wall.html", context)

def create_message(request):
    if request.method == "GET":
        return redirect("/wall")
    elif request.method == "POST":
        user_id = request.session['id']
        print(user_id)
        this_user = Users.objects.get(id=user_id)
        this_message = Messages.objects.create(
            user = this_user,
            message = request.POST['message']
        )
        return redirect(f"/wall/{user_id}")
    else:
        return redirect("/wall")

def create_comment(request, message_id):
    print("hello")
    if request.method == "GET":
        return render(request, "wall.html")
    elif request.method == "POST":
        print(f"{request.session['id']}")
        user_id = request.session['id']
        this_user = Users.objects.get(id=user_id)
        this_message = Messages.objects.get(id=message_id)
        this_comment = Comments.objects.create(
            user_of_comment = this_user,
            message_of_comment = this_message,
            comment = request.POST['comment']
        )
        return redirect(f"/wall/{request.session['id']}")

def delete_message(request, message_id):
    if not request.session['id']:
        return redirect(f"/wall/{request.session['id']}")

    if request.method == "GET":
        to_delete = Messages.objects.filter(id=message_id)

        if to_delete[0].user.id != request.session['id']:
            return redirect(f"/wall/{request.session['id']}")

        to_delete.delete()
        return redirect(f"/wall/{request.session['id']}")