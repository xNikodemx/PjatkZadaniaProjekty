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
//    int liczbaPotek = 3;
    int numertury = 1;
    bool graDziala = true; 
    bool blad = true;
    int eksploracje = 0;
    string[] znaleziska =
        {
    "Mikstura",
    "Klucz",
    "Pochodnia",
    "Zwój"
        };
        List<string> plecak = new List<string> //limit 6
        {
            "Miecz",
            "Mikstura"
        };
        List<string> historia = new List<string>{};

    void zakoncz() {
        Console.WriteLine("Żegnaj.");
        KoniecGry("gracz wyszedł z gry");
        graDziala = false;
    }

    void stats() {
        blad = true;
        Console.WriteLine("Numer Tury: " + numertury);
        Console.WriteLine("Bohater: " + imie);
        Console.WriteLine("Hp: " + punktyZycia);
        Console.WriteLine("Złoto: " + zloto);
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

//              ||Week 4 function
//    void Mikstura() {
//    numertury++;
//    if(liczbaPotek <= 0){
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Nie masz już potek");
//        Console.ForegroundColor = ConsoleColor.Cyan;
//    }
//    else{
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine("Utraciłeś 1 potkę");
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("Zyskałeś 20 życia");
//        Console.ForegroundColor = ConsoleColor.Cyan;
//    liczbaPotek-=1;
//    punktyZycia += 20;
//    }
//
//    }
    void histori(){
        int numer = historia.Count();
        for(int i = 0; i < numer; i++){
            Console.WriteLine(historia[i]);
        }
    }
    void plecakw(){
        int numers = plecak.Count();
        for(int i = 0; i < numers; i++){
            Console.WriteLine(plecak[i]);
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

    void znalezisko(){
        if(historia.Count() >= 6){
            Console.WriteLine("Osiągnieto limit przedmiotów, nie zużyto tury.");
        }
        else{
    for (int i = 0; i < znaleziska.Count(); i++)
    {
        Console.WriteLine(i+1 + ": " + znaleziska[i]);
    }
    Console.WriteLine("Jaki item wybierzesz?");
            int wybierz = (int.Parse(Console.ReadLine())) - 1;
            plecak.Add(znaleziska[wybierz]);
for (int i = 0; i < plecak.Count(); i++)
    {
        Console.WriteLine(i+1 + ": " + plecak[i]);
    }
        numertury++;
    }
    }
    void ZapisDlaItem(string wb, int it){
                numertury++;
                historia.Add("Użyto przedmiot " + wb + " w turze: " + numertury);
                plecak.RemoveAt(it);
                Console.WriteLine("Zużyto item");
    }

    void UseItem(){
        int numers = plecak.Count();
        if(numers == 0){
            Console.WriteLine("Nie mas zjuż przedmiotów!");
            return;
        }

        Console.WriteLine("Jakiego przedmiotu użyjesz?");
        for(int i = 0; i < numers; i++){
            Console.Write(i+1 + " - " + plecak[i] + "\n")    ;        
        }
        string wyb = Console.ReadLine();
        int.TryParse(wyb, out int wybr); 
        if(wybr <= 0 || wybr > numers){
            Console.WriteLine("Wybrano item spoza listy");
            return;
        }
        switch(plecak[wybr-1]){
        case "Mikstura":
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Utraciłeś 1 potkę");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Zyskałeś 20 życia");
        Console.ForegroundColor = ConsoleColor.Cyan;
        punktyZycia+=20;
        ZapisDlaItem(plecak[wybr-1], wybr-1);
            break;
        case "Pochodnia":
                Console.WriteLine("Rozwietlono korytarz");
                ZapisDlaItem(plecak[wybr-1], wybr-1);
            break;
        case "Zwój":
                Console.ForegroundColor = ConsoleColor.Yellow;
                zloto += 15;
                Console.WriteLine("Dodano 15 sztuk złota");
                Console.ForegroundColor = ConsoleColor.Cyan;
                ZapisDlaItem(plecak[wybr-1], wybr-1);
            break;
        case "Klucz":
                Console.WriteLine("Beta Item");
                ZapisDlaItem(plecak[wybr-1], wybr-1);
                break;
        case "Miecz":
                Console.WriteLine("Beta Item");
                ZapisDlaItem(plecak[wybr-1], wybr-1);
                break;
        default:
                Console.WriteLine("Przedmiot nieznany nie zużyto tury");
                return;
            break;

        }

    }


    void Menu(int Wybor) 
    {
        switch(Wybor){
            case 1:
                Lochy();
                historia.Add("Udano się do Lochow w turze: " + numertury);
            break;
            case 2:
               histori();
               historia.Add("Wyświetlono historię w turze: " + numertury);

            break; 
            case 3:
                Odpoczynek();
            break;
            case 4:
                stats();
            break;
            
            case 5:
                znalezisko();
                historia.Add("Udano się zdobyć przedmiot w turze: " + numertury);
            break;
            case 6:
                plecakw();
                historia.Add("Wyświetlono plecak w turze: " + numertury);
                break;
            case 7:
                UseItem();
            break;
            case 8:
                zakoncz();
            break;


        }



    }

    void WelcomeToTheGame()
    {
        
        
        
        Console.WriteLine("\t === HELLO ADVENTURER === \nTura: " + numertury + " \nBohater: " + imie + " \nZdrowie: " + punktyZycia + "/" + makshp + "| Złoto: " + zloto);
        
        Console.Write("\n\n");
        string[] opcje = [" - Eksploruj loch"," - Historia"," - Odpocznij"," - Pokaż statystyki"," - Znajdz przedmiot"," - Pokaż plecak"," - Użyj przedmiotu"," - Zakończ grę"];
        for(int i = 0; i < opcje.Length; i++){
        Console.WriteLine(i+1 + opcje[i]);
        }
        blad = true;
        while(blad){
        blad = false;
        string opcja = Console.ReadLine();
        int.TryParse(opcja, out int number);
        if(number <= 0 || number > 8){
            blad = true;
            Console.WriteLine("\n Nieznana lokalizacja, Wybierz ponownie \n");
        }

        else{
            Menu(number);
        }
        }
    }
    void KoniecGry(string powod){
        Console.WriteLine("=== PODSUMOWANIE ===");
        Console.WriteLine("Bohater: " + imie);
        Console.WriteLine("Rozegrane tury: " + numertury);
        Console.WriteLine("Eksploracje: " + eksploracje);
        Console.WriteLine("Zdrowie: " + punktyZycia + "/" + makshp);
        Console.WriteLine("Złoto: " + zloto);
        Console.WriteLine("Przedmioty w plecaku: " + plecak.Count());
        Console.WriteLine("Wpisy w historii: " + historia.Count());
        Console.WriteLine("Powód zakończenia: " + powod);
    }

    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Program prog = new Program();
        Console.WriteLine("Jak cie zwą?");
        prog.imie = Console.ReadLine();
        if (prog.punktyZycia <= 0 || prog.makshp != 100 || prog.zloto < 0 || prog.numertury < 0)
        {
            prog.graDziala = false;
            Console.WriteLine("Błąd załadowania statystyk");
        }

        while (prog.graDziala == true) 
        {
        if(prog.numertury >= 20){
            Console.WriteLine("Osiągnięto limit tur: " + prog.numertury + "\n Gra zostaje zakończona.");
            prog.KoniecGry("Limit tur");
            prog.graDziala = false;
            continue;
        }
        if(prog.punktyZycia <= 0){
            Console.WriteLine("Nie posiadasz już zdrowia");
            prog.KoniecGry("Hp spadło do 0");
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