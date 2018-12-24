using System;
using System.Threading;
using System.Timers;

namespace Punto_Exe
{
   class adivina_un_numero
   {
      static public System.Timers.Timer atimer = new System.Timers.Timer();
      static public bool stop = true;
      public static void fondo()
      {
         Console.BackgroundColor = ConsoleColor.Gray;
         Console.SetBufferSize(168, 58);
         Console.SetWindowSize(168, 58);
      }

      public static void cuadro()
      {
         fondo();
         int x, y, z, a;
         x = 20;
         y = 55;
         z = 25 + x;
         a = 50 + y;
         Console.ForegroundColor = ConsoleColor.DarkRed;
         for (int i = x; i < z; i++)
         {
            Console.SetCursorPosition(y, i);
            Console.Write("║");
            Console.SetCursorPosition(a, i);
            Console.Write("║");
         }
         for (int i = y; i < a + 1; i++)
         {
            Console.SetCursorPosition(i, x);
            Console.Write("═");
            Console.SetCursorPosition(i, z);
            Console.Write("═");
         }
         Console.SetCursorPosition(55, 20);
         Console.Write("╔");
         Console.SetCursorPosition(105, 20);
         Console.Write("╗");
         Console.SetCursorPosition(55, 45);
         Console.Write("╚");
         Console.SetCursorPosition(105, 45);
         Console.Write("╝");
      }

      public static void texto()
      {
         fondo();
         Console.ForegroundColor = ConsoleColor.DarkRed;
         Console.SetCursorPosition(75, 23);
         Console.WriteLine("Bienvenido");
         Console.SetCursorPosition(60, 26);
         Console.WriteLine("Este es un juego que consiste en adivinar");
         Console.SetCursorPosition(60, 27);
         Console.WriteLine("numeros del 0 hasta el 100, se tiene 7");
         Console.SetCursorPosition(60, 28);
         Console.WriteLine("intentos.");
      }

      public static void numeros(object sender, EventArgs e)
      {
         atimer.Enabled = false;
         for (int i = 1; stop; i++)
         {
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.SetCursorPosition(15, 8);
            //Console.WriteLine("  ░░░░░░░░░░  ");
            //Console.SetCursorPosition(100, 18);
            //Thread.Sleep(50);
            //Console.WriteLine("       ▀▀▀▀▀  ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 9);
            //Console.WriteLine(" ░░░░░░░░░░░░ ");
            //Console.SetCursorPosition(100, 19);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 10);
            //Console.WriteLine("░░░░░░░░░░░░░░");
            //Console.SetCursorPosition(100, 20);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 11);
            //Console.WriteLine("░░░░      ░░░░");
            //Console.SetCursorPosition(100, 21);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 12);
            //Console.WriteLine(" ░░░      ░░░ ");
            //Console.SetCursorPosition(100, 22);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 13);
            //Console.WriteLine("  ░░░░░░░░░░  ");
            //Console.SetCursorPosition(100, 23);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀  ");
            //Console.SetCursorPosition(15, 14);
            //Console.WriteLine(" ░░░      ░░░ ");
            //Console.SetCursorPosition(100, 24);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 15);
            //Console.WriteLine("░░░░      ░░░░");
            //Console.SetCursorPosition(100, 25);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 16);
            //Console.WriteLine("░░░░░░░░░░░░░░");
            //Console.SetCursorPosition(100, 26);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 17);
            //Console.WriteLine(" ░░░░░░░░░░░░ ");
            //Console.SetCursorPosition(100, 27);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 18);
            //Console.WriteLine("  ░░░░░░░░░░  ");
            //Console.SetCursorPosition(100, 28);
            //Thread.Sleep(50);
            //Console.WriteLine("       ▀▀▀▀▀  ");
            //Thread.Sleep(50);
            //Console.ResetColor();
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.SetCursorPosition(15, 8);
            //Console.WriteLine("  ░░░░░░░░░░  ");
            //Console.SetCursorPosition(100, 18);
            //Thread.Sleep(50);
            //Console.WriteLine("       ▀▀▀▀▀  ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 9);
            //Console.WriteLine(" ░░░░░░░░░░░░ ");
            //Console.SetCursorPosition(100, 19);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 10);
            //Console.WriteLine("░░░░░░░░░░░░░░");
            //Console.SetCursorPosition(100, 20);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 11);
            //Console.WriteLine("░░░░      ░░░░");
            //Console.SetCursorPosition(100, 21);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 12);
            //Console.WriteLine(" ░░░      ░░░ ");
            //Console.SetCursorPosition(100, 22);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 13);
            //Console.WriteLine("  ░░░░░░░░░░  ");
            //Console.SetCursorPosition(100, 23);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀  ");
            //Console.SetCursorPosition(15, 14);
            //Console.WriteLine(" ░░░      ░░░ ");
            //Console.SetCursorPosition(100, 24);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 15);
            //Console.WriteLine("░░░░      ░░░░");
            //Console.SetCursorPosition(100, 25);
            //Thread.Sleep(50);
            //Console.WriteLine("          ▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 16);
            //Console.WriteLine("░░░░░░░░░░░░░░");
            //Console.SetCursorPosition(100, 26);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 17);
            //Console.WriteLine(" ░░░░░░░░░░░░ ");
            //Console.SetCursorPosition(100, 27);
            //Thread.Sleep(50);
            //Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            //Thread.Sleep(50);
            //Console.SetCursorPosition(15, 18);
            //Console.WriteLine("  ░░░░░░░░░░  ");
            //Console.SetCursorPosition(100, 28);
            //Thread.Sleep(50);
            //Console.WriteLine("       ▀▀▀▀▀  ");
            //Thread.Sleep(50);
            //Console.ResetColor();
         }
      }

      public static void loading()
      {
         atimer.Elapsed += new ElapsedEventHandler(numeros);
         atimer.Interval = 1;
         atimer.Enabled = true;
         Console.CursorVisible = false;
         int acum = 0;
         for (int i = 0; i < 21; i++)
         {
            for (int j = 0; j < 5; j++)
            {
               Thread.Sleep(2);
            }

            Console.ResetColor();
            cuadro();
            Console.SetCursorPosition(i + 70, 35);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("░");
            Console.SetCursorPosition(75, 33);
            Console.Write(acum + "% LOADING");
            acum = acum + 5;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(15, 8);
            Console.WriteLine("  ░░░░░░░░░░  ");
            Console.SetCursorPosition(108, 18);
            Console.WriteLine("       ▀▀▀▀▀  ");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine(" ░░░░░░░░░░░░ ");
            Console.SetCursorPosition(108, 19);
            Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("░░░░░░░░░░░░░░");
            Console.SetCursorPosition(108, 20);
            Console.WriteLine("      ▀▀▀▀▀▀▀▀");
            Console.SetCursorPosition(15, 11);
            Console.WriteLine("░░░░      ░░░░");
            Console.SetCursorPosition(108, 21);
            Console.WriteLine("          ▀▀▀▀");
            Console.SetCursorPosition(15, 12);
            Console.WriteLine(" ░░░      ░░░ ");
            Console.SetCursorPosition(108, 22);
            Console.WriteLine("          ▀▀▀ ");
            Console.SetCursorPosition(15, 13);
            Console.WriteLine("  ░░░░░░░░░░  ");
            Console.SetCursorPosition(108, 23);
            Console.WriteLine("      ▀▀▀▀▀▀  ");
            Console.SetCursorPosition(15, 14);
            Console.WriteLine(" ░░░      ░░░ ");
            Console.SetCursorPosition(108, 24);
            Console.WriteLine("          ▀▀▀ ");
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("░░░░      ░░░░");
            Console.SetCursorPosition(108, 25);
            Console.WriteLine("          ▀▀▀▀");
            Console.SetCursorPosition(15, 16);
            Console.WriteLine("░░░░░░░░░░░░░░");
            Console.SetCursorPosition(108, 26);
            Console.WriteLine("      ▀▀▀▀▀▀▀");
            Console.SetCursorPosition(15, 17);
            Console.WriteLine(" ░░░░░░░░░░░░ ");
            Console.SetCursorPosition(108, 27);
            Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            Console.SetCursorPosition(15, 18);
            Console.WriteLine("  ░░░░░░░░░░  ");
            Console.SetCursorPosition(108, 28);
            Console.WriteLine("       ▀▀▀▀▀  ");
            cuadro();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(15, 8);
            Console.WriteLine("  ░░░░░░░░░░  ");
            Console.SetCursorPosition(108, 18);
            Console.WriteLine("       ▀▀▀▀▀  ");
            Console.SetCursorPosition(15, 9);
            Console.WriteLine(" ░░░░░░░░░░░░ ");
            Console.SetCursorPosition(108, 19);
            Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            Console.SetCursorPosition(15, 10);
            Console.WriteLine("░░░░░░░░░░░░░░");
            Console.SetCursorPosition(108, 20);
            Console.WriteLine("      ▀▀▀▀▀▀▀▀");
            Console.SetCursorPosition(15, 11);
            Console.WriteLine("░░░░      ░░░░");
            Console.SetCursorPosition(108, 21);
            Console.WriteLine("          ▀▀▀▀");
            Console.SetCursorPosition(15, 12);
            Console.WriteLine(" ░░░      ░░░ ");
            Console.SetCursorPosition(108, 22);
            Console.WriteLine("          ▀▀▀ ");
            Console.SetCursorPosition(15, 13);
            Console.WriteLine("  ░░░░░░░░░░  ");
            Console.SetCursorPosition(108, 23);
            Console.WriteLine("      ▀▀▀▀▀▀  ");
            Console.SetCursorPosition(15, 14);
            Console.WriteLine(" ░░░      ░░░ ");
            Console.SetCursorPosition(108, 24);
            Console.WriteLine("          ▀▀▀ ");
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("░░░░      ░░░░");
            Console.SetCursorPosition(108, 25);
            Console.WriteLine("          ▀▀▀▀");
            Console.SetCursorPosition(15, 16);
            Console.WriteLine("░░░░░░░░░░░░░░");
            Console.SetCursorPosition(108, 26);
            Console.WriteLine("      ▀▀▀▀▀▀▀");
            Console.SetCursorPosition(15, 17);
            Console.WriteLine(" ░░░░░░░░░░░░ ");
            Console.SetCursorPosition(108, 27);
            Console.WriteLine("      ▀▀▀▀▀▀▀ ");
            Console.SetCursorPosition(15, 18);
            Console.WriteLine("  ░░░░░░░░░░  ");
            Console.SetCursorPosition(108, 28);
            Console.WriteLine("       ▀▀▀▀▀  ");
         }

         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(80, 33);
         Console.WriteLine("COMPLETE");
         Console.ResetColor();
         fondo();
         Console.ForegroundColor = ConsoleColor.DarkRed;
         Console.SetCursorPosition(65, 38);
         Console.WriteLine("Presione ENTER. Para Continuar");
         Console.SetCursorPosition(85, 40);
         Console.WriteLine("SUERTE XD.");

      }

      public static void juego()
      {
         int numero = 0;
         int adivinar = 0;
         int i = 0;
         int oportunidades = 7;
         Random rnd = new Random();
         char resp = '\0';

         do
         {
            adivinar = (int)(rnd.Next(0, 100));
            i = 0;
            int intres = 7;

            do
            {
               try
               {
                  Console.Clear();
                  cuadro();
                  Console.ForegroundColor = ConsoleColor.DarkRed;
                  Console.SetCursorPosition(68, 38);
                  Console.WriteLine(intres + " Intento(s) Restantes");
                  Console.SetCursorPosition(75, 36);
                  Console.Write("Número: ");
                  numero = Convert.ToInt32(Console.ReadLine());

                  if (numero < adivinar)
                  {
                     mas();
                     Console.ForegroundColor = ConsoleColor.DarkRed;
                     Console.SetCursorPosition(75, 34);
                     Console.WriteLine("Más grande");
                     Console.SetCursorPosition(68, 38);
                     Console.WriteLine(intres - 1 + " Intento(s) Restantes");
                  }
                  else if (numero > adivinar)
                  {
                     menos();
                     Console.ForegroundColor = ConsoleColor.DarkRed;
                     Console.SetCursorPosition(75, 34);
                     Console.WriteLine("Más pequeño");
                     Console.SetCursorPosition(68, 38);
                     Console.WriteLine(intres - 1 + " Intento(s) Restantes");
                  }
                  else if (numero == adivinar)
                  {
                     carita();
                     Console.ForegroundColor = ConsoleColor.DarkRed;
                     Console.SetCursorPosition(68, 33);
                     fondo();
                     Console.WriteLine("Muy bien!!!!. Has acertado");
                     Console.SetCursorPosition(66, 35);

                     Console.ReadKey();
                  }
                  intres--;
                  i++;
                  Console.SetCursorPosition(65, 40);
                  Console.WriteLine("Porfavor espere unos segundos");
                  Thread.Sleep(2500);
               }
               catch
               {
                  Console.ForegroundColor = ConsoleColor.DarkRed;
                  Console.SetCursorPosition(70, 30);
                  Console.WriteLine("Ingrese Solo Numeros");
                  Thread.Sleep(2500);
               }

            }
            while ((numero != adivinar) && (i < oportunidades));

            Console.Clear();
            cuadro();
            if (numero != adivinar)
            {
               Console.ForegroundColor = ConsoleColor.DarkRed;
               Console.SetCursorPosition(65, 30);
               Console.WriteLine("No acertaste. El número era el: " + adivinar);
               Console.SetCursorPosition(75, 34);
               Console.WriteLine(" o(TT _ TT)o ");
            }
            cuadro();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(65, 32);
            Console.Write("¿Quieres seguir jugando? (s/n): ");
            resp = (char)Console.Read();
            Console.ReadLine();
         }
         while (resp == 's');

      }

      public static void mas()
      {
         for (int i = 22; i < 30; i++)
         {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(80, i);
            Console.WriteLine("▓▓▓");
            Console.SetCursorPosition(75, 25);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(75, 26);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ResetColor();
            fondo();
         }
      }

      public static void menos()
      {
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.SetCursorPosition(72, 25);

         Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
         Console.SetCursorPosition(72, 26);

         Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
         Console.SetCursorPosition(72, 27);

         Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
         Console.ResetColor();
         fondo();
      }

      public static void textofinal()
      {
         for (int i = 20; i < 27; i++)
         {
            cuadro();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(65, +i);
            Console.WriteLine("Gracias por jugar");
            Console.SetCursorPosition(58, 2 + i);
            Console.WriteLine("Programado por:");
            Console.SetCursorPosition(58, 4 + i);
            Console.WriteLine("Alexis Calderon Muñoz");
            Console.SetCursorPosition(58, 6 + i);
            Console.WriteLine("Irvin Ismael Escalante Euan");
            Thread.Sleep(200);
            if (i < 26)
            {
               Console.Clear();
            }
         }
      }

      public static void carita()
      {
         fondo();
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.SetCursorPosition(72, 21);
         Console.WriteLine("  ░░░     ░░░");
         Thread.Sleep(100);
         Console.SetCursorPosition(72, 22);
         Console.WriteLine(" ░░░░░   ░░░░░");
         Thread.Sleep(100);
         Console.SetCursorPosition(72, 23);
         Console.WriteLine("  ░░░     ░░░");
         Thread.Sleep(100);
         Console.SetCursorPosition(72, 24);
         Console.WriteLine("");
         Thread.Sleep(100);
         Console.ForegroundColor = ConsoleColor.Magenta;
         Console.SetCursorPosition(72, 25);
         Console.WriteLine("        ░");
         Thread.Sleep(100);
         Console.ForegroundColor = ConsoleColor.Red;
         Console.SetCursorPosition(72, 26);
         Console.WriteLine("░░            ░░");
         Thread.Sleep(100);
         Console.SetCursorPosition(72, 27);
         Console.WriteLine(" ░░          ░░");
         Thread.Sleep(100);
         Console.SetCursorPosition(72, 28);
         Console.WriteLine("  ░░        ░░");
         Thread.Sleep(100);
         Console.SetCursorPosition(72, 29);
         Console.WriteLine("   ░░░░░░░░░░ ");
         Console.ResetColor();
      }

      public static void menus()
      {
         cuadro();
         texto();
         loading();
         Console.ReadKey();
         Thread.Sleep(1000);
         Console.Clear();
         cuadro();
         juego();
         Console.Clear();
         textofinal();
         Console.ReadKey();
         Console.Clear();
      }
   }
}