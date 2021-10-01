import math

num, i = 0, 1

def divisors(num):
    n = 0
    numSqrt = int(math.sqrt(num))
    for i in range(1, numSqrt+1):
        if num%i == 0:
            n += 2
    if numSqrt*numSqrt == num:
        n -= 1
    return n

while divisors(num) < 500:
    num += i
    i += 1

print(num)