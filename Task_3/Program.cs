//Задание 3
//Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. 
//Из Википедии:
//Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется 
//символом, находящимся на некотором постоянном числе позиций левее или правее него в алфавите.
//Например,в шифре со сдвигом вправо на 3, A была бы заменена на D, B станет E, и так далее.
//Подробнее тут: https://en.wikipedia.org/wiki/Caesar_cipher.
//Кроме механизма шифровки, реализуйте механизм расшифрования.

namespace Task_3
{
    internal class Program
    {
        static string CezarChipherRight(string a, int key)
        {
            char[] c = a.ToCharArray();
            int[] k = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                k[i] = Convert.ToInt32(c[i]);
                if (k[i] >= 65 && k[i] <= 90)
                {
                    if ((k[i] + key) > 90)
                        k[i] = 65 + (k[i] + key) - 90;
                    else
                        k[i] = (k[i] + key);
                }
                else if (k[i] >= 97 && k[i] <= 122)
                {
                    if ((k[i] + key) > 122)
                        k[i] = 97 + (k[i] + key) - 122;
                    else
                        k[i] = (k[i] + key);
                }
                else
                    k[i] = k[i];
                c[i] = Convert.ToChar(k[i]);
            }
            return new string(c);
        }
        static string CezarChipherLeft(string a, int key)
        {
            char[] c = a.ToCharArray();
            int[] k = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                k[i] = Convert.ToInt32(c[i]);
                if (k[i] >= 65 && k[i] <= 90)
                {
                    if ((k[i] - key) < 65)
                        k[i] = 90 - 65 + (k[i] - key);
                    else
                        k[i] = (k[i] - key);
                }
                else if (k[i] >= 97 && k[i] <= 122)
                {
                    if ((k[i] - key) < 97)
                        k[i] = 122 - 97 + (k[i] - key);
                    else
                        k[i] = (k[i] - key);
                }
                else
                    k[i] = k[i];
                c[i] = Convert.ToChar(k[i]);
            }
            return new string(c);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string a = Console.ReadLine();
            Console.WriteLine($"The string is:\n\t{a}");
            Console.Write("Enter the cipher key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the cipher direction(Right or Left): ");
            string d = Console.ReadLine();
            Console.WriteLine("\nYour ciphered string:");
            Console.Write("\t");
            if (d == "Right")
                a=CezarChipherRight(a, key);
            else if (d == "Left")
                a=CezarChipherLeft(a, key);
            else
                a="Entered wrong cipher direction!";
            Console.WriteLine(a+"\n");
            Console.WriteLine("\nYour decrypted cipher string:");
            Console.Write("\t");
            if (d == "Right")
                a = CezarChipherLeft(a, key);
            else if (d == "Left")
                    a = CezarChipherRight(a, key);
            else 
                Console.WriteLine("Something went wrong!");
            Console.WriteLine(a + "\n");
        }
    }
}