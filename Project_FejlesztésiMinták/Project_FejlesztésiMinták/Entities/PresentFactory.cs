using Factory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FejlesztésiMinták.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color BoxColor { get; set; }
        public Color WrapColor { get; set; }
        public Toy CreateNew()
        {
            return new Present(BoxColor, WrapColor);
        }

    }
}
