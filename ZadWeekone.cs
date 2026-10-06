using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPGRweek1
{
    internal class Program
    {
        string imie, gra, ulkolor;
        int Wiek, sekundy, minuty;
        int dystans, pokdystans;

        int zlmonety, srmonety, mimonety;
        int ilmikstur;
        int krysztal = 3;
        int ziolo = 2;
        decimal kosztpobyt;
        int liczbanocy, bohaterzy, atk1,strb,obr,atk2,auto,finaldmg;
        string imiebohatera, kraina;
        float dniwyprawy, pd, zloto;

        void zad1() {
          

            Console.WriteLine("Jak ci na imię?");
            imie = Console.ReadLine();
            Console.WriteLine("Ile masz lat?");
            Wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Jaką grę grasz?");
            gra = Console.ReadLine();


            Console.WriteLine("+------------------------+");
            Console.WriteLine("| \tWIZYTÓWKA  \t | ");
            Console.WriteLine("+------------------------+");
            Console.WriteLine("| Imię: " + imie + "\t\t |");
            Console.WriteLine("| Wiek: " + Wiek + "\t\t |");
            Console.WriteLine("| Gra: " + gra + "\t\t |");
            Console.WriteLine("+------------------------+");
        }
        void zad2() {
            Console.WriteLine("Jak masz na imię? ");
            imie = Console.ReadLine();
            Console.WriteLine("\nJaki jest twój ulubiony kolor? ");
            ulkolor = Console.ReadLine();

            Console.WriteLine("\n\n Cześć, " + imie + "! " + ulkolor + " to najlepszy kolor pod słońcem!");

        }

        void zad3() {
            Console.WriteLine("Ile masz lat użytkowniku?");
            Wiek = int.Parse(Console.ReadLine());
            int Wiekminj = Wiek + 1;
            int wiekminp = Wiek + 5;
            Console.WriteLine("Za rok będziesz miał: " + Wiekminj + ", a za 5 lat będziesz miał: " + wiekminp);
        }
        void zad4() {
            Console.WriteLine("Jak długa będzie twoja podróż?(odpowiedz podaj w km))");
            dystans = int.Parse(Console.ReadLine());
            Console.WriteLine("Ile km pokonujesz dziennie?");
            pokdystans = int.Parse(Console.ReadLine());

            int potrzebny_czas = dystans / pokdystans;
            Console.WriteLine("By pokonać ten dystans, będziesz potrzebował: " + potrzebny_czas + " dni");
        }
        void zad5() {
            zlmonety = 15;
            srmonety = 70;
            mimonety = 99;

            int suma = (zlmonety * 100) + (srmonety * 10) + (mimonety);
            Console.WriteLine("Monety w miedzi są warte: " + suma);

        }
        void zad6() {
            Console.WriteLine("Ile mikstur chcesz przygotować?");
            ilmikstur = int.Parse(Console.ReadLine());

            Console.WriteLine("Do utworzenia tej ilości mikstur potrzebujesz: \n" + (ilmikstur*ziolo) + " Ziol\n" + (ilmikstur*krysztal) + " Kryształów");

        }
        void zad7()
        {
            Console.WriteLine("Podaj liczbe nocy");
            liczbanocy = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj cennik za noc");
            string test = Console.ReadLine();
            decimal.TryParse(test, out kosztpobyt);

            decimal cena = liczbanocy * kosztpobyt;
            Console.WriteLine("Cena wychodzi: " + cena);
        }
        void zad8()
        {
            Console.WriteLine("Podaj czas w sekundach");
            sekundy = int.Parse(Console.ReadLine());

            int reszta_sek = sekundy % 60;
            Console.WriteLine("Czas w minutach oraz reszty w sekundach wynosi: " + (sekundy / 60) + " minut oraz " + reszta_sek + "sekund");

        }
        void zad9() {
            while (bohaterzy == 0)
            {
                Console.WriteLine("Ile bohaterow jest na wyprawie?");
                bohaterzy = int.Parse(Console.ReadLine());
                if (bohaterzy <= 0) { Console.Write("Prosze podać więcej niż 1 bohatera!!!\n"); }
            }
            Console.WriteLine("Ile monet zawierał skarb?");
            zlmonety =  int.Parse(Console.ReadLine());

            int podzial = zlmonety / bohaterzy;
            Console.WriteLine("Podział dla kazdego bohatera wynosi: " + podzial);

        }
        void zad10() {
            atk1 = 10;
            strb = 5;
            auto = atk1 + strb;
            atk2 = (2 * auto);
            finaldmg = (3 * atk1) + atk2;
            Console.WriteLine("Sekwencja ataków wynosi nastepujaco: ");
            Console.WriteLine("atak z str boostem: " + atk1 + " obrazen");
            Console.WriteLine("atak specjalny: " + atk2 + " obrazen");
            Console.WriteLine("Combo: " + finaldmg + " obrazen");
        }
        void zad11() {
            imiebohatera = "Wysoki major komodor pierwszej legionowej trzykrotnej podwojnej admiralicji kompanii artyleryjskiej strazy przedniej";
            kraina = "Runnetera";
            dniwyprawy = 21;
            pd = 245;
            zloto = 100;

            float avgpd = pd / dniwyprawy;
            float avggold = zloto / dniwyprawy;

            Console.WriteLine(imiebohatera);
            Console.WriteLine("Kraina: " + kraina);
            Console.WriteLine("Średnie złoto na dzień: " + Math.Round(avggold, 1));
            Console.WriteLine("Średnie doświadczenie na dzień: " + Math.Round(avgpd, 1));
        
        }





        static void Main(string[] args)
        {
            Program prog;
            prog = new Program();
            prog.zad11();



        }
    }
}
