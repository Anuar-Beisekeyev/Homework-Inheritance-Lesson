using System;

namespace HomeworkInheritanceLesson
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int countFile = 565 * 1024 / 780 +1;
            //Console.WriteLine( countFile );

            File[] files = new File[countFile];
            for(int i = 0; i < files.Length; i++)
            {
                files[i] = new File();
            }
            
            Storage[] storage = new Storage[3];
            storage[0] = new Flash
            {
                MediaName = "Flash - память",
                Model = "Kingston DataTraveler Exodia",
                MemorySize = 8192,
                SpeedUSB = 640

            };
            storage[1] = new DVD()
            {
                MediaName = "DVD - диск",
                Model = "DVD+R TRACK standart",
                TypeDVD = 9000,
                ReadAndWriteSpeed = 11.08
            };
            storage[2] = new HDD()
            {
                MediaName = "HDD - память",
                Model = "Transcend TS1TSJ25H3P",
                SpeedHHD = 60,
                NumberOfSections = 7,
                VolumeOfSections = 149796
            };

            

            Menu menu = new Menu(storage,files);            
            menu.DrawMenu();
            menu.Handler();


           // Console.ReadLine();

        }
    }
}
