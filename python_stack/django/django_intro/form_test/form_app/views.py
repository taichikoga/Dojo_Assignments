from django.shortcuts import render

# Create your views here.

def index(request):
    return render(request, "index.html")

def create_user(request):
    name_from_form = request.POST['first_name_last_name']
    email_from_form = request.POST['email']
    gender_from_form = request.POST['gender']
    context = {
        "name_on_template" : name_from_form,
        "email_on_template" : email_from_form,
        "gender_on_template" : gender_from_form
    }
    return redirect("/success")

def success(request):
    return render(request, "success.html")