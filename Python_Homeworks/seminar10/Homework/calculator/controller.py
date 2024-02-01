'''
Прикрутить бота к задачам с предыдущего семинара:
Создать калькулятор для работы с рациональными и комплексными числами, 
организовать меню, добавив в неё систему логирования'''
import view
import module
def start():
    type = view.get_type()
    if type:
        a,b = view.get_value_complex()
    else:
        a,b = view.get_value_int()
    sign = view.get_sign(type)
    module.init(a,b)
    res = "ошибка ввода"    
    if sign == "+":
        res = module.summ()
    elif sign == "-":
        res = module.diff()
    elif sign == "*":
        res = module.multy()
    elif sign == "/":
        res = module.div()
    elif sign == "//":
        res = module.div_cell()
    elif sign == "%":
        res = module.div_ost()
        
    view.out(res)