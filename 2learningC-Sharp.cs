using System;
namespace learningCsharp2
{
    class program
    {
        static void Main(string[] args)
        {
            string UserName = "Michael";
            string UserFamName = "T-C";
            sbyte UserAge = 27;
            float UserSize = 1.75f;
            byte UserWeight = 220;
            //bool homme = true;
            string UserSex = "homme";

            Console.WriteLine("VOICI VOTRE PROFIL COMPLET");
            Console.WriteLine("vous avez: " + UserAge + " ans");
            Console.WriteLine("un int fait " + (sizeof(int)) + " bytes");
            Console.WriteLine(UserSize + " metre");
            Console.WriteLine("votre poids est de: " + UserWeight + " lbs");
            Console.WriteLine(UserSex);
            Console.WriteLine("votre nom complet est: " + UserName + " " + UserFamName);

            Console.WriteLine("PROFIL COMPLETE...");


            Console.Read();
        }
    }
}