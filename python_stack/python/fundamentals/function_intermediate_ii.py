1.
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

#1. Change the value 10 in x to 15. Once you're done, x should now be [ [5,2,3], [15,8,9] ].
#2. Change the last_name of the first student from 'Jordan' to 'Bryant'
#3. In the sports_directory, change 'Messi' to 'Andres'
#4. Change the value 20 in z to 30


#2.
students = [
    {'first_name':'Michael','last_name':'Jordan'},
    {'first_name':'John','last_name':'Rosales'},
    {'first_name':'Mark','last_name':'Guillen'},
    {'first_name':'KB','last_name':'Tonel'}
]

def functiontest(var_key,var_list):
    for var_key in var_list:
        print(var_key,students(key))
functiontest('first_name',students)



def iterateDictionary(sample_list):
    for i in sample_list:
        print(i)
print(iterateDictionary(students))


# should output: (it's okay if each key-value pair ends up on 2 separate lines;
# bonus to get them to appear exactly as below!)
# first_name - Michael, last_name - Jordan
# first_name - John, last_name - Rosales
# first_name - Mark, last_name - Guillen
# first_name - KB, last_name - Tonel


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

def iterateDictionary2(key_name,some_list):
    for i in some_list:
        print(i[key_name])
iterateDictionary2('last_name',students)



dojo = {
    'locations': ['San Jose', 'Seattle', 'Dallas', 'Chicago', 'Tulsa', 'DC', 'Burbank'],
    'instructors': ['Michael', 'Amy', 'Eduardo', 'Josh', 'Graham', 'Patrick', 'Minh', 'Devon']
}


def printInfo(dict1):
    x=0
    y=0
    for i in dict1:
        print(str(len(dict1[i]))+ i)
        for j in range(len(dict1[i]));
        print(dict1[i][j])
        x = x+1
printInfo(dojo)