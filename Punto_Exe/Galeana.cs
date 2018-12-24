using System;
using e = System.Console;

namespace Punto_Exe
{
   class Galeana2
   {
      public static void Menu()
      {
         e.Title = "9 Afortunado";
         string u, co;
         e.ForegroundColor = ConsoleColor.White;
         e.SetCursorPosition(30, 7);
         e.Write("Usuario: ");
         e.ForegroundColor = ConsoleColor.Blue;
         u = e.ReadLine();
         u = u.ToLower();
         e.SetCursorPosition(30, 9);
         e.ForegroundColor = ConsoleColor.White;
         e.Write("Contraseña: ");
         e.ForegroundColor = ConsoleColor.Black;
         co = e.ReadLine();
         if (u == u)
         {
            if (co == co)
            {
               e.ForegroundColor = ConsoleColor.Magenta;
               e.SetCursorPosition(27, 13);
               e.WriteLine("Preciona enter para jugar");
               e.SetCursorPosition(24, 15);
               e.WriteLine("O cierra la ventana para salir");
               e.SetCursorPosition(28, 17);
               e.WriteLine("(¿Pues que querias?)");
               e.ReadLine();
               e.BackgroundColor = ConsoleColor.DarkBlue;
               e.Clear();
               string o;

               e.ForegroundColor = ConsoleColor.Red;
               e.SetCursorPosition(30, 2);
               e.Write("9 AFORTUNADO :D");
               e.SetCursorPosition(5, 5);
               e.ForegroundColor = ConsoleColor.White;
               e.Write("Preciona enter para empezar y espacio seguido de enter para salir");
               o = e.ReadLine();
               do
               {
                  Random A = new Random();
                  Random B = new Random();
                  Random C = new Random();
                  int a = A.Next(5, 10);
                  int b = B.Next(1, 10);
                  int c = C.Next(2, 11);
                  e.Clear();
                  e.SetCursorPosition(27, 10);
                  e.ForegroundColor = ConsoleColor.Green;
                  e.WriteLine("|" + a + "|");
                  e.SetCursorPosition(37, 10);
                  e.ForegroundColor = ConsoleColor.Yellow;
                  e.WriteLine("|" + b + "|");
                  e.SetCursorPosition(47, 10);
                  e.ForegroundColor = ConsoleColor.Red;
                  e.WriteLine("|" + c + "|");
                  e.ForegroundColor = ConsoleColor.Red;
                  e.SetCursorPosition(30, 2);
                  e.Write("9 AFORTUNADO :D");

                  if (a == 9 || b == 9 || c == 9)
                  {
                     e.SetCursorPosition(23, 15);
                     e.ForegroundColor = ConsoleColor.Green;
                     e.WriteLine("Ahi hay un 9 Felididades GANASTE!!");
                  }
                  else
                  {
                     e.SetCursorPosition(28, 15);
                     e.ForegroundColor = ConsoleColor.Magenta;
                     e.WriteLine(" intenta de nuevo");
                  }
                  e.SetCursorPosition(3, 5);
                  e.ForegroundColor = ConsoleColor.White;
                  e.Write("Preciona enter para intentar de nuevo y espacio seguido de enter para salir");
                  o = e.ReadLine();
               } while (o != " ");
            }
         }
         else
         {
            e.ForegroundColor = ConsoleColor.Red;
            e.SetCursorPosition(30, 11);
            e.WriteLine("No eres digno, el juego se cerrara.");
            e.ReadKey();
         }
      }
   }
}