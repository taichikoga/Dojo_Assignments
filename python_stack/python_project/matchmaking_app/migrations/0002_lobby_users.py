# Generated by Django 2.2.4 on 2020-05-27 23:00

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('user_app', '0003_remove_user_lobbies'),
        ('matchmaking_app', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='lobby',
            name='users',
            field=models.ForeignKey(default=None, on_delete=django.db.models.deletion.CASCADE, related_name='lobbies', to='user_app.User'),
            preserve_default=False,
        ),
    ]
