using System;

namespace task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Вася Пупкин", 27, "vasyaPupkinNe@prosto.ru", 5.0f, 4.2f, 4.1f);
            Console.WriteLine(student.ToString());
        }
    }
}
