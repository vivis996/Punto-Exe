using System;
using System.Threading;

namespace Punto_Exe
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.BackgroundColor = ConsoleColor.Gray;
         Console.Clear();
         adivina_un_numero.cuadro();
         Console.SetBufferSize(168, 58);
         Console.SetWindowSize(168, 58);
         Console.CursorVisible = false;
         for (int i = 1; i > -1; i++)
         {
            menu();
            adivina_un_numero.cuadro();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(53, 30);
            Console.WriteLine("¿desea jugar otro juego? (si/no):");
            Console.SetCursorPosition(87, 30);
            string jugar = Convert.ToString(Console.ReadLine().ToUpper());
            if (jugar == "NO" || jugar == "N")
            {
               i = -2;
            }
            Console.Clear();
         }
      }

      static void menu()
      {
         bool intento = true;
         while (intento)
         {
            adivina_un_numero.cuadro();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(72, 23);
            Console.WriteLine("Seleccione opcion.");
            Console.SetCursorPosition(62, 26);
            Console.WriteLine("1.-Encuentra el numero");
            Console.SetCursorPosition(62, 28);
            Console.WriteLine("2.-Nueve afortunado");
            Console.SetCursorPosition(62, 30);
            Console.WriteLine("3.-Adivina el numero");
            Console.SetCursorPosition(62, 32);
            Console.WriteLine("4.-Come tesoros");
            Console.SetCursorPosition(62, 34);
            Console.WriteLine("seleccione y presione ENTER:");
            Console.SetCursorPosition(91, 34);
            Console.Write("[   ]");

            Console.SetCursorPosition(93, 34);
            string x = Convert.ToString(Console.ReadLine());
            Console.Clear();

            switch (x)
            {
               case "1":
                  intento = false;
                  Giil Juego1 = new Giil();
                  Giil.Menu();
                  Console.Clear();
                  break;
               case "2":
                  intento = false;
                  Galeana2 Juego2 = new Galeana2();
                  Galeana2.Menu();
                  Console.Clear();
                  break;
               case "3":
                  intento = false;
                  adivina_un_numero juego3 = new adivina_un_numero();
                  adivina_un_numero.menus();
                  break;
               case "4":
                  intento = false;
                  Come Juego4 = new Come();
                  Come.Menu();
                  Console.Clear();
                  break;
               default:
                  adivina_un_numero.cuadro();
                  Console.ForegroundColor = ConsoleColor.DarkRed;
                  Console.SetCursorPosition(60, 31);
                  Console.WriteLine("Error. Favor de teclear una opcion valida.");
                  Thread.Sleep(1500);
                  Console.Clear();
                  break;
            }
         }
      }
   }
}