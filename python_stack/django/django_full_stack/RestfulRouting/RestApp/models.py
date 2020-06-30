from django.db import models


# Create your models here.
class ThingManager(models.Manager):
    def thing_validator(self, postData):
        errors = {}

        if len(postData['field_1']) == 0:
            errors['field_1'] = "You cannot leave this field blank."
        elif len(postData['field_1']) < 3:
            errors['field_1'] = "Your field 1 entry must be at least 3 characters long."
        elif len(Thing.objects.filter(field_1=postData['field_1'])) > 0:
            errors['field_1'] = "You cannot create a duplicate entry with this information."
        
        if len(postData['field_2']) > 15:
            errors['field_2'] = "Your field 2 entry must be fewer than 15 characters in length."
        try:
            if postData['field_3'] == "banana pancakes":
                errors['field_3'] = "Get out of here Jack Johnson."
        except:
            errors['field_3'] = "Invalid entry"
        return errors



class Thing(models.Model):
    field_1 = models.CharField(max_length=25)
    field_2 = models.CharField(max_length=25)
    field_3 = models.CharField(max_length=25)

    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)

    objects = ThingManager()