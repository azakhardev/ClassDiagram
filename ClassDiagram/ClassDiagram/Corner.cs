using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class Corner
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public int Size { get; set; } = 12;

        public string Position { get; set; } 

        public Corner(int x, int y)
        {
            this.X = x - this.Size ;
            this.Y = y - this.Size ;
        }

    }
}
