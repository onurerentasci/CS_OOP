namespace OOP.Inheritance
{
    public class Rectangle : Shape // : ifadesinden sonra yazılan classta bulunan bütün özellikler kalıtımla mevcut classa eklenir
    {
        public override void Draw()
        {
            System.Console.WriteLine("Rectangle drawing task...");
            //base.Draw(); // bu satır isteğe bağlı
        }
    }
}