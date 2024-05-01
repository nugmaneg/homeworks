stroka = 'пара-ра-рам рам-пам-папам па-ра-па-дам'
vowels = 'уеёэоаыяию'
frazi = [x for x in range(len(stroka.split(' ')))]
if len(frazi) > 1:

    for i in range(len(frazi)):
        n = 0
        for j in list(stroka.split(' ')[i]):
            if j in vowels:
                n += 1
            
        frazi[i] = n

    if len(set(frazi)) == 1:
        print("Парам пам-пам")
    else:
        print("Пам парам")

else:
    print('Количество фраз должно быть больше одной!')