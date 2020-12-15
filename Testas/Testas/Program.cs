using System;

namespace Testas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Įrašykite raidę 'a'");
            var a = Console.ReadLine();
            Console.WriteLine("Įrašykite raidę 'b'");
            var b = Console.ReadLine();
            Console.WriteLine("Įrašykite raidę 'c'");
            var c = Console.ReadLine();

            Console.WriteLine(c + " " + b + " " + a);
            Console.ReadLine();



            Console.WriteLine("2 užduotis: Tikriname ar studentas gali lankyti kursą");

            int MarksInMaths = 72;
            int MarksInPhy = 65;
            int MarksInChem = 51;

            if (MarksInMaths + MarksInPhy + MarksInChem >= 180)
            {
                Console.WriteLine("Candidate is eligible for admission");

                
            }

            else if (MarksInMaths + MarksInPhy  >= 140)
            {
                Console.WriteLine("Candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("Candidate is not eligible for admission");
            }




            Console.WriteLine("3 užduotis: Rasti sumą ir vidurkį");

            int[] numbers = new int[10];
            int sum = 0;

            Console.WriteLine("Įrašykite 10 skaičių");
            
            for (int i=1; i < 11; i++)
            {
                Console.WriteLine("Number-" + i +":");

                 numbers[i] = Console.ReadLine(numbers);


                sum += numbers[i];
                
            }


            Console.WriteLine("The sum of 10 no is: " + sum);

            double average = sum / 10;

            Console.WriteLine("The Average is: " + average);






        }
    }
}
