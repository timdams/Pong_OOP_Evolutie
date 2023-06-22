namespace _5_OOPongMultiball_OOP
{    /* 
     *  Verandering tegenover vorige?
     *  
     * In de klasse Balletje hebben we 1 aspect toegevoegd: een zogenaamde constructor. Deze methode 
     * wordt enkel aangeroepen wanneer we een new object aanmaken. In het geval van Balletje zullen
     * we in de constructor het object een willekeurige start-positie en vector geven.
     * Merk op dat dit mogelijk stilstaande balletjes zal geven.
     * 
     * We voelen nu de kracht van OOP wanneer we 100 balletjes objecten in een array toevoegen.
     *
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            const int AANTAL_BALLETJES = 100;
            
            Balletje[] veelBalletjes = new Balletje[AANTAL_BALLETJES];
            for (int i = 0; i < veelBalletjes.Length; i++) //balletjes aanmaken
            {
                veelBalletjes[i] = new Balletje(); //zie klasse: extra constructor gemaakt die willekeurige startcoord kiest
            }

            Console.CursorVisible = false;
            while (true)
            {
                for (int i = 0; i < veelBalletjes.Length; i++)
                {
                    veelBalletjes[i].Update(); //update alle balletjes
                }
                for (int i = 0; i < veelBalletjes.Length; i++)
                {
                    veelBalletjes[i].TekenOpScherm(); //teken alle balletjes
                }
                System.Threading.Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}