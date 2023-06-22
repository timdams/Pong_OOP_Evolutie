namespace _3_PongOOP_OOP
{
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