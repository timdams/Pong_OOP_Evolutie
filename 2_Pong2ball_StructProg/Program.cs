namespace _2_Pong2ball_StructProg
{
    /* 
     *  Verandering tegenover vorige?
     *  
     *  Tweede ball toegevoegd. Dit vereist dat we alle variabelen (X,Y,vectorX en vectorY) 
     *  opnieuw aanmaken om daarin de eigenschappen van de 2e bal te bewaren.
     *  Vervolgens moeten we ook de code voor de grenscontroles én de update toevoegen voor deze nieuwe
     *  variabelen.
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int balX = 20;
            int balY = 20;
            int vectorX = 2;
            int vectorY = 1;

            int bal2X = 10;
            int bal2Y = 8;
            int vector2X = 2;
            int vector2Y = -1;

            while (true)
            {
                if (balX + vectorX >= Console.WindowWidth || balX + vectorX < 0)
                {
                    vectorX = -vectorX;
                }
                if (bal2X + vector2X >= Console.WindowWidth || bal2X + vector2X < 0)
                {
                    vector2X = -vector2X;
                }

                balX = balX + vectorX;
                bal2X = bal2X + vector2X;

                if (balY + vectorY >= Console.WindowHeight || balY + vectorY < 0)
                {
                    vectorY = -vectorY;
                }
                if (bal2Y + vector2Y >= Console.WindowHeight || bal2Y + vector2Y < 0)
                {
                    vector2Y = -vector2Y;
                }

                balY = balY + vectorY;
                bal2Y = bal2Y + vector2Y;


                Console.SetCursorPosition(balX, balY);
                Console.Write("O");

                Console.SetCursorPosition(bal2X, bal2Y);
                Console.Write("X");
                System.Threading.Thread.Sleep(50); //50 ms wachten
                Console.Clear();
            }
        }
    }
}