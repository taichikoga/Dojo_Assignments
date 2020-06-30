#1
# def biggie_size(x):
#     for i in range(len(x)):
#         if x[i] > 0:
#             x[i] = 'big'
#     return x
# biggie_size([-1,3,5,-5])


#2
# def count_positives(x):
#     count = 0
#     for i in range(len(x)):
#         if x[i] > 0:
#             count = count + 1
#     x[len(x)-1] = count
#     return x
# count_positives([-1,1,1,1])


#3
# def sum_total(x):
#     sum = 0
#     for i in range(len(x)):
#         sum = sum + x[i]
#     return sum
# sum_total([1,2,3,4])


#4
# def average(x):
#     sum = 0
#     for i in range(len(x)):
#         sum = sum + x[i]
#     avg = sum/len(x)
#     return avg
# average([1,2,3,4])


#5
# def length(x):
#     return len(x)
# length([37,2,1,-9])


#6
# def minimum(x):
#     if len(x) > 0:
#         min = x[0]
#         for i in range(1,len(x),1):
#             if min > x[i]:
#                 min = x[i]
#         return min
#     else:
#         return False
# minimum([37,2,1,-9])


#7
# def maximum(x):
#     if len(x) > 0:
#         max = x[0]
#         for i in range(len(x)):
#             if max < x[i]:
#                 max = x[i]
#         return max
#     else:
#         return False
# maximum([37,2,1,-9])


#8
# def ultimate_analysis(x):
#     sum = x[0]
#     min = x[0]
#     max = x[0]
#     for i in range(1,len(x),1):
#         sum = sum + x[i]
#         if min > x[i]:
#             min = x[i]
#         if max < x[i]:
#             max = x[i]
#     avg = sum/len(x)
#     newDict = {'sumTotal': sum, 'average': avg, 'minimum': min, 'maximum': max, 'length': len(x)}
#     return newDict
# ultimate_analysis([37,2,1,-9])


#9
# def reverse_list(x):
#     for i in range(len(x)):
#         if len(x)-1-i > i:
#             temp = x[i]
#             x[i] = x[len(x)-1-i]
#             x[len(x)-1-i] = temp
#         else:
#             return x
# reverse_list([37,2,1,-9])