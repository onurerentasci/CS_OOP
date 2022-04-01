namespace OOP.Inheritance
{
    public class Rectangle : Shape // : ifadesinden sonra yazılan classta bulunan bütün özellikler kalıtımla mevcut classa eklenir
    {
        public Rectangle()
        {

        }

        public Rectangle(int x, int y) : base(x, y) // doğrudan x ve y yi base e parametre olarak yönlendirir
        {                                           // base e göndermediğimiz taktirde içerisinde kod olmayacağı için çalışmaz
            this.x = x;
            this.y = y;
        }

        public sealed override void Draw() // sealed ifadesi ile sınıf mühürlenir, kalıtım özelliği kısıtlanır
        {
            System.Console.WriteLine("Rectangle drawing task...");
            //base.Draw(); // bu satır isteğe bağlı
        }

        public void Calculate()
        {
            System.Console.WriteLine("Calculated by Rectangle...");
        }
    }
}