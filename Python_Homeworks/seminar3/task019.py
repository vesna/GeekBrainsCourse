#19. Реализуйте алгоритм задания случайных чисел без использования встроенного генератора 
# псевдослучайных чисел.

import datetime
import time
# def random_int(num):
#     rand = datetime.datetime.now().microsecond%num
#     return rand+1

for i in range(10):
    time.sleep(0.01)
    print(datetime.datetime.now().microsecond)