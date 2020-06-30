from django.shortcuts import render, redirect
from django.db.models import Avg
from django.contrib import messages
from .models import *

# Create your views here.
def dashboard(request):
    if "user_id" not in request.session:
        return redirect("/")
    if request.method == "GET":
        context = {
            "logged_user": User.objects.get(id=request.session["user_id"]),
            "all_trucks": Truck.objects.annotate(avg_rating=Avg("reviews__rating"))
        }
        return render(request, "dashboard.html", context)
    if request.method == "POST":
        errors = Truck.objects.truck_val(request.POST)

        if len(errors) > 0:
            for key, value in errors.items():
                messages.error(request, value, extra_tags=key)
            return redirect("/trucks/new")
        
        Truck.objects.create(
            name=request.POST["name"],
            style=request.POST["style"],
            description=request.POST["description"],
            owner_id=request.session["user_id"]
        )
        return redirect("/trucks")
    return redirect("/")

def new_truck(request):
    if "user_id" not in request.session:
        return redirect("/")
    if request.method == "GET":
        return render(request, "new_truck.html")
    return redirect("/")

def one_truck(request, truck_id):
    if "user_id" not in request.session:
        return redirect("/")
    if request.method == "GET":
        truck = Truck.objects.filter(id=truck_id).annotate(avg_rating=Avg("reviews__rating"))
        if not truck:
            return redirect("/trucks")
        context = {
            "one_truck": truck[0]
        }
        return render(request, "one_truck.html", context)
    
    return redirect("/")

def leave_review(request, truck_id):
    if "user_id" not in request.session:
        return redirect("/")
    if request.method == "GET":
        return redirect(f"/trucks/{truck_id}")
    if request.method == "POST":
        errors = Review.objects.rev_val(request.POST)

        truck = Truck.objects.filter(id=truck_id)

        if not truck:
            return redirect("/trucks")

        if len(errors) > 0:
            for key, value in errors.items():
                messages.error(request, value, extra_tags=key)
            return redirect(f"/trucks/{truck_id}")

        Review.objects.create(
            reviewer_id=request.session["user_id"],
            truck_id=truck_id,
            text = request.POST["text"],
            rating = request.POST["rating"]
        )
        return redirect(f"/trucks/{truck_id}")
    return redirect("/")

def favorite_truck(request, truck_id):
    if "user_id" not in request.session:
        return redirect("/")
    if request.method == "GET":
        truck = Truck.objects.filter(id=truck_id)

        if not truck or truck[0].owner.id == request.session["user_id"]:
            return redirect("/trucks")
        

        truck[0].favorited_by.add(request.session["user_id"])
        return redirect("/trucks")
    return redirect("/")

def edit_truck(request, truck_id):
    if "user_id" not in request.session:
        return redirect("/")
    if request.method == "GET":
        truck = Truck.objects.filter(id=truck_id)

        if not truck or truck[0].owner.id != request.session["user_id"]:
            return redirect("/trucks")
        context = {
            "one_truck": truck[0]
        }
        return render(request, "edit_truck.html", context)
    if request.method == "POST":
        truck = Truck.objects.filter(id=truck_id)

        if not truck or truck[0].owner.id != request.session["user_id"]:
            return redirect("/trucks")

        errors = Truck.objects.edit_val(request.POST, truck_id)

        if len(errors) > 0:
            for key, value in errors.items():
                messages.error(request, value, extra_tags=key)
            return redirect(f"/trucks/{truck_id}/edit")
        
        truck[0].name = request.POST["name"]
        truck[0].style = request.POST["style"]
        truck[0].description = request.POST["description"]
        truck[0].save()

        return redirect(f"/trucks/{truck_id}")
    return redirect("/")

def delete_truck(request, truck_id):
    if "user_id" not in request.session:
        return redirect("/")
    
    if request.method == "GET":
        to_delete = Truck.objects.filter(id=truck_id)

        if not to_delete or to_delete[0].owner.id != request.session["user_id"]:
            return redirect("/trucks")

        to_delete.delete()
        return redirect("/trucks")