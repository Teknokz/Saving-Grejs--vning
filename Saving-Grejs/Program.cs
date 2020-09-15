using System;
using System.Xml.Serialization;
using System.IO;
namespace Saving_Grejs
{
    class Program
    {
        static void Main(string[] args)
        {
        //    FPS myFPS = new FPS();
        //    myFPS.HP = 100;
        //    myFPS.x = 0;
        //    myFPS.y = 13;
        //    myFPS.z = 12;

            XmlSerializer serializer = new XmlSerializer(typeof(FPS));

            FileStream file = File.Open("FPS.xml", FileMode.OpenOrCreate);

            FPS myFPS = (FPS) serializer.Deserialize(file, myFPS);

            file.Close();

        }
    }
}
