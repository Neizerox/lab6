using System.Security.Cryptography;
using lab_1_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("1 человек");
        uint weight = Input.InputUInt("Введите вес");
        uint height = Input.InputUInt("Введите рост");
        uint age = Input.InputUInt("Введите возраст");
        Human human_1 = new Human((int) weight,(int)height,(int)age);
        Console.WriteLine(human_1.ToString());
        Console.WriteLine("Произведение " + human_1.Multiplication());

        Console.WriteLine("2 человек (копирование)");
        Human human_2 = new Human(human_1);
        Console.WriteLine(human_2.ToString());
        Console.WriteLine("Произведение " + human_2.Multiplication());

        Console.WriteLine("1 студент ");
        string name = Input.InputString("Введите имя студента ");
        uint course = Input.InputUInt("Введите курс ");
        bool debt = Input.InputBool("Есть ли долги? ");

        Student student_1  = new Student( (int) course,debt,name,(int) weight,(int) height,(int) age);
        student_1.NextCourse();

        Console.WriteLine("2 студент (копирование)");
        Student student_2 = new Student(student_1, human_2);
        student_2.NextCourse();

    }
}