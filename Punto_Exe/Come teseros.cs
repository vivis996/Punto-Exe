using System;
using System.Threading;
using d = System.Console;

namespace Punto_Exe
{
   class Come
   {
      public static bool bandera = true;
      public static int x1 = 37, y1 = 20, p = 18, score = 0, f, g, j, k, l, m, dif = 0;
      public static int[] variX = new int[15];
      public static int[] variY = new int[15];
      public static string tecla = "";
      public static int[] text = new int[3] { 68, 58, 65 };
      public static void Menu()
      {
         d.BackgroundColor = ConsoleColor.Gray;
         d.Clear();
         d.CursorVisible = false;
         d.Title = "Come tesoros";
         Cargando();
         Interfaz_del_Juego();
         bandera = true;
         x1 = 37;
         y1 = 20;
         p = 18;
         score = 0;
         tecla = "";
         text[0] = 68;
         text[1] = 58;
         text[2] = 65;
         f = 0;
         g = 0;
         j = 0;
         k = 0;
         l = 0;
         m = 0;
         dif = 0;

      }

      public static void Marco()
      {

         int x = 35, y = 17, f = 39;
         for (int i = 0; i < 76; i++, x++)
         {
            d.SetCursorPosition(x, y);
            d.Write("█");
            d.SetCursorPosition(x, f);
            d.Write("█");
         }
         d.Write("\n");
         x = 17;
         y = 35;
         f = 111;
         for (int i = 0; i < 23; i++, x++)
         {
            d.SetCursorPosition(y, x);
            d.Write("██");
            d.SetCursorPosition(f, x);
            d.Write("▐▐");
         }
         d.Write("\n");
      }

      public static void Cargando()
      {

         d.ForegroundColor = ConsoleColor.Blue;
         int cargar1 = 38, cargar2 = 0, stop = 100;
         Marco();
         while (cargar2 <= stop)
         {
            d.WriteLine();
            d.SetCursorPosition(66, 26);
            d.ForegroundColor = ConsoleColor.Magenta;
            d.Write(" CARGANDO % " + cargar2);
            Thread.Sleep(1);
            d.SetCursorPosition(37, 27);
            d.ForegroundColor = ConsoleColor.DarkRed;
            d.Write("▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▌");
            d.SetCursorPosition(37, 29);
            d.Write("▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▐▌");
            d.SetCursorPosition(37, 28);
            d.Write("▐");
            d.SetCursorPosition(110, 28);
            d.Write("▐");
            cargar2++;

            if (cargar1 < 111)
            {
               d.ForegroundColor = ConsoleColor.DarkGreen;
               d.SetCursorPosition(cargar1, 28);
               d.Write("█");
            }
            cargar1++;
         }
         int f = 0, cont2 = 0;
         string texto1 = "Come tesoros ©";
         string texto2 = "Presione una tecla";
         string texto3 = "Creado por Daniel Viveros Mena ®";
         while (f != 3)
         {
            if (cont2 < texto1.Length)
            {
               d.SetCursorPosition(text[0], 31);
               d.ForegroundColor = ConsoleColor.DarkCyan;
               d.Write(texto1[cont2]);
               text[0]++;
            }
            if (cont2 < texto2.Length)
            {

               d.ForegroundColor = ConsoleColor.Yellow;
               d.SetCursorPosition(text[2], 34);
               d.Write(texto2[cont2]);
               text[2]++;
            }
            if (cont2 < texto3.Length)
            {

               d.SetCursorPosition(text[1], 37);
               d.ForegroundColor = ConsoleColor.DarkRed;
               d.Write(texto3[cont2]);
               text[1]++;
            }
            if (cont2 == texto3.Length)
            {
               f = 3;
            }
            cont2++;
            Thread.Sleep(10);
         }


         d.ReadKey();
         d.Clear();
      }

      public static void Interfaz_del_Juego()
      {
         d.Clear();
         d.ForegroundColor = ConsoleColor.DarkRed;
         Marco();
         int f2 = 50, i = 0;
         string opc2 = "";
         d.ForegroundColor = ConsoleColor.Black;
         string texto = "Use las flechas para moverse para recolectar puntos.", texto2 = "Seleccione la dificultad",
             texto3 = "1.- Facil     2.- Normal     3.- Difícil     4.- Crazy", texto4 = "1 punto  °", texto5 = "2 puntos ¥", texto6 = "Evite la pared y \"█\"";
         bool opc = true;
         while (opc == true)
         {
            d.ForegroundColor = ConsoleColor.Black;
            for (i = 0; i < texto.Length; i++, f2++)
            {
               d.SetCursorPosition(f2, 25);
               d.WriteLine(texto[i]);
               Thread.Sleep(1);
            }
            d.ForegroundColor = ConsoleColor.Blue;
            for (i = 0, f2 = 63; i < texto2.Length; i++, f2++)
            {
               d.SetCursorPosition(f2, 27);
               d.WriteLine(texto2[i]);
               Thread.Sleep(1);
            }
            for (i = 0, f2 = 45; i < texto3.Length; i++, f2++)
            {
               d.SetCursorPosition(f2, 29);
               d.WriteLine(texto3[i]);
               Thread.Sleep(1);
            }
            d.ForegroundColor = ConsoleColor.Red;
            for (i = 0, f2 = 40; i < texto6.Length; i++, f2++)
            {
               d.SetCursorPosition(f2, 33);
               d.Write(texto6[i]);
               Thread.Sleep(1);
            }
            d.ForegroundColor = ConsoleColor.DarkCyan;
            for (i = 0, f2 = 40; i < texto4.Length; i++, f2++)
            {
               d.SetCursorPosition(f2, 35);
               d.Write(texto4[i]);
               Thread.Sleep(1);
            }
            for (i = 0, f2 = 40; i < texto5.Length; i++, f2++)
            {
               d.SetCursorPosition(f2, 37);
               d.Write(texto5[i]);
               Thread.Sleep(1);
            }
            d.ForegroundColor = ConsoleColor.Black;
            d.SetCursorPosition(70, 31);
            d.Write("[     ]");
            d.ForegroundColor = ConsoleColor.Red;
            d.SetCursorPosition(73, 31);
            opc2 = d.ReadLine();
            if (opc2 == "1")
            {
               dif = 100;
               opc = false;
            }
            if (opc2 == "2")
            {
               dif = 75;
               opc = false;
            }
            if (opc2 == "3")
            {
               dif = 50;
               opc = false;
            }
            if (opc2 == "4")
            {
               dif = 25;
               opc = false;
            }
            if (opc2 != "1" && opc2 != "2" && opc2 != "3" && opc2 != "4")
            {
               for (i = 0; i < 21; i++, p++)
               {
                  d.SetCursorPosition(37, p);
                  d.Write("                                                                          ");
               }
               p = 18;
               d.ForegroundColor = ConsoleColor.DarkMagenta;
               d.SetCursorPosition(56, 23);
               d.Write("Por favor Ingrese una opción correcta");
               opc = true;
            }
         }
         p = 18;
         for (i = 0; i < 21; i++, p++)
         {
            d.SetCursorPosition(37, p);
            d.Write("                                                                          ");
            Thread.Sleep(1);
         }
         d.SetCursorPosition(35, 16);
         d.ForegroundColor = ConsoleColor.Black;
         d.Write("Para salir Esc");
         do
         {
            Detecta_flechas();
         } while (tecla == "Escape");
         d.SetCursorPosition(45, 25);
         Fin_del_Juego();
         d.SetCursorPosition(51, 30);
         d.Write("Presione una tecla");
         d.ReadKey();
      }

      public static void Detecta_flechas()
      {
         Thread Hilo = new Thread(hilo);
         Hilo.Start();
         while (bandera == true)
         {

            ConsoleKeyInfo pres = d.ReadKey(true);
            if (pres.Key == ConsoleKey.UpArrow ||
                pres.Key == ConsoleKey.DownArrow ||
                pres.Key == ConsoleKey.RightArrow ||
                pres.Key == ConsoleKey.LeftArrow)
            {
               tecla = pres.Key.ToString();
            }
            if (pres.Key == ConsoleKey.Escape)
            {
               bandera = false;
               break;
            }
         }
      }

      public static void hilo()
      {
         Random gen = new Random();
         f = gen.Next(38, 110);
         g = gen.Next(18, 38);
         j = gen.Next(38, 110);
         k = gen.Next(18, 38);
         l = gen.Next(38, 110);
         m = gen.Next(18, 38);
         for (int f2 = 0; f2 < 15; f2++)
         {
            variX[f2] = gen.Next(38, 110);
            variY[f2] = gen.Next(18, 38);
            d.ForegroundColor = ConsoleColor.DarkGreen;
            d.SetCursorPosition(variX[f2], variY[f2]);
            d.Write("█");
            Thread.Sleep(1);
         }
         while (bandera == true)
         {
            if ((f == variX[0] && g == variY[0])
                || (f == variX[1] && g == variY[1])
                || (f == variX[2] && g == variY[2])
                || (f == variX[3] && g == variY[3])
                || (f == variX[4] && g == variY[4])
                || (f == variX[5] && g == variY[5])
                || (f == variX[6] && g == variY[6])
                || (f == variX[7] && g == variY[7])
                || (f == variX[8] && g == variY[8])
                || (f == variX[9] && g == variY[9])
                || (f == variX[10] && g == variY[10])
                || (f == variX[11] && g == variY[11])
                || (f == variX[12] && g == variY[12])
                || (f == variX[13] && g == variY[13])
                || (f == variX[14] && g == variY[14]))
            {
               f = gen.Next(38, 110);
               g = gen.Next(18, 38);
            }
            if ((j == variX[0] && k == variY[0])
               || (j == variX[1] && k == variY[1])
               || (j == variX[2] && k == variY[2])
               || (j == variX[3] && k == variY[3])
               || (j == variX[4] && k == variY[4])
               || (j == variX[5] && k == variY[5])
               || (j == variX[6] && k == variY[6])
               || (j == variX[7] && k == variY[7])
               || (j == variX[8] && k == variY[8])
               || (j == variX[9] && k == variY[9])
               || (j == variX[10] && k == variY[10])
               || (j == variX[11] && k == variY[11])
               || (j == variX[12] && k == variY[12])
               || (j == variX[13] && k == variY[13])
               || (j == variX[14] && k == variY[14]))
            {
               j = gen.Next(38, 110);
               k = gen.Next(18, 38);
            }
            if ((l == variX[0] && m == variY[0])
               || (l == variX[1] && m == variY[1])
               || (l == variX[2] && m == variY[2])
               || (l == variX[3] && m == variY[3])
               || (l == variX[4] && m == variY[4])
               || (l == variX[5] && m == variY[5])
               || (l == variX[6] && m == variY[6])
               || (l == variX[7] && m == variY[7])
               || (l == variX[8] && m == variY[8])
               || (l == variX[9] && m == variY[9])
               || (l == variX[10] && m == variY[10])
               || (l == variX[11] && m == variY[11])
               || (l == variX[12] && m == variY[12])
               || (l == variX[13] && m == variY[13])
               || (l == variX[14] && m == variY[14]))
            {
               l = gen.Next(38, 110);
               m = gen.Next(18, 38);
            }
            d.SetCursorPosition(60, 16);
            d.ForegroundColor = ConsoleColor.Black;
            d.Write("Score: {0}", score);
            d.ForegroundColor = ConsoleColor.DarkMagenta;
            d.SetCursorPosition(f, g);
            d.Write("°");
            d.SetCursorPosition(j, k);
            d.Write("¥");
            d.SetCursorPosition(l, m);
            d.Write("°");
            if (tecla == "UpArrow")
            {
               d.SetCursorPosition(x1, y1);
               d.Write(" ");
               y1--;
            }
            if (tecla == "DownArrow")
            {
               d.SetCursorPosition(x1, y1);
               d.Write(" ");
               y1++;
            }
            if (tecla == "LeftArrow")
            {
               d.SetCursorPosition(x1, y1);
               d.Write(" ");
               x1--;
            }
            if (tecla == "RightArrow")
            {
               d.SetCursorPosition(x1, y1);
               d.Write(" ");
               x1++;
            }
            d.ForegroundColor = ConsoleColor.Blue;
            d.SetCursorPosition(x1, y1);
            d.Write("☺");
            Thread.Sleep(dif);
            if (x1 == f && y1 == g)
            {
               f = gen.Next(38, 110);
               g = gen.Next(18, 38);
               score++;
               d.SetCursorPosition(66, 16);
               d.Write("      ");
               d.Beep();
            }
            if (x1 == l && y1 == m)
            {
               l = gen.Next(38, 110);
               m = gen.Next(18, 38);
               score++;
               d.SetCursorPosition(66, 16);
               d.Write("      ");
               d.Beep();
            }
            if (x1 == j && y1 == k)
            {
               j = gen.Next(38, 110);
               k = gen.Next(18, 38);
               score += 2;
               d.SetCursorPosition(66, 16);
               d.Write("      ");
               d.Beep();
            }
            if (x1 == 36 || y1 == 17 || x1 == 111 || y1 == 39
                || (x1 == variX[0] && y1 == variY[0])
                || (x1 == variX[1] && y1 == variY[1])
                || (x1 == variX[2] && y1 == variY[2])
                || (x1 == variX[3] && y1 == variY[3])
                || (x1 == variX[4] && y1 == variY[4])
                || (x1 == variX[5] && y1 == variY[5])
                || (x1 == variX[6] && y1 == variY[6])
                || (x1 == variX[7] && y1 == variY[7])
                || (x1 == variX[8] && y1 == variY[8])
                || (x1 == variX[9] && y1 == variY[9])
                || (x1 == variX[10] && y1 == variY[10])
                || (x1 == variX[11] && y1 == variY[11])
                || (x1 == variX[12] && y1 == variY[12])
                || (x1 == variX[13] && y1 == variY[13])
                || (x1 == variX[14] && y1 == variY[14]))
            {
               d.SetCursorPosition(60, 16);
               d.ForegroundColor = ConsoleColor.Black;
               d.Write("Score: {0}", score);
               bandera = false;
            }
         }
      }

      public static void Fin_del_Juego()
      {
         if (x1 == 36 || y1 == 17 || x1 == 111 || y1 == 39
             || (x1 == variX[0] && y1 == variY[0])
             || (x1 == variX[1] && y1 == variY[1])
             || (x1 == variX[2] && y1 == variY[2])
             || (x1 == variX[3] && y1 == variY[3])
             || (x1 == variX[4] && y1 == variY[4])
             || (x1 == variX[5] && y1 == variY[5])
             || (x1 == variX[6] && y1 == variY[6])
             || (x1 == variX[7] && y1 == variY[7])
             || (x1 == variX[8] && y1 == variY[8])
             || (x1 == variX[9] && y1 == variY[9])
             || (x1 == variX[10] && y1 == variY[10])
             || (x1 == variX[11] && y1 == variY[11])
             || (x1 == variX[12] && y1 == variY[12])
             || (x1 == variX[13] && y1 == variY[13])
             || (x1 == variX[14] && y1 == variY[14]))
         {
            d.ForegroundColor = ConsoleColor.Blue;
            d.Write("Perdiste");
            d.ForegroundColor = ConsoleColor.Black;
            d.SetCursorPosition(48, 26);
            d.Write("Score: {0}", score);
         }
         else
         {
            d.ForegroundColor = ConsoleColor.Black;
            d.Write("Score: {0}", score);
         }
         d.SetCursorPosition(51, 28);
         d.Write("Buen Intento");
         d.ReadKey();
      }
   }
}