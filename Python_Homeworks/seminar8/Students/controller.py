import importstudent as imp
import view as v


students = {
}
names = []
lessons = []


def start():
    while True:
        choise = v.choise()
        if choise == 1:
            name = imp.get_student()
            if name not in students:
                names.append(name)
                students[name] = {}
                for lesson in lessons:
                    students[name][lesson] = []

        elif choise == 2:
            lesson = imp.get_less()
            if lesson not in lessons:
                lessons.append(lesson)
                for name in names:
                    students[name][lesson] = []

        elif choise == 3:
            name, lesson, mark = imp.get_mark()
            students[name][lesson].append(mark)

        elif choise == 4:
                print(students)
        elif choise == 5:
            imp.find_student()
            print(students[name])
        elif choise == 6:
            break
