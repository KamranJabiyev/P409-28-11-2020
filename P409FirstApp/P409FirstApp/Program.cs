using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P409FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C# data types
            ////Console.WriteLine("Hello P409");
            //byte age = 25;
            //Console.WriteLine(age);
            //age = 40;
            //Console.WriteLine(age);
            //int x = 1;

            //float pi = 3.14F;
            //double y = 1.12;
            //decimal z = 5.235M;

            //bool isMaried = true;
            //isMaried = false;

            //char letter = 'a';
            //char simbol = '1';
            //simbol = '@';
            //string word = "Hello P314";

            //int[] arr = { 10, 20, 1 };
            //string[] arrStr = { "Famil", "Elvin", "Ayten" };
            //string[] arrStr1 = new string[3] { "Ayshen", "Kenan", "Ismayil" };

            //var test = false;
            //test = true;

            //dynamic d = 10;
            //d = "Salam";
            //d = true;
            #endregion

            #region Operators
            #region Condition
            //int age = 17;
            //string city = "Sumqayit";
            //if (age>16)
            //{
            //    if (city == "Baku")
            //    {
            //        Console.WriteLine("Xosh geldiniz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ferqli sheherdensiz");
            //    }

            //}else if (age>=16)
            //{
            //    Console.WriteLine("1 iliniz qalin:)))");
            //}
            //else
            //{
            //    Console.WriteLine("Yashiniz chatmir");
            //}
            #endregion

            #region Switch case
            //string day = "Wednesday";

            //switch (day)
            //{
            //    case "Monday":
            //        Console.WriteLine("1-ci gun");
            //        break;
            //    case "Tuesday":
            //        Console.WriteLine("2-ci gun");
            //        break;
            //    default:
            //        Console.WriteLine("bashqa gun");
            //        break;
            //}
            #endregion

            #region Loops
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            string[] students = { "Elvin", "Ismayil", "Ayshen","Orxan" };
            //Console.WriteLine(students.Length);
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);

            int i = 1;
            while (i < 1)
            {
                Console.WriteLine($"while:{i}");
            }

            do
            {
                Console.WriteLine("doWhile:"+i);
            } while (i < 1);

            #endregion
            #endregion

        }
    }
}
