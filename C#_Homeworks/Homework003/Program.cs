/*
 * Урок 1. Классы и ООП
Доработайте приложение генеалогического дерева таким образом чтобы программа выводила на экран близких родственников (жену/мужа). 
Продумайте способ более красивого вывода с использованием горизонтальных и вертикальных черточек.
*/
using Homework003;

public class Programm
{
    public static void Main(string[] args)
    {
        FamilyMember m0 = new FamilyMember("M0", FamilyMemberType.Man);
        FamilyMember m1 = new FamilyMember("M1", FamilyMemberType.Man);
        FamilyMember m2 = new FamilyMember("M2", FamilyMemberType.Woman);
        m1.Partner = m2;
        m2.Partner = m1;
        m1.Children = new FamilyMember[] { m0 };
        m2.Children = new FamilyMember[] { m0 };

        Console.WriteLine(m1.CloseRelevants());

    }
}
