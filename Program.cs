using System;
using System.Diagnostics.CodeAnalysis;

namespace CHomeTask2Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task sozunun axirina 1,2,3 elave ederek tapsiriqlara baxmaq
            Task1();
            Task2();
            Task3();

        }
        static void Task1()
        {
            //Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod
            Console.WriteLine("Eded daxil edin");
            int number = Convert.ToInt32(Console.ReadLine());
            int digit = 0;
            int sum = 0;

            while(number > 0)
            {
                digit = number % 10;
                number= number / 10;
                sum += digit;
            }
            Console.WriteLine(sum);
        }


        static void Task2()
        {
            //Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan metod  
            Console.WriteLine("1ci ededi daxil edin.");
            string num1str = Console.ReadLine();
            int num1 = Convert.ToInt32(num1str);

            Console.WriteLine("2ci ededi daxil edin.");
            string num2str = Console.ReadLine();
            int num2 = Convert.ToInt32(num2str);

            int count = 0;
            int sum = 0;

            for (int i = num1; i <= num2; i++)
            {

                if (i % 21 == 0)
                {
                    count++;
                    sum += i;
                }
            }
            Console.WriteLine(sum / count);

        }



        static void Task3()
        {
            //Verilmis yazıda a herfi olub olmadigini tapan metod
            string Name = ("Nuru");
            bool haslettera = false;

            for (int i = 0; i < Name.Length; i++)
            {
                if (Name[i] == 'a')
                {
                    haslettera = true;
                    break;
                }
            }
            if (haslettera)
            {
                Console.WriteLine("he");
            }
            else
            {
                Console.WriteLine("yox");
            }
        }
    }    
}
