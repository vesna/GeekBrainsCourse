def get_type():
    type = int(input("Введите 1 - комлексные, 0 - действителные"))
    return type

def get_value_int():
    a = int(input("Введите число"))
    b = int(input("Введите число"))
    return a,b
    
def get_value_complex():
    a = complex(input("Введите число"))
    b = complex(input("Введите число"))
    return a,b

def get_sign(type):
    if type:
        sign = input("Введите знак для комплексных чисел (+,-,*,/)")
        if sign in ["+","-","/","*"]:
            return sign
        else:
            print("Не верный знак для комплексных чисел")
    else:
        sign = input("Введите знак для действительных чисел (-,+,*,/,//,%)")
        if sign in ["+","-","/","*","//","%"]:
            return sign
        else:
            print("Не верный знак для действительных чисел")
            
def out(res):
    print(res)