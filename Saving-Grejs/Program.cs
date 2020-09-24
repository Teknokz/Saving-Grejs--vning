using System;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
namespace Saving_Grejs
{
    class Program
    {
        static void Main(string[] args)
        {
       FPS myFPS = new FPS();
       myFPS.HP = 100;
       myFPS.x = 0;
       myFPS.y = 13;
       myFPS.z = 12;

            System.Console.WriteLine("Hej och välkommen, vill du ändra värdena i myFPS?");
            System.Console.WriteLine("ja eller nej");
            
            string knas = Console.ReadLine();

            if(knas == "ja" || knas == "Ja")
            {
        
                System.Console.WriteLine("Vad vill du ändra HP till?");
                

                string input1 = Console.ReadLine();
                
                int.TryParse(input1, out myFPS.HP);

            
                System.Console.WriteLine("Vad vill du ändra x till?");
                

                string input2 = Console.ReadLine();
                
                int.TryParse(input2, out myFPS.x);

                System.Console.WriteLine("Vad vill du ändra y till?");
                

                string input3 = Console.ReadLine();
                
                int.TryParse(input3, out myFPS.y);

                System.Console.WriteLine("Vad vill du ändra z till?");
                

                string input4 = Console.ReadLine();
                
                int.TryParse(input4, out myFPS.z);

                System.Console.WriteLine("Sparar...");


            XmlSerializer Serializer = new XmlSerializer(typeof(FPS));


            FileStream file = File.Open(@"FPS.xml", FileMode.OpenOrCreate);

            Serializer.Serialize(file, myFPS);

            file.Close();
            }
            else
            {
                System.Console.WriteLine("Godnatt");
            }



        }
    }
}
