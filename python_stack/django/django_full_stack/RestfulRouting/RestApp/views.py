from django.shortcuts import render, redirect
# make sure you import the messages package
from django.contrib import messages
from .models import *

# Create your views here.
def show_things(request):
    context = {
        "all_things": Thing.objects.all()
    }
    return render(request, "show_things.html", context)

def one_thing(request, thing_id):
    context = {
        "one_thing": Thing.objects.get(id=thing_id)
    }
    return render(request, "one_thing.html", context)

def new_thing(request):
    return render(request, "new_thing.html")
    
def create_thing(request):
    # Adding our custom manager to our model as objects
    # gives us the ability to chain our custom methods 
    # almost as a nother kind of query

    # Step 1: Send request.POST through the validator
    # and store the results in an errors dictionary
    errors = Thing.objects.thing_validator(request.POST)

    if len(errors) > 0:
        # Then we have errors, and need to do something about it
        for key, value in errors.items():
            messages.error(request, value, extra_tags=key)
        return redirect("/things/new")

    new_thing = Thing.objects.create(
        field_1=request.POST['field_1'],
        field_2=request.POST['field_2'],
        field_3=request.POST['field_3']
    )
    return redirect(f"/things/{new_thing.id}")

def edit_thing(request, thing_id):
    context = {
        "thing_to_edit": Thing.objects.get(id=thing_id)
    }
    return render(request, "edit_thing.html", context)
    
def update_thing(request, thing_id):
    to_edit = Thing.objects.get(id=thing_id)
    to_edit.field_1 = request.POST['field_1']
    to_edit.field_2 = request.POST['field_2']
    to_edit.field_3 = request.POST['field_3']
    to_edit.save()
    return redirect(f"/things/{thing_id}")

def delete_thing(request, thing_id):
    to_delete = Thing.objects.get(id=thing_id)
    to_delete.delete()
    return redirect("/things")