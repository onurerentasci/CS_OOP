using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Circle : Shape // shape bulundurduğu tüm özellikleri circlea geçirdi
    {
        public override void Draw()
        {
            System.Console.WriteLine("Circle drawing task...");
            //base.Draw();
        }
    }
}
