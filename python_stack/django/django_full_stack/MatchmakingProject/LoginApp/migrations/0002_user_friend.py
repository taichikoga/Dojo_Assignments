# Generated by Django 2.2.4 on 2020-05-29 06:18

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('LoginApp', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='user',
            name='friend',
            field=models.ManyToManyField(related_name='_user_friend_+', to='LoginApp.User'),
        ),
    ]
