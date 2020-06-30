from django.shortcuts import render, redirect

# Create your views here.

def index(request):
    if 'counter' not in request.session:
        request.session['counter'] = 0
    return render(request, "index.html")

def addtocount(request):
    if 'counter' not in request.session:
        request.session['counter'] = 0
    request.session['counter'] += 1
    return redirect('/')

def resetcount(request):
    request.session.flush()
    return redirect('/')