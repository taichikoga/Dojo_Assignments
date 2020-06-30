from django.shortcuts import render, redirect
from .models import *
from django.contrib import messages
import bcrypt

# Create your views here.

def dashboard(request, user_id):
    if "user_id" not in request.session:
        return redirect("/")
    if request.session['user_id'] == user_id:
        context = {
            "current_user": User.objects.get(id=request.session["user_id"]),
            "all_the_quotes": Quote.objects.all()
        }
        return render(request, "dashboard.html", context)
    else:
        return redirect("/")

def add(request):
    if request.method == "GET":
        return redirect(f"/quotes/{request.session['user_id']}")

    if request.method == "POST":
        errors = Quote.objects.quote_validations(request.POST)

        if len(errors) > 0:
            for key, value in errors.items():
                messages.error(request, value, extra_tags=key)
            return redirect(f"/quotes/{request.session['user_id']}")

        this_user = User.objects.get(id=request.session['user_id'])
        new_quote = Quote.objects.create(
            author = request.POST['author'],
            quote = request.POST['quote'],
            posted_by = this_user
        )

        return redirect(f"/quotes/{request.session['user_id']}")

def user(request, user_id):
    context={
        "this_user": User.objects.get(id=user_id),
        "quote_by_user": Quote.objects.filter(posted_by=user_id),
        "current_user": User.objects.get(id=request.session["user_id"]),
    }
    return render(request, "user.html", context)

def delete(request, quote_id):
    if not request.session['user_id']:
        return redirect(f"/quotes/{request.session['user_id']}")

    if request.method == "GET":
        to_delete = Quote.objects.filter(id=quote_id)

        to_delete.delete()
        return redirect(f"/quotes/{request.session['user_id']}")