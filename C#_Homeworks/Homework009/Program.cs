using Homework009;
using System.Reflection;
using System.Text;

class Program
{ /*Разработайте атрибут позволяющий методу ObjectToString сохранять поля классов с использованием произвольного имени.
Метод StringToObject должен также уметь работать с этим атрибутом для записи значение в свойство по имени его атрибута.
[CustomName(“CustomFieldName”)]
public int I = 0.
Если использовать формат строки с данными использованной нами для предыдущего примера то пара ключ значение 
    для свойства I выглядела бы CustomFieldName:0
Подсказка:
Если GetProperty(propertyName) вернул null то очевидно свойства с таким именем нет и возможно имя является 
    алиасом заданным с помощью CustomName. Возможно, если перебрать все поля с таким атрибутом то для одного из 
    них propertyName = совпадает с таковым заданным атрибутом.*/
    static void Main(string[] args)
    {
       // var n1 = MakeTestclass();
       // var n2 = MakeTestclass(5);
        char[] tmp = { 'a', 'b', 'c' };
        var n3 = MakeTestclass(6, "eeee", 1, tmp);
       
        string some = ObjectToString(n3);
        Console.WriteLine(some);
        var some1 = StringToObject(some);
        string some2 = ObjectToString(some1);
        Console.WriteLine(some2);
    }

    public int I = 0;
    static object StringToObject(string s) {
        string[] arg = s.Split("|");
        string[] arg1 = arg[0].Split(":");
        //Homework009.TestClass, Homework009, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:
        object some = Activator.CreateInstance(null, "Homework009.TestClass");
        if (arg1.Length > 1 && some != null)
        {
            var type = some.GetType();
            
            for (int i = 1; i < arg.Length; i++)
            {
                string[] nameAndValue = arg[i].Split(":");
                var p = type.GetProperty(nameAndValue[0]);
                if (p == null)
                {
                    MemberInfo[] myMembers = type.GetMembers();
                    for (int ii = 0; ii < myMembers.Length; ii++)
                    {
                        Object[] myAttributes = myMembers[i].GetCustomAttributes(true);
                        if (myAttributes.Length > 0)
                        {
                            Console.WriteLine("\nThe attributes for the member {0} are: \n", myMembers[i]);
                            for (int j = 0; j < myAttributes.Length; j++)
                                Console.WriteLine("The type of the attribute is {0}.", myAttributes[j]);
                        }
                    }
                    // n.SetValue
                    continue;
                }
                if (p.PropertyType == typeof(int))
                    p.SetValue(some, int.Parse(nameAndValue[1]));
                else if (p.PropertyType == typeof(string))
                    p.SetValue(some, nameAndValue[1]);
                else if (p.PropertyType == typeof(decimal))
                    p.SetValue(some, decimal.Parse(nameAndValue[1]));
                else if (p.PropertyType == typeof(char[]))
                    p.SetValue(some, nameAndValue[1].ToCharArray());
            }
        }
        return some;
    }
    
    static string ObjectToString(object o) { 
        Type type = o.GetType();
        StringBuilder sb = new StringBuilder();
        sb.Append(type.AssemblyQualifiedName + ":");
        sb.Append(type.Name + "|");
        object[] attributes = type.GetCustomAttributes(false);
        foreach (Attribute attr in attributes)
        {
            if (attr is CustomNameAttribute nameAttribute)
                sb.Append("CustomFieldName:" + nameAttribute.CustomFieldName + "|");
        }

            var prop = type.GetProperties();
        foreach ( var item in prop)
        {
            var tmp = item.GetValue(o);
            sb.Append(item.Name + ":");
            if (item.PropertyType == typeof(char[]))
            {
                sb.Append(new string(tmp as char[]) + "|");
            }
            else
            {
                sb.Append(tmp + "|");
            }   
        }
        return sb.ToString();
    }
    /*object[] attributes = type.GetCustomAttributes(false);
 
    // проходим по всем атрибутам
    foreach (Attribute attr in attributes)
    {
        // если атрибут представляет тип AgeValidationAttribute
        if (attr is AgeValidationAttribute ageAttribute)
            // возвращаем результат проверки по возрасту
            return person.Age >= ageAttribute.Age;
    }*/

    public static TestClass MakeTestclass()
    {
        Type testclass = typeof(TestClass);
        return Activator.CreateInstance(testclass) as TestClass;
    }

    public static TestClass MakeTestclass(int i)
    {
        Type testclass = typeof(TestClass);
        return Activator.CreateInstance(testclass, new object[] { i }) as TestClass;
    }

    public static TestClass MakeTestclass(int i, string s, decimal d, char[] c)
    {
        Type testclass = typeof(TestClass);
        return Activator.CreateInstance(testclass, new object[] { i, s, d, c }) as TestClass;
    }
}