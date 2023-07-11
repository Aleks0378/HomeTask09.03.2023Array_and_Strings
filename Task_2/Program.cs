//Задание 2
//Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
//Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] b = new int[5, 5];
            int bmax = b[0, 0];
            int bmin = b[0, 0];
            int imax=0, jmax=0;
            int imin=0, jmin=0;
            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++) 
                {
                    b[i, j] = random.Next(-100, 100);
                    Console.Write("\t"+b[i, j]);
                    if (b[i, j] > bmax)
                    {
                        bmax = b[i, j]; 
                        imax = i;
                        jmax = j;
                    }
                    if (bmin > b[i, j]) 
                    {
                        bmin = b[i, j]; 
                        imin = i;
                        jmin = j;
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            int temp;
            if (imin > imax)
            {
                temp = imin;
                imin = imax;
                imax = temp;
            }
            if(jmin > jmax)
            {
                temp = jmin;
                jmin = jmax;
                jmax = temp;
            }
            int sum = 0;
            for(int i =imin; i <= imax; i++)
                for(int j =0; j < b.GetLength(1); j++)
                {
                    if (i == imin && j <= jmin) continue;
                    else if(i == imax && j >= jmax) continue;
                    else sum+= b[i, j];
                }
            Console.WriteLine($" Сумма элементов массива, расположенных между минимальным и максимальным элементами = {sum}");
        }
    }
}