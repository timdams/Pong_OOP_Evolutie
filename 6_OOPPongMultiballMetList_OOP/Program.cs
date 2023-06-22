using System.Collections.Generic;

namespace _6_OOPPongMultiballMetList_OOP
{ /* 
     *  Verandering tegenover vorige?
     *  
     * List<> is een een soort 'array on steroid' en laat ons toe veel leesbaardere code te schrijven.
     * We herschrijven voorgaande array-oplossing daarom nu met een List<>.
     * 
     * Merk op dat we nog steeds met fors mogen werken, maar tonen hier de meer leesbare foreach variant.
     *
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            const int AANTAL_BALLETJES = 100;

            List<Balletje> veelBalletjes = new List<Balletje>();
            for (int i = 0; i < AANTAL_BALLETJES; i++) //balletjes aanmaken
            {
                veelBalletjes.Add(new Balletje());
            }

            Console.CursorVisible = false;
            while (true)
            {
                foreach (var bal in veelBalletjes)
                {
                    bal.Update();
                    bal.TekenOpScherm();
                }
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}