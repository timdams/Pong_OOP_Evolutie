namespace _3_PongOOP_OOP
{    /* 
     *  Verandering tegenover vorige?
     *  
     *  We plaatsen alle logica voor het balletje in een aparte klasse in het bestand Balletje.cs.
     *  We vereenvoudigen de code in de main daardoor (het tweede balletje is even verdwenen en komt in volgende project terug)
     *  Merk op dat nu onze loop veel leesbaarder wordt, daar alle "ingewikkelde" functionaliteit
     *  verstopt (encapsulatie) zit in de Update methode van de klasse Balletje.
     *
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Balletje bal1 = new Balletje();
            bal1.X = 20;
            bal1.Y = 20;
            bal1.VectorX = 2;
            bal1.VectorY = 1;

            while (true)
            {
                bal1.Update();
                bal1.TekenOpScherm();

                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}