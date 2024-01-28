def get_op():
    op = int(input("1 - добавить ученика, \n 2 - добавить предмет,\n 3 - добавить оценку,\n 4 - показать весь список,\n 5 - показать оценки ученика, \n 6 - выход\n"))
    return op

def input_student():
    name = input("введи имя фамилию")
    return name

def input_less():
    name = input("введи фамилию")
    less = input("введи предмет")
    return name,less

def get_mark():
    name = input("введи фамилию ")
    less = input("введи предмет ")
    mark = input("введи оценку ")
    return name,less,mark

def input_student_table():
    name = input("введи имя фамилию ученика для просмотра оценок")
    return name