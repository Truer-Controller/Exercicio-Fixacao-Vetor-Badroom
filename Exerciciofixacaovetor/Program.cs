using System;

namespace Exerciciofixacaovetor
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] studentVect = new Student[10];

            Console.Write("Quantos quartos serão alugados: ");
            int numberBadrooms = int.Parse(Console.ReadLine());

            for(int i = 0; i < numberBadrooms; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}:");
                Console.Write("Name: ");
                string nameStudent = Console.ReadLine();
                Console.Write("Mail: ");
                string mailStudent = Console.ReadLine();
                Console.Write("Badroom: ");
                int badroom = int.Parse(Console.ReadLine());
                studentVect[badroom] = new Student(nameStudent, mailStudent);
            }
            Console.WriteLine("Occupied Room: ");
            for(int i = 0; i < 10; i++)
            {
                if(studentVect[i] != null)
                {
                    Console.WriteLine(i + ": " + studentVect[i]);
                }
            }

        }
    }
}
