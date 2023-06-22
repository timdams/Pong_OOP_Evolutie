using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_OOPPongMultiballMetList_OOP
{
    class Balletje
    {
        static Random r = new Random();
        public Balletje()
        {
            X = r.Next(0, Console.WindowWidth);
            Y = r.Next(0, Console.WindowHeight);
            VectorX = r.Next(-2, 3);
            VectorY = r.Next(-2, 3);
        }

        //Eigenschappen
        public int X { get; set; }
        public int Y { get; set; }
        public int VectorX { get; set; }
        public int VectorY { get; set; }

        //Methoden
        public void Update()
        {
            if (X + VectorX >= Console.WindowWidth || X + VectorX < 0)
            {
                VectorX = -VectorX;
            }
            X = X + VectorX;


            if (Y + VectorY >= Console.WindowHeight || Y + VectorY < 0)
            {
                VectorY = -VectorY;
            }
            Y = Y + VectorY;
        }

        public void TekenOpScherm()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("O");
        }
    }
}
