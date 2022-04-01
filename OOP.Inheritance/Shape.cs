namespace OOP.Inheritance
{
    public class Shape
    {
        public Shape()
        {

        }

        public Shape(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int x { get; set; }
        public int y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw() // virtual ifadesi varsayılan programda değişiklik yapmaz, alt sınıfta draw ifadesini override yapmayı sağlar
        {
            System.Console.WriteLine("Base Class drawing tasks...");
        }

        public void WorkWithDifferentObject(object o)
        {
            Shape shapeFromParameter = o as Shape; // obje şekile dönüştü artık x ve y değerlerine sahip
            shapeFromParameter.Draw();

        }
    }
}