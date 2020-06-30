from django.shortcuts import render, redirect
import random

# Create your views here.
def index(request):
    if 'earned' not in request.session:
        request.session['earned'] = 0
        # request.session['location'] = []
    return render(request, "index.html")

def process(request):
    money = 0

    if request.POST['location'] == "farm":
        money = random.randint(10,20)
        message = (f"Earned {money} gold from the {request.POST['location']}!")

    request.session['earned'] += money
    request.session['location'].append(message)

    return render(request, "index.html", context)