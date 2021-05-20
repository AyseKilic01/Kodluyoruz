using Interfaces.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Concrete
{
    class Focus : ICar
    {
        private string color;
        public string MyColor { get=> color; set => color = value; }

        public void colorCar(string color)
        {
            MyColor = color;
            Console.WriteLine(this.MyColor);
        }

        public int wheelCount()
        {
            return 6;
        }
    }
}
