using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationNumber1
{
    public class Lines
    {
        public int Name { get; set; }
        public int NameOut { get; set; }
        public int Time { get; set; }
        public int NameIn { get; set; }
        public bool IsStart { get; set; }
        public bool IsFinish { get; set; }
    }
    public class Point
    {
        public int Name { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Rez { get; set; }
    }
    
}
