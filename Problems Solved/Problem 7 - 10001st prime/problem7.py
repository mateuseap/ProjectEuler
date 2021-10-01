count = 0
i = 2

while count < 10001:
    for k in range(2, i):
        if (i%k) == 0:
            break
    else:
        ans = i
        count = count+1

    i = i+1

print(ans)