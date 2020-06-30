# #1
def countdown(x):
    newlist = []
    for i in range(x,-1,-1):
        print(i)
        newlist.append(i)
    return newlist
print(countdown(5))


#2

def print_and_return(x):
    print(x[0])
    return x[1]
print_and_return([1,2])


#3

def first_plus_length(x):
    sum = x[0] + len(x)
    return sum
first_plus_length([1,2,3,4,5])


#4

def values_greater_than_second(x):
    newlist = []
    if(len(x) < 2):
        return False
    else:
        for i in range(0,len(x)):
            if(x[i] > x[1]):
                newlist.append(x[i])
        newlistlength = len(newlist)
        print(newlistlength)
        return newlist
values_greater_than_second([5,2,3,2,1,4])


#5
def length_and_value(size,value):
    newlist = []
    for i in range(0,size):
        newlist.append(value)
    return newlist
length_and_value(6,2)