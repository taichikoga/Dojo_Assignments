from django.shortcuts import render, HttpResponse, redirect
import random
# Create your views here.

def index(request):
    if 'earned' not in request.session:
        request.session['earned'] = 0
        request.session['location'] = []
    
    return render(request, "index.html")

def process_money(request):
    money = 0

    if request.POST['location'] == "farm":
        money = random.randint(10,20)
        message = (f"Earned {money} golds from the {request.POST['location']}!")

    if request.POST['location'] == "cave":
        money = random.randint(5,10)
        message = (f"Earned {money} golds from the {request.POST['location']}!")
    if request.POST['location'] == "house":
        money = random.randint(2,5)
        message = (f"Earned {money} golds from the {request.POST['location']}!")
    if request.POST['location'] == "casino":
        money = random.randint(-50,50)
        if money < 0:
            message = (f"entered into casino and lost {money} golds")
        else:
            message = (f"Earned {money} golds from the {request.POST['location']}!")


    request.session['earned'] += money 
    request.session['location'].append(message)
    request.session.save()

    return redirect("/")