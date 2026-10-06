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
        int hp, atk, mana, gold;
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
        }

        void Wyjdz(){
        keepgame = false;
        Console.WriteLine("Zamykanie...");

        }
        void Dziennik(){
        double StrOfHero;
        StrOfHero = 4*atk*(atk/1.5) + atk*hp*(mana/atk);
        if(hp > 3){
        stan = true;
        }
        else{
        stan = false;
        }

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
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Nazwa: " + imie);
            Console.WriteLine("| Klasa: " + klasa );
            Console.WriteLine("| Hitpoints: " + hp );
            Console.WriteLine("| Atack: " + atk);
            Console.WriteLine("| Mana: " + mana);
            Console.WriteLine("| -----------------------------------------------|");
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
            Console.WriteLine("" + imie + " wybierz teraz klase podróżniku");

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
                        atk = 8;
                        mana = 20;
                        gold = 5;
                        break;
                    case "Warrior":
                        hp = 35;
                        atk = 15;
                        mana = 0;
                        gold = 6;
                        break;
                    case "Rogue":
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
            Console.WriteLine("| -----------------------------------------------|");
            Console.WriteLine("| Oto przydatne miejsca które warto odwiedzić!\t |");
            Console.WriteLine("| Wyjdz z Gry, Bohater, Dziennik \t\t |");
            Console.WriteLine("| Wystarczy że wpiszesz któreś z tych miejsc!(pamietaj aby uzywac nazw tak jak są wyswietlone!)\t |");

            while(keepgame){
            string holder = Console.ReadLine();
            Pick = true;
            while(Pick == true){
            Pick = false;
            if(holder != "Wyjdz z Gry" && holder != "Bohater" && holder != "Dziennik"){
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