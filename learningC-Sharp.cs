using System;
namespace learningCsharp
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("salut salut salut");

//variable de type bool, prend 1 bytes de mémoire
            bool homme = true;
            Console.WriteLine(homme);

//variable de type int, prend 4 bytes en mémoire
            int age = 20;
            Console.WriteLine(age);

// variable de type char, prend 2 bytes en memoire
            char mon_char = 'a';
            Console.WriteLine(mon_char);

//variable de type string, prend 20+ bytes en memoire
            string mon_string = "michael";
            Console.WriteLine(mon_string);


           Console.ReadKey(); 
        }
    }
}