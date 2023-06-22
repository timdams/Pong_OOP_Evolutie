namespace _4_PongOoop2ball_OOP
{    /* 
     *  Verandering tegenover vorige?
     *  
     *  Dankzij de kracht van OOP is een 2e bal toevoegen nu veel eenvoudiger. 
     *  Merk vooral op hoe weinig code er in de while-loop bijkomt.
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

            Balletje bal2 = new Balletje();
            bal2.X = 10;
            bal2.Y = 8;
            bal2.VectorX = 2;
            bal2.VectorY = -1;

            while (true)
            {
                bal1.Update();
                bal2.Update(); //zo simpel!
                bal1.TekenOpScherm();
                bal2.TekenOpScherm(); //wow, zooo simpel :)
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}