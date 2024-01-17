def get_student():
    name = input('Введите имя и фамилию студента: ')
    return name

def get_less():
    less = input('Введите предмет студента: ')
    return less

def get_mark():
    name = input('Введите имя и фамилию студента: ')
    less = input('Введите предмет студента: ')
    mark = (input('Введите оценку по предмету: '))
    return name,less,mark
    

def find_student():
    name = input('Введите имя студента для просмотра оценок: ')
    return name