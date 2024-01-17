def sort_names():
    with open("worker_list2.txt", "r+",encoding="UTF-8") as file:
        lst_with_str = file.readlines()
        list_with_lst = []    
        
        for line in lst_with_str:
            temp = line.split(",")
            list_with_lst.append(temp)
        list_with_lst = sorted(list_with_lst,key = lambda x:x[1])
        file.seek(0)
        for worker in list_with_lst:
            file.write(",".join(worker))
        print("Отсортировано")
       
            
# res_data = sorted(data, key = lambda line: int(line.split(';')[0]))
# data.seek(0)
# for i in res_data:
# data.write(i)

def sort_id():
    with open("worker_list2.txt", "r+",encoding="UTF-8") as file:
        lst_with_str = file.readlines()
        list_with_lst = []    
        
        for line in lst_with_str:
            temp = line.split(",")
            list_with_lst.append(temp)
        list_with_lst = sorted(list_with_lst,key = lambda x:x[0])
        file.seek(0)
        for worker in list_with_lst:
            file.write(",".join(worker))
        print("Отсортировано")