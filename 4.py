min = 0
for i in range(100, 999):
    for n in range(i, 999):
        number = str(n*i)
        if number == number[::-1]:
            if int(number) > min:
                min = int(number)
                break
                break
print(min)
