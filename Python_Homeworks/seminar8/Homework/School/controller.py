'''
Основное дз(из семинара):
Создать информационную систему позволяющую работать с учениками школы
функции
Добавление нового студента (Поля - имя, фамилия)
Добавление предмета (добавляется всем ученикам сразу)
Добавление оценки ученику по предмету (выбираем ученика(из существующих), выбираем предмет(из сущ.),пишем оценку )
Показ списка учеников (имена фамилия)
Показ листа оценок конкретного ученика
Выход из программы
Достаточно хранить данные в переменной

Доп*:
1) Добавить функцию генерации сразу ста учеников и записи их в журнал
(имя - рандомное из списка нескольких имен
фамилия - рандомная из списка нескольких фамилий
название предмета - рандом из списка с предметами
оценка - рандом от 1 до 5)
2) Вывод средней оценки ученика по одному предмету
3) Вывод среднего балла по школе по конкретному предмету
4)Вывод количества учеников претендующих на золотую медаль (все оценки либо 4 либо 5)
Добавить хранение в файле, и импорт из файла'''
import view

#main_dct = {"FIO:{"math":[4,5],"phisic":[]},"FIO":{}"}
main_dct = {}
name_list = []
lessons_list = []

def start():
    while True:
        #print(main_dct)
        op = view.get_op()
        if op == 1:
            name = view.input_student()
            if name not in name_list:
                name_list.append(name)
                main_dct[name] = {}
                for less in lessons_list:
                    main_dct[name][less] = []
        if op == 2:
            name, less = view.input_less()
            if name in name_list:
                if less not in lessons_list:
                    lessons_list.append(less)
                    main_dct[name][less] = []
            else:
                print("такого ученика нет в базе")
        if op == 3:
            name, less, mark = view.get_mark()
            if name in name_list:
                if less in lessons_list:
                    main_dct[name][less].append(mark)
                else:
                    print(f"у ученика {name} нет предмета {less}")
            else:
                print("такого ученика нет в базе")
        if op == 4:
            print(main_dct)
        if op == 5:
            name = view.input_student_table()
            print(main_dct[name])
        if op == 6:
            break