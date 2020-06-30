from django.shortcuts import render, HttpResponse, redirect

def index(request):
    return HttpResponse("placeholder to later display a list of all blogs('/')")

def new(request):
    return HttpResponse("new('/')")

def create(request):
    return redirect("/index")

def show(request, number):
    return HttpResponse(f"placeholder to display blog number: {number}('/')")

def edit(request, number):
    return HttpResponse(f"placeholder to edit blog {number}('/')")

def destroy(request, number):
    return redirect("/index")

# Create your views here.
