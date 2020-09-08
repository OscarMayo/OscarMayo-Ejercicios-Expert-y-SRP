using System;
using System.Collections;
using System.Text;

namespace juego
{
    class Impresor
    {
        public void Printer(bool[,] b,int width,int height)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                b=Logica.Logic(b);
                Thread.Sleep(300);
            }
        }
    }