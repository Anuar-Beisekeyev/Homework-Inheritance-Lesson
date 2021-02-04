using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInheritanceLesson
{
    public class DVD : Storage
    {
        public double ReadAndWriteSpeed { get; set; }
        public double TypeDVD { get; set; }

        public override void CopyingData(File[] files)
        {
            double fileSize = 0;
            int quantity = 0;

            while (fileSize < TypeDVD)
            {
                fileSize += files[quantity++].Size;
            }

            if (fileSize > TypeDVD)
            {
                fileSize -= files[0].Size;
                quantity--;
            }

            int dataTransferTime = ((int)TypeDVD / (int)ReadAndWriteSpeed) /60;
            int countFlash = 565 * 1024 / (int)TypeDVD + 1;

            Console.WriteLine($"На носитель  {MediaName} модели {Model} было скачено {quantity} файлов с размером  {files[0].Size}  МБ.");
            Console.WriteLine($"Для передачи 565 ГБ данных по {files[0].Size} МБ файлов потребуется {MediaName} в количестве {countFlash} (шт).");
            Console.WriteLine($"Время затраченое на передачу данных в {MediaName} в количестве одной еденицы = {dataTransferTime} мин");

        }

        public override void DeviceInfo()
        {
            
            Console.WriteLine("Устройство: " + MediaName);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Размер памяти: " + (int)TypeDVD + " МБ");
            Console.WriteLine("Скорость передачи данных: " + ReadAndWriteSpeed + " МБ/сек");

        }

        public override double FreeMemoryOnTheDeviceInfo(File[] files)
        {
            double fileSize = 0;
            int quantity = 0;

            while (fileSize < TypeDVD)
            {
                fileSize += files[quantity++].Size;
            }
            if (fileSize > TypeDVD)
            {
                fileSize -= files[0].Size;
                quantity--;
            }
            int countFlash = 565 * 1024 / (int)TypeDVD + 1;
            double freeMemory = (TypeDVD * countFlash) - (565 * 1024);
            return freeMemory;
        }

        public override double GettingMemorySize()
        {
            return TypeDVD;
        }

    }
}
