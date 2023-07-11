//Задание 6
//Пользователь с клавиатуры вводит некоторый текст.
//Приложение должно изменять регистр первой буквы
//каждого предложения на букву в верхнем регистре.
//Например, если пользователь ввёл: «today is a good
//day for walking. i will try to walk near the sea».
//Результат работы приложения: «Today is a good day
//for walking. I will try to walk near the sea».

namespace Task_6
{
    
    internal class Program
    {
        static string ChangeToUpper(string a)
        {
            char[] c = a.ToCharArray();
            c[0] = char.ToUpper(c[0]);
            for (int i = 0; i < c.Length; i++)
                if (c[i] == '.' && c[i + 1] == ' ')
                    c[i + 2] = char.ToUpper(c[i + 2]);
            return new string(c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string: ");
            string a=Console.ReadLine();
            Console.WriteLine("The reducted string is:");
            Console.WriteLine("\t"+ChangeToUpper(a));
        }
    }
}