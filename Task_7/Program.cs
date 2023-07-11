//Задание 7
//Создайте приложение, проверяющее текст на недопустимые слова.
//Если недопустимое слово найдено, оно должно быть заменено на набор символов *.
//По итогам работы приложения необходимо показать статистику действий.
//Например, если и у нас есть такой текст:
//To be, or not to be, that is the question,
//Whether 'tis nobler in the mind to suffer
//The slings and arrows of outrageous fortune,
//Or to take arms against a sea of troubles,
//And by opposing end them? To die: to sleep;
//No more; and by a sleep to say we end
//The heart-ache and the thousand natural shocks
//That flesh is heir to, 'tis a consummation
//Devoutly to be wish'd. To die, to sleep
//Недопустимое слово: die.
//Результат работы:
//To be, or not to be, that is the question,
//Whether 'tis nobler in the mind to suffer
//The slings and arrows of outrageous fortune,
//Or to take arms against a sea of troubles,
//And by opposing end them? To ***: to sleep;
//No more; and by a sleep to say we end
//The heart-ache and the thousand natural shocks
//That flesh is heir to, 'tis a consummation
//Devoutly to be wish'd. To ***, to sleep.
//Статистика: 2 замены слова die.


using System.Reflection.Metadata;
using System.Text;

namespace Task_7
{
    internal class Program
    {
        static string ReplaceTheWord(string a, string word, string symbol)
        {
            StringBuilder c = new StringBuilder(a);
            c.Replace(word, symbol);
            return c.ToString();

        }
        static void Main(string[] args)
        {
            string a = new string("To be, or not to be, that is the question,\r\n" +
                "Whether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\n" +
                "Or to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\n" +
                "No more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\n" +
                "That flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep\r\n.");
            Console.WriteLine(a+"\n");
            Console.WriteLine("The text after reduction: ");
            Console.WriteLine(ReplaceTheWord(a, "die", "***"));
        }
    }
}