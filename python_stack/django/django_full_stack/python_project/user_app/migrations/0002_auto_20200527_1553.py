# Generated by Django 2.2.4 on 2020-05-27 22:53

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('matchmaking_app', '0001_initial'),
        ('user_app', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='user',
            name='lobbies',
            field=models.ForeignKey(default=None, on_delete=django.db.models.deletion.CASCADE, related_name='users', to='matchmaking_app.Lobby'),
            preserve_default=False,
        ),
        migrations.CreateModel(
            name='Friend',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('created_at', models.DateTimeField(auto_now_add=True)),
                ('updated_at', models.DateTimeField(auto_now=True)),
                ('users', models.ManyToManyField(related_name='friends', to='user_app.User')),
            ],
        ),
    ]
