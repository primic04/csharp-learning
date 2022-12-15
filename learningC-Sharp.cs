using System;
namespace learningCsharp
{
    class program
    {
        static void Main(string[] args)
        {





  Console.Read(); 
        }        
    }
}


            /*
            int nbr = 4;
            int resultat;

            resultat = nbr * 10;

            Console.WriteLine(resultat);
            string str = "je chosis le nombre "  + nbr + " et est egale a " + resultat;
            Console.WriteLine(str);
            
            int nbr1 = 1;
            int nbr2 = 2;
            int nbr3 = 3;
            int nbr4 = 4;
            int total;
            total = nbr2 / nbr1 * (nbr3 + nbr4);
            Console.WriteLine(total);
            
            string dan_name = "danny";
            int age_danny = 28;
            float taille_danny = 1.85f;

            Console.WriteLine(dan_name + age_danny + taille_danny);

            string melee_name = "melee";
            int age_melee = 26;
            float taille_melee = 1.75f;
            Console.WriteLine(melee_name + age_melee + taille_melee);

            string sam_name = "samuel";
            int age_sam = 24;
            float taille_sam = 1.70f;
            Console.WriteLine(sam_name + age_sam + taille_sam);

            string danna_name = "danny-ann";
            int age_danna = 20;
            float taille_danna = 1.60f;
            Console.WriteLine((danna_name) + (age_danna) + (taille_danna));
//probleme pour espacer les variable dans le console writeline

            int un = 1;
            int deux = 2;
            int trois = 3;
            int quatre = 4;
            int cinq = 5;
            int resultat;

            resultat = 1 + (2 * 10) / 4;
            Console.Write(resultat);

          int nbr1 = 10;
          int nbr2 = 5;
          int nbr3 = 2;
          int resultat;
          int total;

          resultat = nbr2 * nbr1;

          Console.WriteLine(resultat * nbr3 / (nbr1 / nbr3));// = 20
          total = resultat * nbr3 / (nbr1 / nbr3) / 8;
          Console.WriteLine(total);// = 2

          int user0 = 31;
            int user1 = 18;
            //int user2 = 13;
            //int user3 = 39;
            //int user4 = 27;
            //int user5 = 17;

            if(user0 >= 18)
            {
                Console.Write("acces granted for user0: welcome");
            }
            else
            {
                Console.Write("Access denied");
            }

            //user1-user4 permission majority with if/else...
        {
            
            int user1 = 27;

            if(user1 >= 18)
            {
                Console.WriteLine("Acces granted: welcome user1");
            }
            else
            {
                Console.WriteLine("acces denied: user1: come back when your got required age");
            }
        }
        {
            int user2 = 17;

            if(user2 >= 18)
            {
                Console.WriteLine("acces granted: welcome user2");
            }
            else
            {
                Console.WriteLine("acces denied to user2: you are minor");
            }
        }
        {
            int user3 = 36;

            if(user3 >= 18)
            {
                Console.WriteLine("acces granted: user3 welcome");
            }
            else
            {
                Console.WriteLine("acces denied: user3 dont have the require age");
            }
        }
        {
            int user4 = 14;

            if(user4 >= 18)
            {
                Console.WriteLine("acces granted to user 4: welcome");
            }
            else
            {
                Console.WriteLine("acces denied to user4: come back when you are major");
            }
        }

        // security age usa can 

            int usa_major = 21;
            int can_major = 18;
            int user1 = 15;
            int user2 = 19;
            int user3 = 27;

            {

                if(user1 >= can_major)
                {
                    Console.WriteLine("vous etes majeur au canada");
                }
                else if(user1 >= usa_major)
                {
                    Console.WriteLine("vous etes majeur au usa");
                }
                else
                {
                    Console.WriteLine("user1: vous devez attendre quelques années encore");
                }
            }

            {
                if(user2 >= can_major)
                {
                    Console.WriteLine("user2: vous etes majeur au canada: acces granted");
                }
                else if(user2 >= usa_major)
                {
                    Console.WriteLine("vous etes majeur au usa");
                }
                else
                {
                    Console.WriteLine("vous devez attendre quelques années encore");
                }
            }

            {
                if(user3 >= can_major || user3 >= usa_major)
                {
                    Console.WriteLine("user3: vous ete majeur partout sur terre: access granted");
                }
                else
                {
                    Console.WriteLine("user3: vous etes majeur au canada: acces granted");
                }

            }
            */