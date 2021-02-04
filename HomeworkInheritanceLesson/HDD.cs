using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInheritanceLesson
{
    public class HDD : Storage
    {
        public double SpeedHHD { get; set; } 
        public int NumberOfSections { get; set; }
        public double VolumeOfSections { get; set; }

        public override void CopyingData(File[] files)
        {
            double fileSize = 0;
            int quantity = 0;

            while (fileSize < NumberOfSections * VolumeOfSections)
            {
                if (quantity >= files.Length)
                    break;
                fileSize += files[quantity++].Size;           

            }
            if (fileSize > NumberOfSections * VolumeOfSections)
            {
                fileSize -= files[0].Size;
                quantity--;
            }
            int dataTransferTime = (NumberOfSections * (int)VolumeOfSections / (int)SpeedHHD) /60;
            int countFlash;

            if(565 * 1024 < NumberOfSections * VolumeOfSections)
            {
                countFlash = (NumberOfSections * (int)VolumeOfSections) / (565 * 1024);
            }
            else
            {
                countFlash = (565 * 1024) / (NumberOfSections * (int)VolumeOfSections) + 1;
            }
            Console.WriteLine($"На носитель  {MediaName} модели {Model} было скачено {quantity} файлов с размером  {files[0].Size}  МБ.");
            Console.WriteLine($"Для передачи 565 ГБ данных по {files[0].Size} МБ файлов потребуется {MediaName} в количестве {countFlash} (шт).");
            Console.WriteLine($"Время затраченое на передачу данных в {MediaName} в количестве одной еденицы = {dataTransferTime} мин");

        }

        public override void DeviceInfo()
        {
            
            Console.WriteLine("Устройство: " + MediaName);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Размер памяти: " + NumberOfSections * VolumeOfSections + " МБ");
            Console.WriteLine("Скорость передачи данных: " + SpeedHHD + " МБ/сек");
        }

        public override double FreeMemoryOnTheDeviceInfo(File[] files)
        {
            double fileSize = 0;
            int quantity = 0;

            while (fileSize < NumberOfSections * VolumeOfSections)
            {
                if (quantity >= files.Length)
                    break;
                fileSize += files[quantity++].Size;

            }
            if (fileSize > NumberOfSections * VolumeOfSections)
            {
                fileSize -= files[0].Size;
                quantity--;
            }
            int dataTransferTime = (NumberOfSections * (int)VolumeOfSections / (int)SpeedHHD) / 60;
            int countFlash;

            if (565 * 1024 < NumberOfSections * VolumeOfSections)
            {
                countFlash = (NumberOfSections * (int)VolumeOfSections) / (565 * 1024);
            }
            else
            {
                countFlash = (565 * 1024) / (NumberOfSections * (int)VolumeOfSections) + 1;
            }
            double freeMemory = (NumberOfSections * VolumeOfSections * countFlash) - (565 * 1024);
            return freeMemory;
        }

        public override double GettingMemorySize()
        {
            return NumberOfSections * VolumeOfSections;
        }
    }
}
