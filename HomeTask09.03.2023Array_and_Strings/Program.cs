//Задание 1
//Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив 
//А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов:
//массива А в одну строку, массива В — в виде матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов,
//общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.

namespace HomeTask09._03._2023Array_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double[] a = new double[5];
            double[,] b = new double[3,4];
            double amult = 1;
            double aevensum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter the {i+1} number to array a: ");
                a[i]=Convert.ToDouble(Console.ReadLine());
                amult *= a[i];
                if (i % 2 == 0) aevensum += a[i];
            }
            for (int i = 0; i < a.Length; i++) Console.Write(a[i] + "\t");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0;i < b.GetLength(0); i++) 
                for (int j=0;j<b.GetLength(1); j++)
                    b[i,j] = random.NextDouble()*100;
            double bmax = b[0, 0];
            double bmin= b[0, 0];
            double bsum = 0;
            double bmult = 1;
            double bsumoddcolumn = 0;
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write("{0:f2}\t", b[i, j]);
                    if (b[i,j] > bmax) bmax = b[i,j];
                    if (bmin > b[i,j]) bmin = b[i,j];
                    bsum += b[i,j];
                    bmult *= b[i,j];
                    if (j%2 != 0) bsumoddcolumn += b[i,j];
                }
                    
                Console.WriteLine();
            }
            Console.WriteLine() ;
            double gmax;
            double gmin;
            double amax = a.Max();
            double amin = a.Min();
            if (amax > bmax) gmax = amax;
            else gmax = bmax;
            if (amin > bmin) gmin=bmin;
            else gmin = amin;
            Console.WriteLine(" Общий максимальный элемент обоих массивов ="+"{0:f2}",gmax);
            Console.WriteLine(" Общий минимальный элемент обоих массивов ="+"{0:f2}",gmin) ;
            Console.WriteLine();
            double gsum = a.Sum() + bsum;
            Console.WriteLine(" Общая сумма всех элементов обоих массивов ="+"{0:f2}",gsum);
            Console.WriteLine(" Общее произведение всех элементов обоих массивов ="+"{0:f2}",amult*bmult);
            Console.WriteLine(" Сумма всех четных элементов массива A ="+"{0:f2}",aevensum);
            Console.WriteLine(" Сумма нечетных столбцов массива В ="+"{0:f2}",bsumoddcolumn);
            Console.WriteLine();



        }
    }
}