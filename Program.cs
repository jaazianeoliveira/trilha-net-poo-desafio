using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Nokia("123456789", "Nokia", "3310");
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            Smartphone iphone = new Iphone("987654321", "Apple", "iPhone 12");
            iphone.Ligar();
            iphone.InstalarAplicativo("WhatsApp");
        }
    }
}
