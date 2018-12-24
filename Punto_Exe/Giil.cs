using System;

namespace Punto_Exe
{
   class Giil
   {
      public static void Menu()
      {
         int i, j;

         Console.SetCursorPosition(31, 2);
         Console.WriteLine("DONDE QUEDO EL 1?");
         Console.SetCursorPosition(23, 4);
         Console.WriteLine("(Presione 'Enter' para comenzar)");
         Console.ReadLine();
         Console.Clear();

         Console.SetCursorPosition(33, 1);
         Console.WriteLine("INSTRUCCIONES:");
         Console.SetCursorPosition(22, 4);
         Console.WriteLine("El juego consiste en tratar de adivinar");
         Console.SetCursorPosition(15, 5);
         Console.WriteLine("en qué posicion de la cuadricula se encuentra el 1.");
         Console.SetCursorPosition(15, 6);
         Console.WriteLine("Esto lo aras escribiendo las coordenadas del lugar");
         Console.SetCursorPosition(26, 7);
         Console.WriteLine("en donde creas que esta el 1");
         Console.ReadLine();
         Console.SetCursorPosition(33, 9);
         Console.WriteLine("Estas listo?...");
         Console.ReadLine();
         Console.Clear();

         Console.SetCursorPosition(33, 1);
         Console.WriteLine("DIFICULTAD:");
         Console.SetCursorPosition(29, 3);
         Console.WriteLine("Facil => Presione 1");
         Console.SetCursorPosition(26, 4);
         Console.WriteLine("Intermedio => Presione 2");
         Console.SetCursorPosition(28, 5);
         Console.WriteLine("Dificil => Presione 3");
         Console.SetCursorPosition(33, 7);
         Console.Write("dificultad: ");
         int dificultad = Convert.ToInt32(Console.ReadLine());
         Console.Clear();

         if (dificultad == 1)
         {
            int t = 0;

            int[,] matriz = new int[10, 10];

            for (i = 0; i < 10; i++)
            {
               for (j = 0; j < 10; j++)
               {
                  matriz[j, i] = t++;
               }
            }


            Console.Clear();

            for (i = 0; i < 10; i++)
            {
               for (j = 0; j < 10; j++)
               {
                  if (matriz[j, i] == 53)
                  {
                     Console.Write("1");
                  }
                  else
                  {
                     Console.Write("l");
                  }
               }
               Console.WriteLine();
            }

            for (i = 0; i < 10; i++)
            {
               Console.SetCursorPosition((10 + 1), i);
               Console.WriteLine(i + "  ");
               Console.SetCursorPosition(13, 5);
               Console.WriteLine("Y");
            }

            for (i = 0; i < 10; i++)
            {
               Console.SetCursorPosition(i, (10 + 1));
               Console.WriteLine(i + "  ");
               Console.SetCursorPosition(5, 13);
               Console.WriteLine("X");
            }
            Console.SetCursorPosition(20, 3);
            Console.Write("Ingrese coordenada X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(20, 5);
            Console.Write("Ingrese coordenada Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (matriz[x, y] == 53)
            {
               Console.SetCursorPosition(20, 7);
               Console.WriteLine("ES CORRECTO!");
            }
            else
            {
               Console.SetCursorPosition(20, 7);
               Console.WriteLine("Fallaste! Comprate lentes :v");
               Console.SetCursorPosition(20, 8);
               Console.WriteLine("Presiona 'Enter' para salir del juego.");
               Console.SetCursorPosition(20, 9);
               Console.WriteLine("(No, aqui no se da otra oportunidad -u-)");
            }
            Console.ReadLine();
         }

         if (dificultad == 2)
         {
            int t = 0;
            int[,] matriz = new int[20, 20];

            for (i = 0; i < 20; i++)
            {
               for (j = 0; j < 20; j++)
               {
                  matriz[j, i] = t++;
               }
            }

            Console.Clear();

            for (i = 0; i < 20; i++)
            {
               for (j = 0; j < 20; j++)
               {
                  if (matriz[j, i] == 64)
                  {
                     Console.Write("1  ");
                  }
                  else
                  {
                     Console.Write("l  ");
                  }
               }
               Console.WriteLine();
            }

            for (i = 0; i < 20; i++)
            {
               Console.SetCursorPosition((60 + 1), i);
               Console.WriteLine(i);
               Console.SetCursorPosition(65, 10);
               Console.WriteLine("Y");
            }

            Console.SetCursorPosition(0, 21);
            Console.WriteLine("0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19");
            Console.SetCursorPosition(30, 23);
            Console.WriteLine("X");

            Console.SetCursorPosition(1, 27);
            Console.Write("Ingrese coordenada X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(1, 29);
            Console.Write("Ingrese coordenada Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (matriz[x, y] == 64)
            {
               Console.SetCursorPosition(27, 33);
               Console.WriteLine("ES CORRECTO!");
               Console.SetCursorPosition(15, 35);
               Console.WriteLine("Presiona 'Enter' para salir del juego.");
            }
            else
            {
               Console.SetCursorPosition(27, 33);
               Console.WriteLine("Fallaste! Comprate lentes :v");
               Console.SetCursorPosition(23, 35);
               Console.WriteLine("Presiona 'Enter' para salir del juego.");
               Console.SetCursorPosition(23, 37);
               Console.WriteLine("(No, aqui no se da otra oportunidad -u-)");
            }
            Console.ReadLine();
         }

         if (dificultad == 3)
         {
            int t = 0;
            int[,] matriz = new int[25, 25];

            for (i = 0; i < 25; i++)
            {
               for (j = 0; j < 25; j++)
               {
                  matriz[j, i] = t++;
               }
            }


            Console.Clear();

            for (i = 0; i < 25; i++)
            {
               for (j = 0; j < 25; j++)
               {
                  if (matriz[j, i] == 234)
                  {
                     Console.Write("1  ");
                  }
                  else
                  {
                     Console.Write("l  ");
                  }
               }
               Console.WriteLine();
            }

            for (i = 0; i < 25; i++)
            {
               Console.SetCursorPosition((74 + 1), i);
               Console.WriteLine(i);
               Console.SetCursorPosition(80, 12);
               Console.WriteLine("Y");
            }

            Console.SetCursorPosition(0, 26);
            Console.WriteLine("0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24");
            Console.SetCursorPosition(35, 28);
            Console.WriteLine("X");

            Console.SetCursorPosition(1, 32);
            Console.Write("Ingrese coordenada X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(1, 34);
            Console.Write("Ingrese coordenada Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (matriz[x, y] == 234)
            {
               Console.SetCursorPosition(27, 38);
               Console.WriteLine("ES CORRECTO!");
               Console.SetCursorPosition(15, 40);
               Console.WriteLine("Presiona 'Enter' para salir del juego.");
            }
            else
            {
               Console.SetCursorPosition(27, 38);
               Console.WriteLine("Fallaste! Comprate lentes :v");
               Console.SetCursorPosition(23, 40);
               Console.WriteLine("Presiona 'Enter' para salir del juego.");
               Console.SetCursorPosition(23, 42);
               Console.WriteLine("(No, aqui no se da otra oportunidad -u-)");
            }
            Console.ReadLine();
         }
      }
   }
}