using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInheritanceLesson
{
    public abstract class Storage
    {
        public string MediaName { get; set; }
        public string Model { get; set; }

        public abstract void DeviceInfo();
        public abstract double FreeMemoryOnTheDeviceInfo(File[] files);
        public abstract double GettingMemorySize();
        public abstract void CopyingData(File[] files);


    }
}
