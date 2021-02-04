using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkInheritanceLesson
{
    public class File
    {
        private double size;
        public File()
        {
            size = 780;
        }
        public File(double size)
        {
            Size = size;
        }
        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

    }
}
