using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInheritanceLesson
{
    public class Flash : Storage
    {
        public double SpeedUSB { get; set; } 
        public double MemorySize { get; set; } 

        public override void CopyingData(File[] files)
        {
            //for (int i = 0; i < files.Length; i++)
            //{
            //    //Console.Write(files[i].Size);

            //}
            double fileSize = 0;
            int quantity = 0;

            while (fileSize < MemorySize)
            {
                fileSize += files[quantity++].Size;
            }
            if (fileSize > MemorySize)
            {
                fileSize -= files[0].Size;
                quantity--;
            }
            double dataTransferTime = MemorySize / SpeedUSB;
            int countFlash = 565 * 1024 /(int)MemorySize + 1;
            Console.WriteLine($"На носитель  {MediaName} модели {Model} было скачено {quantity} файлов с размером  {files[0].Size}  МБ.") ;
            Console.WriteLine($"Для передачи 565 ГБ данных по {files[0].Size} МБ файлов потребуется {MediaName} в количестве {countFlash} (шт).");
            Console.WriteLine($"Время затраченое на передачу данных в {MediaName} в количестве одной еденицы = {dataTransferTime} сек");



        }

        public override void DeviceInfo()
        {
           
            Console.WriteLine("Устройство: " + MediaName);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Размер памяти: " + MemorySize + " МБ");
            Console.WriteLine("Скорость передачи данных: " + SpeedUSB + " МБ/сек");
        }

        public override double FreeMemoryOnTheDeviceInfo(File[] files)
        {
            double fileSize = 0;
            int quantity = 0;

            while (fileSize < MemorySize)
            {
                fileSize += files[quantity++].Size;
            }
            if (fileSize > MemorySize)
            {
                fileSize -= files[0].Size;
                quantity--;
            }
            int countFlash = 565 * 1024 / (int)MemorySize + 1;
            double freeMemory = (MemorySize * countFlash) - (565 * 1024);
            return freeMemory;
        }

        public override double GettingMemorySize()
        {
            return MemorySize;
        }


    }
}
