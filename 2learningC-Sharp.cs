using System;
namespace learningCsharp2
{
    class program
    {
        static void Main(string[] args)
        {


            int MicPts = 388;
            int AdvPts = 405;
            int PtsToReach = 400;
            int PtsNeeded;
            int WinPts;
            WinPts = MicPts - AdvPts;
            PtsNeeded = PtsToReach - MicPts;
            Console.WriteLine("vous avez " + MicPts + " point de classement ");

            if(MicPts >= PtsToReach)
            {
                Console.WriteLine("vous avez obtenu les point necessaire pour paaser au prochain niveau");
            }
            else if(AdvPts < MicPts)
            {
                Console.WriteLine("vous n'avez pas obtenu assez de point pour passer a l'autre niveau, Revenez quand ce sera fait.");
                Console.WriteLine("il vous manque: " + PtsNeeded + " point");
                Console.WriteLine("votre adversaire a gagner la manche avec: " + AdvPts + " points. il a donc " + WinPts + " pts de plus que vous ");
            }
            else
            {
                Console.WriteLine("vous n'avez pas obtenu assez de point, Revenez quand ce sera fait.");
                Console.WriteLine("il vous manque: " + PtsNeeded + " point");
            }

             


            Console.Read();
        }
    }
}
/*
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

*/