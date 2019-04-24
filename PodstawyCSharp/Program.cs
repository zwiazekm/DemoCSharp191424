using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodstawyCSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            //int wiek = DeklaracjeZmiennych();
            //OPeracje();
            //Metody();
            int a = 30;
            WykonajByVal(a);
            Console.WriteLine($"Wartosc a:{a}");
            WykonajByRef(ref a);
            Console.WriteLine($"Wartosc a:{a}");
            WykonajOut(out a);
            Console.WriteLine($"Wartosc a:{a}");

            string stringL1 = "23,45";

            decimal decL1;
            if(!decimal.TryParse(stringL1, out decL1))
            {
                Console.WriteLine("Błąd konwersji");
            }
            Console.WriteLine($"Wartosć decl1:{decL1}");

            Obliczenia obl1 = new Obliczenia();
            obl1.Formatuj(123);
            obl1.Formatuj(12, jednostka: " ok");
            decimal wynik = stringL1.ToDecimal();
            int testint = 10;
            Console.WriteLine(testint.ToString("t"));
        }

        static void WykonajByVal(int z)
        {
            z += 10;
            Console.WriteLine($"Wartosc z:{z}");
        }

        static void WykonajByRef(ref int z)
        {
            z += 10;
            Console.WriteLine($"Wartosc z:{z}");
        }
        
        static void WykonajOut(out int z)
        {
            z = 12;
            Console.WriteLine($"Wartosc z:{z}");
        }

        private static void Metody()
        {
            Demo();
            var wynik = Obliczenia.Dodaj(23, 45.34M);
            Obliczenia obl1 = new Obliczenia();
            obl1.Formatuj(wynik);

            wynik = Obliczenia.Dodaj("34", "234,2");
            wynik = Obliczenia.Dodaj(2, 3, 4);

            decimal[] liczby = { 32, 523, 35 };
            wynik = Obliczenia.Dodaj(liczby);

            wynik = Obliczenia.Dodaj(12, 41, 124, 512);

            
        }

        static void Demo()
        {
            Console.WriteLine("Metoda Demo");
        }

        private static void OPeracje()
        {

            decimal wynik = 23.34M + 15;
            //wyrażenie plus przypisanie
            /* Operatory:
                * -Arytmetyczne: +, - , /, *, %
                * -Inkrementacji: ++, --
                * -Porównani: == , !=
                * -Konkantenacji: +
                * -Logiczne: &, &&, |, ||
                * -Przypisania: = /, +=, -=
                */
            wynik++; wynik += 1; wynik = wynik + 1;
            //if ((wynik > 0M) && (wiek == 40)) ;
            wynik += 20;

            string ok = (wynik >= 20M) ? "Jest OK" : "OK";
            if (wynik >= 20)
            {
                int a = 30;
                wynik += a;
            }
            else if (wynik > 10)
            {

            }
            else
            {

            }

            var poziom = 3;
            switch (poziom)
            {
                case 1:
                    Console.WriteLine("Wybrano 1");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Wybrano 2 lub 3 lub 4");
                    break;
                case 5:
                    Console.WriteLine("Wybrano 5");
                    return;
                case 6:
                    Console.WriteLine("Wybrano 6");
                    goto case 1;
                default:
                    Console.WriteLine("Wybrano inne");
                    break;
            }
            //Typ tablicowy
            int[] tab1 = new int[3];
            //Array tabarr = Array.CreateInstance(typeof(int), 3);
            tab1[0] = 12;
            tab1[1] = 23;
            tab1[3] = 45;

            int[] tab2 = { 2, 3, 52, 23, 32 };
            Array.Resize(ref tab1, 2);

            //Petla for
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.WriteLine(tab1[i]);
            }

            for (int x = 0, y = 100; (x < 100 && y > 0); x++, y -= 2)
            {
                break; //wyskakuje z petli
                continue; //wyskakuje z kroku

            }

            foreach (var item in tab1)
            {

            }
        }

        private static int DeklaracjeZmiennych()
        {
            //Deklaracja zmiennej
            //zasieg typ nazwa 
            string imieOsoby = "Janko";
            //System.String imie;
            int wiek;
            //System.Int32 w;
            wiek = 34;
            return wiek;
        }
    }

    class Obliczenia
    {
        string typFormatu = "test";

        public string Formatuj(decimal liczba, string jednostka="test")
        {
            return $"moja liczba: {liczba} {jednostka}";
            //return string.Format("moja liczba: {0}", liczba);
        }

        public static decimal Dodaj(decimal liczba1, decimal liczba2)
        {
            return liczba1 + liczba2;
        }

        public static decimal Dodaj(decimal liczba1, decimal liczba2, decimal liczba3)
        {
            return Dodaj(liczba1, liczba2) + liczba3;
        }

        public static decimal Dodaj(string liczba1, string liczba2)
        {
            decimal l1 = Convert.ToDecimal(liczba1);
            decimal l2 = decimal.Parse(liczba2);
            
            return l1 + l2;
        }
        
        public static decimal Dodaj(params decimal[] liczby)
        {
            decimal wynik = 0;
            foreach (var item in liczby)
            {
                wynik += item;
            }
            return wynik;
        }
    }
}
