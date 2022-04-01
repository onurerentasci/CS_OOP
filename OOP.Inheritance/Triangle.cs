using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Triangle : Shape
    {

        public Triangle()
        {

        }

        public Triangle(int x, int y)
        {

        }

        public override void Draw()
        {
            System.Console.WriteLine("Triangle drawing task..."); // önce bu işlem
            base.Draw(); // ardından bu ancak zorunlud eğil
        }
    }
}
