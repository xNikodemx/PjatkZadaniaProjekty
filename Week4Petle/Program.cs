using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    string imie = "";
    int punktyZycia = 100;
    int makshp = 100;
    int zloto = 20;
    int liczbaPotek = 3;    
    int numertury = 1;
    bool graDziala = true; 
    bool blad = true;
    int eksploracje = 0;

    void zakoncz() {
        Console.WriteLine("Żegnaj.");
        graDziala = false;
    }

    void stats() {
        blad = true;
        Console.WriteLine("Numer Tury: " + numertury);
        Console.WriteLine("Bohater: " + imie);
        Console.WriteLine("Hp: " + punktyZycia);
        Console.WriteLine("Złoto: " + zloto);
        Console.WriteLine("Mikstury: " + liczbaPotek);
        Console.WriteLine("Ekploracje: " + eksploracje);
    }

    void Odpoczynek() {
    numertury++;
    if(zloto < 3){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nie masz już złota");
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Utraciłeś 3 złota");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Zyskałeś 5 hp");
        Console.ForegroundColor = ConsoleColor.Cyan;
    zloto-=3;
    punktyZycia += 5;
    }

    }

    void Mikstura() {
    numertury++;
    if(liczbaPotek <= 0){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Nie masz już potek");
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Utraciłeś 1 potkę");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Zyskałeś 20 życia");
        Console.ForegroundColor = ConsoleColor.Cyan;
    liczbaPotek-=1;
    punktyZycia += 20;
    }
    
    }

    void Lochy() {
        numertury++;
        eksploracje++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Zyskałeś 10 złota");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Utraciłeś 8 życia");
        Console.ForegroundColor = ConsoleColor.Cyan;
        zloto+=10;
        punktyZycia-=8;
    }

    void Menu(int Wybor) 
    {
        switch(Wybor){
            case 1:
                Lochy();
            break;
            case 2:
                Mikstura();
            break; 
            case 3:
                Odpoczynek();
            break;
            case 4:
                stats();
            break;
            case 5:
                zakoncz();
            break;
        }



    }

    void WelcomeToTheGame()
    {
        
        
        
        Console.WriteLine("\t === HELLO ADVENTURER === \nTura: " + numertury + " \nBohater: " + imie + " \nZdrowie: " + punktyZycia + "/" + makshp + "| Złoto: " + zloto + "| Mikstury: " + liczbaPotek);
        
        Console.Write("\n\n");
        string[] opcje = [" - Eksploruj loch"," - Użyj mikstury"," - Odpocznij"," - Pokaż statystyki"," - Zakończ grę"];
        for(int i = 0; i < opcje.Length; i++){
        Console.WriteLine(i+1 + opcje[i]);
        }
        blad = true;
        while(blad){
        blad = false;
        string opcja = Console.ReadLine();
        int.TryParse(opcja, out int number);
        if(number <= 0 || number > 5){
            blad = true;
            Console.WriteLine("\n Nieznana lokalizacja, Wybierz ponownie \n");
        }

        else{
            Menu(number);
        }
        }
    }

    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Program prog = new Program();
        Console.WriteLine("Jak cie zwą?");
        prog.imie = Console.ReadLine();
        if (prog.punktyZycia <= 0 || prog.makshp != 100 || prog.zloto < 0 || prog.liczbaPotek < 0 || prog.numertury < 0)
        {
            prog.graDziala = false;
            Console.WriteLine("Błąd załadowania statystyk");
        }

        while (prog.graDziala == true) 
        {
        if(prog.numertury >= 20){
            Console.WriteLine("Osiągnięto limit tur: " + prog.numertury + "\n Gra zostaje zakończona.");
            prog.graDziala = false;
            continue;
        }
        if(prog.punktyZycia <= 0){
            Console.WriteLine("Nie posiadasz już zdrowia");
            prog.graDziala = false;
            continue;
        }
        if(prog.punktyZycia > prog.makshp){
            prog.punktyZycia = prog.makshp;
        }
            prog.WelcomeToTheGame();   
        }
    }
}