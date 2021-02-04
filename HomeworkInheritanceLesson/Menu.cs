using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInheritanceLesson
{
    public class Menu
    {
        private Storage[] devices;
        private File[] files; 
        public Menu(Storage[] devices)
        {
            this.devices = devices;
        }
        public Menu(Storage[] devices, File[] files)
        {
            this.devices = devices;
            this.files = files;
        }

        public void DrawMenu()
        {
            Console.WriteLine
                (
                    "Выберете носитель:\n"+
                    "1 -  Флеш память\n" +
                    "2 -  DVD диск\n" +
                    "3 -  HDD внешний носитель\n"+
                    "0 - Выход"

                );
        }
        public void Handler()
        {
            string key = "";
            while (key != "0")
            {
                
                key = Console.ReadLine();
                Console.Clear();
                switch (key)
                {
                    case "1":                        
                        devices[0].DeviceInfo();
                        devices[0].CopyingData(files);
                        Console.WriteLine("При передачи 565 ГБ данных остаток свободной памяти = " + devices[0].FreeMemoryOnTheDeviceInfo(files) + " МБ");
                        break;
                    case "2":                        
                        devices[1].DeviceInfo();
                        devices[1].CopyingData(files);
                        Console.WriteLine("При передачи 565 ГБ данных остаток свободной памяти = " + devices[1].FreeMemoryOnTheDeviceInfo(files) + " МБ");
                        break;
                    case "3":                        
                        devices[2].DeviceInfo();
                        devices[2].CopyingData(files);
                        Console.WriteLine("При передачи 565 ГБ данных остаток свободной памяти = " + devices[2].FreeMemoryOnTheDeviceInfo(files) + " МБ");
                        break;
                    default:
                        Console.WriteLine("Не верный ввод!\n");                        
                        DrawMenu();
                        break;
                }
                
            }

        }



    }
}
