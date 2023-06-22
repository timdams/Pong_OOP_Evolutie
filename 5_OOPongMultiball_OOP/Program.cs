namespace _5_OOPongMultiball_OOP
{
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