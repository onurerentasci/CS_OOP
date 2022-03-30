using System;

namespace OOP.Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            //virtualKeyboard();

            var shapes = new List<Shape>()
            {
                new Rectangle(),
                new Circle(),
                new Triangle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.ReadKey();
        }

        private static void virtualKeyboard()
        {
            var _s1 = new Rectangle(); // _s1.x, _s1.y gibi ifadeleri artık kullanabiliyoruz
            var _s2 = new Circle();

            _s1.x = 10;
            _s1.y = 200;
            Console.WriteLine("{0},{1}", _s1.x, _s1.y);
            _s1.Draw();

            _s2.x = 5;
            _s2.y = 55;
            Console.WriteLine("{0},{1}", _s2.x, _s2.y);
            _s2.Draw();

            new Triangle().Draw();
        }
    }
}