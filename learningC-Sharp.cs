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
            //int age;
            //Console.WriteLine(age);

// variable de type char, prend 2 bytes en memoire
            char mon_char = 'a';
            Console.WriteLine(mon_char);

//variable de type string, prend 20+ bytes en memoire
            string mon_string = "JeuVideo";
            Console.WriteLine(mon_string);

//variable de type sbyte pour les chiffre entre 0-255, prend en mémoire 1 bytes
            sbyte my_number = 44;
            Console.WriteLine(my_number);

//variable de type float, prend en mémoire 4 bytes et on dois mettre un f a la fin du float
            float my_float = 1.44f;
            Console.WriteLine(my_float);

            string prenom = "michael";
            Console.WriteLine(prenom);
            string nom = "turcotte-coulombe";
            Console.WriteLine(nom);
            Console.WriteLine(prenom + nom);

//un variable peut-être déclaré comme suit
            int age;
            age = 27;
            Console.WriteLine(age);


           Console.ReadKey(); 
        }
    }
}