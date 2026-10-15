using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Adventurer
{
    internal class Program
    {
        string imie, klasa;
        public const int Kokos = 1;
        int hp, atk, mana, gold, level, exp, trening, Maxhp;
        bool stan = true;
        bool keepgame = true;

        // Nazwa, atk, hp, exp
        // static string[,] tabela = {
        //     {"Goblin", "15", "10", "5"},
        //     {"Ork", "15", "10", "5"},
        //     {"Bandyta", "15", "10", "5"}
        // };

        void ShowKlasa()
        {
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Wizard \t\t\t\t\t |");
            Console.WriteLine("| Hp: 5 \t\t\t\t\t |");
            Console.WriteLine("| Atk: 8 \t\t\t\t\t |");
            Console.WriteLine("| Mana: 20 \t\t\t\t\t |");
            Console.WriteLine("| Starter Gold: 5 \t\t\t\t |");
            Console.WriteLine("| -----------------------------------------------|");

            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Warrior \t\t\t\t\t |");
            Console.WriteLine("| Hp: 30 \t\t\t\t\t |");
            Console.WriteLine("| Atk: 15 \t\t\t\t\t |");
            Console.WriteLine("| Mana: 0 \t\t\t\t\t |");
            Console.WriteLine("| Starter Gold: 6 \t\t\t\t |");
            Console.WriteLine("| -----------------------------------------------|");

            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Rogue \t\t\t\t\t |");
            Console.WriteLine("| Hp: 20 \t\t\t\t\t |");
            Console.WriteLine("| Atk: 20 \t\t\t\t\t |");
            Console.WriteLine("| Mana: 10 \t\t\t\t\t |");
            Console.WriteLine("| Starter Gold: 7 \t\t\t\t |");
            Console.WriteLine("| -----------------------------------------------|");
            level = 1;
            exp = 40;
        }

        void Wyjdz()
        {
            keepgame = false;
            Console.WriteLine("Zamykanie...");
        }

        void Dziennik()
        {
            double StrOfHero = 4 * atk * (atk / 1.5) + (double)atk * hp * ((double)mana / (atk > 0 ? atk : 1));

            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Bohater: " + imie);
            Console.WriteLine("| Gotowy do drogi?: " + stan);
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Hitpoints: " + hp);
            Console.WriteLine("| Siła Bohatera: " + Math.Round(StrOfHero, 1));
            Console.WriteLine("| Gold: " + gold);
            Console.WriteLine("| -----------------------------------------------|");
        }

        void Bohater()
        {
            double satk = 2.5;
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Bohater: " + imie);
            Console.WriteLine("| Klasa: " + klasa);
            Console.WriteLine("| Hitpoints: " + hp + "/" + Maxhp);
            Console.WriteLine("| Atack: " + atk);
            Console.WriteLine("| Mana: " + mana);
            Console.WriteLine("| Zwykły atack: " + atk);
            Console.WriteLine("| Specjalny atack: " + (atk * satk));
            Console.WriteLine("| -----------------------------------------------|");
        } // profil bohatera

        void Wyprawa()
        {
            int racje, czlonkowie, dniwyprawy;
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Ilu członków drużyny jest?");
            Console.Write("| ");
            czlonkowie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| Ile racji posiadasz?");
            Console.Write("| ");
            racje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| Na ile dni planujesz wyprawe?");
            Console.Write("| ");
            dniwyprawy = Convert.ToInt32(Console.ReadLine());

            double racjana_osobe = czlonkowie > 0 ? ((double)racje / czlonkowie) * dniwyprawy : 0;
            double pozostale_racje = czlonkowie > 0 ? racje % czlonkowie : 0;
            double racje_dzienne = racje > 0 ? Math.Round(((racjana_osobe / racje) * dniwyprawy), 1) : 0;

            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| \t\t   Twoja Wyprawa");
            Console.WriteLine("| Racje: " + racje);
            Console.WriteLine("| Członkowie drużyny: " + czlonkowie);
            Console.WriteLine("| Dni wyprawy: " + dniwyprawy);
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Racje przypadające na osobe: " + pozostale_racje);
            Console.WriteLine("| Racje dzienne na osobe: " + racje_dzienne);
            Console.WriteLine("| Racje po podziale: " + pozostale_racje);
            Console.WriteLine("| -----------------------------------------------|");
        } // wyswietla mini-kalkulator dla wypraw

        void Ekwipunek()
        {
            char Symbol = '@';
            string name = imie;
            int Poziom = level;
            int zloto = gold;
            double Waga = 7.5;
            bool Mapa = true;

            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| \t\t====EKWIPUNEK====");
            Console.WriteLine("| Imię(string): " + name);
            Console.WriteLine("| Symbol(char): " + Symbol);
            Console.WriteLine("| Poziom(int): " + Poziom);
            Console.WriteLine("| Złoto(int): " + zloto);
            Console.WriteLine("| Waga(double): " + Waga);
            Console.WriteLine("| Ma mapę(bool): " + Mapa);
            Console.WriteLine("| -----------------------------------------------|");
        } // wyswietla ekwipunek postaci

        void Arena()
        {
            exp += 25;
            exp *= 2;
            gold -= 8;
            gold += 15;
            trening++;
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| \t\tTrening zakończony");
            Console.WriteLine("| Aktualne Doswiadczenie: " + exp);
            Console.WriteLine("| Wydane złoto: 8 \t Zdobyte złoto: 15 \t" + "Aktualne złoto: " + gold);
            Console.WriteLine("| Twoja aktualna liczba treningów: " + trening);
            Console.WriteLine("| -----------------------------------------------|");
        } // miejsce na ktorym bohater zdobywa doswiadczenie

        void GotowoscBohatera()
        {
            int pz = hp;
            Console.WriteLine("| Ile posiadasz Mikstur?");
            Console.Write("| ");
            int mikstury = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| Czy posiadasz klucz?");
            Console.Write("| ");
            bool klucz = bool.Parse(Console.ReadLine());
            Console.WriteLine("| Czy posiadasz mapę?");
            Console.Write("| ");
            bool Mapa = bool.Parse(Console.ReadLine());

            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| \t\tBohater " + imie);
            bool zywotnosc = pz > 0;
            Console.WriteLine("| Żyje: " + zywotnosc);
            bool healing = pz != Maxhp;
            Console.WriteLine("| Wymaga leczenia: " + healing);

            bool czyposiada = (klucz || Mapa);
            Console.WriteLine("| Posiada klucz lub mapę: " + czyposiada);

            bool gotowosc = (czyposiada && !healing && zywotnosc);
            Console.WriteLine("| Gotowy do wyprawy: " + gotowosc);
            Console.WriteLine("| -----------------------------------------------|");
        } // pokazuje status bohatera

        void Walka()
        {
            int pz = Maxhp - 5;
            double pzproc = Maxhp > 0 ? ((double)pz / Maxhp) * 100 : 0;
            int strmdf = atk;
            int patk = 10 + strmdf;
            double satk = 2.5;

            Console.WriteLine("| ----------------------------------------------|");
            Console.WriteLine("| Ile ataków wykonujesz?");
            int atknum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| ----------------------------------------------|");
            Console.WriteLine("| \t\t RAPORT Z WALKI");
            Console.WriteLine("| Bohater: " + imie);
            Console.WriteLine("| Zdrowie: " + pz + "/" + Maxhp + "(" + pzproc + "%)");
            Console.WriteLine("| Zwykły atak: " + patk + "\n| Atak Specjalny: " + (patk * satk));
            Console.WriteLine("| Łączne zadane obrażenia: " + (patk * atknum));
            Console.WriteLine("| Pełne zdrowie: false");
            Console.WriteLine("| ----------------------------------------------|");
        } // self explanatory, walka

        void Menus(string holder)
        {
            switch (holder)
            {
                case "Wyjdz z Gry":
                    Wyjdz();
                    Console.WriteLine("Żegnaj");
                    break;
                case "Bohater":
                    Bohater();
                    Console.WriteLine("Gdzie wybierzesz się teraz?");
                    break;
                case "Dziennik":
                    Dziennik();
                    Console.WriteLine("Gdzie wybierzesz się teraz?");
                    break;
                case "Ekwipunek":
                    Ekwipunek();
                    Console.WriteLine("Gdzie wybierzesz się teraz?");
                    break;
                case "Wyprawa":
                    Wyprawa();
                    Console.WriteLine("Gdzie wybierzesz się teraz?");
                    break;
                case "Arena":
                    Arena();
                    Console.WriteLine("Gdzie wybierzesz się teraz?");
                    break;
                case "Gotowosc Bohatera":
                    GotowoscBohatera();
                    Console.WriteLine("Gdzie wybierzesz się teraz?");
                    break;
                case "Walka":
                    Walka();
                    Console.WriteLine("Gdzie się wybierzesz teraz");
                    break;
                default:
                    break;
            }
        } // menu odsylajace do poszczegolnego miejsca

        void WelcomeScreen()
        {
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| \tWitaj w Hello Adventurer!\t\t |");
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("|By zacząc rozgrywke przydałoby się mieć imię... |");
            Console.WriteLine("| -----------------------------------------------|");
            imie = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("" + imie + " wybierz teraz klase");

            ShowKlasa();
            bool pick = true;
            while (pick)
            {
                pick = false;
                string wybor = Console.ReadLine();
                switch (wybor)
                {
                    case "Wizard":
                        hp = 5;
                        Maxhp = 5;
                        atk = 8;
                        mana = 20;
                        gold = 5;
                        break;
                    case "Warrior":
                        hp = 35;
                        Maxhp = 35;
                        atk = 15;
                        mana = 0;
                        gold = 6;
                        break;
                    case "Rogue":
                        Maxhp = 20;
                        hp = 20;
                        atk = 20;
                        mana = 10;
                        gold = 7;
                        break;
                    default:
                        Console.WriteLine("Niepoprawna klasa, spróbuj ponownie.");
                        pick = true;
                        break;
                }
                klasa = wybor;
            }
            Console.WriteLine("Świetny wybór, chcesz rozpocząć gre?");
            Console.ReadLine();
            Console.WriteLine("Wyśmienicie!");
            Console.WriteLine("| ----------------------------------------------------------|");
            Console.WriteLine("| Oto przydatne miejsca które warto odwiedzić!\t\t    |");
            Console.WriteLine("| Wyjdz z Gry, Bohater, Dziennik, Arena, Walka\t\t    | \n| Wyprawa, Ekwipunek, Gotowosc Bohatera \t\t    |");
            Console.WriteLine("| Wystarczy że wpiszesz któreś z tych miejsc!(pamietaj aby uzywac nazw tak jak są wyswietlone!)\t |");

            while (keepgame)
            {
                string holder = Console.ReadLine();
                bool innerPick = true;
                while (innerPick)
                {
                    innerPick = false;
                    if (holder != "Wyjdz z Gry" && holder != "Bohater" && holder != "Dziennik" && holder != "Ekwipunek" && holder != "Arena" && holder != "Wyprawa" && holder != "Walka" && holder != "Gotowosc Bohatera")
                    {
                        innerPick = true;
                        Console.WriteLine("Nie ma takiego miejsca, wybierz ponownie");
                        holder = Console.ReadLine();
                    }
                    else
                    {
                        Menus(holder);
                    }
                }
            }
        } // glowna czesc odpowiadajaca za poczatek programu

        string CzyParzysta(int SendV)
        {
            if (SendV % 2 != 0) { return "Nie-Parzysta"; }
            else if (SendV == 0) { return "To jest zero"; }
            else if (SendV % 2 == 0) { return "Parzysta"; }
            return "cos poszlo nie tak";
        }

        string JakiKierunek(string direction)
        {
            switch (direction)
            {
                case "północ":
                    return "Wyruszasz w stronę gór.";
                case "południe":
                    return "Wyruszasz w stronę pustyni.";
                case "wschód":
                    return "Wyruszasz w stronę lasu.";
                case "zachód":
                    return "Wyruszasz w stronę morza.";
                default:
                    return "Nieznany kierunek";
            }
        }

        string CheckAge(int wiek)
        {
            if (wiek < 0) { return "niepoprawny wiek"; }
            else if (wiek >= 0 && wiek <= 12) { return "dziecko"; }
            else if (wiek >= 13 && wiek <= 17) { return "nastolatek"; }
            else if (wiek >= 18 && wiek <= 64) { return "dorosły"; }
            else if (wiek >= 65) { return "senior"; }
            return "cos poszlo nie tak";
        }

        void BohaterLochy(){
        hp = Maxhp;
        Console.WriteLine("Czy posiadasz klucz");
        bool klucz = (Console.ReadLine() == "tak") ? true : false;
        Console.WriteLine("Czy posiadasz hasło?");
        bool haslo = (Console.ReadLine() == "tak") ? true : false;

        if(hp == 0){Console.WriteLine("Niestety nie zyjesz."); return;}
        if(klucz == true || haslo == true){Console.WriteLine("Mozesz wejść");}
        else{Console.WriteLine("You shall not pass");}


        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.WelcomeScreen();
        }
    }
}