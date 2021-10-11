using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2L4
{
    

    public class Tasks 
    {
        public void FirstTask()
        {
            string name;

            string lastName;

            short age;

            char gender;

            int pesel;

            int employeeNumber;

            Console.WriteLine("Task 1 completed.");
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();

        }

        public void SecondTask()
        {
            char a = 'A';

            char b = 'B';

            char c = 'C';

            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);

            Console.WriteLine("Task 2 completed.");
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();

        }

        public void ThirdTask()
        {
            Console.WriteLine("Please enter the width: ");

            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length: ");

            double length = double.Parse(Console.ReadLine());

            double widthSquare = Math.Pow(width, 2);
            double lengthSquare = Math.Pow(length, 2);

            double sum = widthSquare + lengthSquare;
            double diagonal = Math.Sqrt(sum);

            Console.WriteLine($"Diagonal is equal: {diagonal} ");

            Console.WriteLine("Task 3 completed.");
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
        }

        public void FourthTask()
        {
            int a;
            string b;
            double c;

            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;

            Console.WriteLine("Task 4 completed.");
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
        }

        public void FifthTask()
        {
            Console.WriteLine("Please enter your name: ");
            Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            short userAge = short.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your phone number: ");
            int userPhoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your weight: ");
            double userWeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your gender (m or k): ");
            char userGender = char.Parse(Console.ReadLine());

            Console.WriteLine("Task 5 completed.");
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();
            

        }
    }
}
