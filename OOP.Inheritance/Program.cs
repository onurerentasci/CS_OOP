using System;

namespace OOP.Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {

            var s1 = new Rectangle(10, 20);
            Console.WriteLine("{0},{1}",s1.x, s1.y);

            var s2 = new Circle(25, 55);
            Console.WriteLine("{0},{1}",s2.x, s2.y); // base classa döndürmediğimiz için default değeri olan 0, 0 değerlerini görürüz
                                                     // f12 ile doğrudan base classı görebilirsin
            var s3 = new Square(41, 50);
            Console.WriteLine("{0},{1}",s3.x, s3.y);

            s1.WorkWithDifferentObject(s2);

            //virtualKeyboard();


            Console.ReadKey();
        }

        private static void Polymorphism()
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(),
                new Circle(),
                new Triangle(),
                new Square()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            new Square().Calculate();
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