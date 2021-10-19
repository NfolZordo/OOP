import math
import numpy as np
while(True):
    ti= int(input("1-Квадратне рівнняння, 2-Кубічне рівняння "))
    if(ti==1):
        print("ax^2+bx+c=0")
        a= int(input("a:"))
        b= int(input("b:"))
        c= int(input("c:"))


        D= int(b*b-4*a*c)
        print("D=",b,"*",b,"-4*",a,"*",c,"=",D)
        if(D<0):
            print("Немає розвя'зків")
        else:
            x1=( -b + math.sqrt(D))/(2*a)
            x2=( -b - math.sqrt(D))/(2*a)
            print("x1=",-b, "+", "sqrt(",D,"))/2*",a,"=",x1)
            print("x2=",-b, "-", "sqrt(",D,"))/2*",a,"=",x2)

        q= int(input("1-Завершити роботе, 2-Повторити  "))
        if(q==1):
            break
    if(ti==2):
        print("ax^3+bx^2+cx+d=0")
        a= int(input("a:"))
        b= int(input("b:"))
        c= int(input("c:"))
        d= int(input("d:"))

        coeff = [a,b,c,d]
        print("Результат: ",np.roots(coeff))

        q= int(input("1-Завершити роботе, 2-Повторити  "))
        if(q==1):
            break


