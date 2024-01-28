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