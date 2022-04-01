namespace OOP.Inheritance
{
    public class Square : Rectangle // sen bir karesin senin temel sınıfın dikdörtgen
    {

        public Square()
        {
                
        }

        public Square(int x, int y) : base(x, y) // ifadeyi base classa yönlendiriyoruz
        {

        }

        new public void Calculate()
        {
            System.Console.WriteLine("Calculated by Square...");
        }


    }
}