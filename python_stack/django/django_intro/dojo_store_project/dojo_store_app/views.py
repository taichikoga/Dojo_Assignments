from django.shortcuts import render

# Create your views here.

def index(request):
    return render(request, "index.html")

def checkout(request):
    strawberry_quantity_from_form = request.POST["strawberry"]
    raspberry_quantity_from_form = request.POST["raspberry"]
    apple_quantity_from_form = request.POST["apple"]
    context = {
        "strawberry_quantity" : strawberry_quantity_from_form,
        "raspberry_quantity" : raspberry_quantity_from_form,
        "apple_quantity" : apple_quantity_from_form
    }
    return render(request, "results.html", context)