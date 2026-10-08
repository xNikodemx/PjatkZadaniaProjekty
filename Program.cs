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
        void ShowKlasa() {
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
        void Wyjdz(){
        keepgame = false;
        Console.WriteLine("Zamykanie...");

        }
        void Dziennik(){
        double StrOfHero;
        StrOfHero = 4 * atk * (atk / 1.5) + atk * hp * (mana / atk);

        Console.WriteLine("| -----------------------------------------------|");
        Console.WriteLine("| Bohater: " + imie);
        Console.WriteLine("| Gotowy do drogi?: " + stan);
        Console.WriteLine("| -----------------------------------------------|");
        Console.WriteLine("| Hitpoints: " + hp);
        Console.WriteLine("| Siła Bohatera: " + Math.Round(StrOfHero, 1));
        Console.WriteLine("| Gold: " + gold);
        Console.WriteLine("| -----------------------------------------------|");


        }
        void Bohater(){
            int pz = Maxhp-5;
            double pzproc = (pz / Maxhp) * 100;
            int strmdf = atk;
            int patk = 10+strmdf;
            double satk = 2.5;
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Bohater: " + imie);
            Console.WriteLine("| Klasa: " + klasa );
            Console.WriteLine("| Hitpoints: " + hp + "/"+ Maxhp );
            Console.WriteLine("| Atack: " + atk);
            Console.WriteLine("| Mana: " + mana);
            Console.WriteLine("| Zwykły atack: " + atk);
            Console.WriteLine("| Specjalny atack: " + (atk*satk));
            Console.WriteLine("| -----------------------------------------------|");
        }
        void Wyprawa()
        {
            int racje, czlonkowie, dniwyprawy;
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Ilu członków drużyny jest?");
            Console.Write("| ");
            czlonkowie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| Ile racji posiadasz?");
            Console.Write("| ");
            racje = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("| Na ile dni planujesz wyprawe?");
            Console.Write("| ");
            dniwyprawy = Convert.ToInt32(Console.ReadLine());

            double racjana_osobe = (racje / czlonkowie)*dniwyprawy;
            double pozostale_racje = racje % czlonkowie;
            double racje_dzienne = Math.Round(((racjana_osobe/racje) * dniwyprawy), 1);
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

            
        }
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

        }
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

        }
        void GotowoscBohatera()
        {
            int pz = hp;
            Console.WriteLine("| Ile posiadasz Mikstur?");
            Console.Write("| ");
            int mikstury =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| Czy posiadasz klucz?");
            Console.Write("| ");
            bool klucz = bool.Parse(Console.ReadLine());
            Console.WriteLine("| Czy posiadasz mapę?");
            Console.Write("| ");
            bool Mapa = bool.Parse(Console.ReadLine());
            
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| \t\tBohater " + imie);
            bool zywotnosc = (pz > 0) ? true : false;
            Console.WriteLine("| Żyje: " + zywotnosc);
            bool healing = (pz != Maxhp) ? true : false;
            Console.WriteLine("| Wymaga leczenia: " + healing);
            bool czyposiada;
            if (klucz || Mapa)
            { czyposiada = true;
            }
            else
            { czyposiada = false;
            }
            Console.WriteLine("| Posiada klucz lub mapę: " + czyposiada);
            bool gotowosc = (czyposiada && !healing == true && zywotnosc == true) ? true : false;
            Console.WriteLine("| Gotowy do wyprawy: " + gotowosc);
            Console.WriteLine("| -----------------------------------------------|");

        }

        void Walka()
        {
            int pz = Maxhp-5;
            double pzproc = (pz / Maxhp) * 100;
            int strmdf = atk;
            int patk = 10+strmdf;
            double satk = 2.5;
            Console.WriteLine("| ----------------------------------------------|");
            Console.WriteLine("| Ile ataków wykonujesz?");
            int atknum =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("| ----------------------------------------------|");
            Console.WriteLine("| \t\t RAPORT Z WALKI");
            Console.WriteLine("| Bohater: " + imie);
            Console.WriteLine("| Zdrowie: " + pz + "/" + Maxhp + "("+pzproc+"%)");
            Console.WriteLine("| Zwykły atak: " + patk + "\n| Atak Specjalny: " + (patk*satk));
            Console.WriteLine("| Łączne zadane obrażenia: " + (patk*atknum));
            bool pelne = (pz == Maxhp) ? true : false;
            Console.WriteLine("| Pełne zdrowie: " + false);
            Console.WriteLine("| ----------------------------------------------|");

        }

        void Menus(string holder){
            
            
        switch (holder) {
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
        }

        

        void WelcomeScreen() {
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
            Boolean Pick = true;
            while (Pick == true) {
                Pick = false;
            string wybor;
            wybor = Console.ReadLine();
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
                        Pick = true;
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

            while(keepgame){
            string holder = Console.ReadLine();
            Pick = true;
            while(Pick == true){
            Pick = false;
            if(holder != "Wyjdz z Gry" && holder != "Bohater" && holder != "Dziennik" && holder != "Ekwipunek" && holder != "Arena" && holder != "Wyprawa" && holder != "Walka" && holder != "Gotowosc Bohatera" && holder != "Walka"){
             Pick = true;
             Console.WriteLine("Nie ma takiego miejsca, wybierz ponownie");
             holder = Console.ReadLine();
            }
            else{
                Menus(holder);
                }
        }}
        }


        static void Main(string[] args)
        {
            
            Program prog;
            prog = new Program();
            prog.WelcomeScreen();






        }
    }
}