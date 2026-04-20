using lab_1_2;
internal class Program
{
    private static void Main(string[] args)
    {
        byte hours1 = (byte)Input.InputHour("Введите часы для time1");
        byte minute1 = (byte)Input.InputMin("Введите минуты для time1");
        Time time1 = new Time(hours1,minute1);

        byte hours2 = (byte)Input.InputHour("Введите часы для time2");
        byte minute2 = (byte)Input.InputMin("Введите минуты для time2");
        Time time2 = new Time(hours2,minute2);



        Time result = time1 - time2;
        Console.WriteLine("time1 = " + time1.ToString());
        Console.WriteLine("time2 = " + time2.ToString());
        Console.WriteLine("time1 - time2 : " + result.ToString());

        Time t1_after = time1++;
        Console.WriteLine("time++ : " + t1_after.ToString());
        Time t2_after = time2--;
        Console.WriteLine("time-- : " + t2_after.ToString());
        int morning = t1_after;
        Console.WriteLine("int : " + morning);
        bool night = (bool)t2_after;
        Console.WriteLine("bool : " + night);
        Console.WriteLine("t1 > t2: " + (t1_after > t2_after));
        Console.WriteLine("t1 < t2: " + (t1_after < t2_after));

    }
}