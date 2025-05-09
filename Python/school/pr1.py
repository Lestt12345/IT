cash=230
answear=1
buy=None
while (21<=cash and answear==1):
    print (f"У вас є {cash} грн")
    if (43<=cash):
        print (f"Що ви бажаете купити?\n1 - Бургер=43грн\n2 - Кола=21грн\n3 - Я нічого не буду купляти")
        buy=int(input("Зробіть вибір: "))
        if (buy==1):
            cash-=43
            print (f"*ВИ КУПИЛИ БУРГЕР*\nСмачного!")
            if (21>cash):
                print (f"\nДопобачення (у вас не вистачає грошей)")
            else:
                print (f"\n\n")
        elif (buy==2):
            cash-=21
            print (f"*ВИ КУПИЛИ КОЛУ*\nСмачного!")
            if (21>cash):
                print (f"\nДопобачення (у вас не вистачає грошей)")
            else:
                print (f"\n\n")
        elif (buy==3):
            print (f"\nГарного дня, приходьте ще!")
            answear=2
        else:
            print (f"*ПОМИЛКА*  такої дії немає\n\n")
    elif (21<=cash):
        print (f"Що ви бажаете купити?\n1 - Бургер=43грн (у вас не вистачае грошей)\n2 - Кола=21грн\n3 - Я нічого не буду купляти")
        buy=int(input("Зробіть вибір: "))
        if (buy==1):
            print (f"*ОПЕРАЦІЯ НЕ УСПІШНА* У вас не вистачає грошей\n")
        elif (buy==2):
            cash-=21
            print (f"*ВИ КУПИЛИ КОЛУ*\nСмачного!")
            if (21>cash):
                print (f"\nДопобачення (у вас не вистачає грошей)")
            else:
                print (f"\n\n")
        elif (buy==3):
            print (f"\nГарного дня, приходьте ще!")
            answear=2
        else:
            print (f"*ПОМИЛКА*  такої дії немає\n\n")