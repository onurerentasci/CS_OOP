namespace OOP.Inheritance
{
    public class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw() // virtual ifadesi varsayılan programda değişiklik yapmaz, alt sınıfta draw ifadesini override yapmayı sağlar
        {
            System.Console.WriteLine("Base Class drawing tasks...");
        }
    }
}