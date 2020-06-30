#1.
x = [ [5,2,3], [10,8,9] ]
x[1][0] = 15
print(x)


students = [
    {'first_name':  'Michael', 'last_name' : 'Jordan'},
    {'first_name' : 'John', 'last_name' : 'Rosales'}
]
students[0]['last_name'] = 'Bryant'
print(students)


sports_directory = {
    'basketball' : ['Kobe', 'Jordan', 'James', 'Curry'],
    'soccer' : ['Messi', 'Ronaldo', 'Rooney']
}
sports_directory['soccer'][0] = 'Andres'
print(sports_directory)


z = [ {'x': 10, 'y': 20} ]
z[0]['y'] = 30
print(z)



#2.
students = [
    {'first_name':'Michael','last_name':'Jordan'},
    {'first_name':'John','last_name':'Rosales'},
    {'first_name':'Mark','last_name':'Guillen'},
    {'first_name':'KB','last_name':'Tonel'}
]
def iterateDictionary(students):
    for i in students:
        for key in i:
            print(f"{key} - {i[key]}")
iterateDictionary(students)





#3 
students = [
    {'first_name':'Michael','last_name':'Jordan'},
    {'first_name':'John','last_name':'Rosales'},
    {'first_name':'Mark','last_name':'Guillen'},
    {'first_name':'KB','last_name':'Tonel'}
]












def iterateDictionary2(key_name, some_list):
    for i in some_list:
        print(i[key_name])

iterateDictionary2('first_name',students)