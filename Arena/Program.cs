using System.Collections.Generic;

Console.ForegroundColor = ConsoleColor.Cyan;
Gra gra = new Gra();
Console.WriteLine("Jak się nazywasz?");
string nazwa = Console.ReadLine()!;
int[] klasa = {200, 30, 100, 150, 50, 125, 300, 20, 50}; //Najpierw hp,atack,gold i tak co 3 
bool klas = true;
while(klas){
    klas = false;
Console.WriteLine("Wybierz teraz swą klase: ");
Console.WriteLine("1 - Wojownik: Hp - " + klasa[0] + " Atack - " + klasa[1] + " złoto: " + klasa[2]);
Console.WriteLine("2 - Łucznik: Hp - " + klasa[3] + " Atack - " + klasa[4] + " złoto: " + klasa[5]);
Console.WriteLine("3 - Tank: Hp - " + klasa[6] + " Atack - " + klasa[7] + " złoto: " + klasa[8]);   
string numer = Console.ReadLine();
if (int.TryParse(numer, out int popwybr) && popwybr >= 1 && popwybr <= 3)
{
    string klasaName = popwybr switch
    {
        1 => "Wojownik",
        2 => "Łucznik",
        3 => "Tank",
        _ => "?"
    };
    int[] stats = popwybr switch{
        1 => new int[] {klasa[0], klasa[1], klasa[2]},
        2 => new int[] {klasa[3], klasa[4], klasa[5]},
        3 => new int[] {klasa[6], klasa[7], klasa[8]},
        _ => new int[] {0,0,0}
    };


    Console.WriteLine("Twoja wybrana klasa to: " + klasaName);
    Gracz gracz = new Gracz(nazwa,klasa[0],klasa[1],klasa[2],klasaName);

}
else
{
    Console.WriteLine("Nieprawidłowy wybór!");
    klas = true;
}

gra.Menu(nazwa);
}

class Gracz
{
    public string Imie { get; set; } = "";
    public int Hp { get; set; }
    public int Atack { get; set; }
    public int Zloto { get; set; }
    public string klasa { get; set; } = "";

    public Gracz() { }

    public Gracz(string imie, int hp, int atack, int zloto, string klasa)
    {
        Imie = imie;
        Hp = hp;
        Atack = atack;
        Zloto = zloto;
        this.klasa = klasa;
    }
}

class Przeciwnik
{
    public Dictionary<string, int> enemies = new()
    {
        ["Bazyliszek"] = 200,
        ["Saburo Arasaka"] = 50,
        ["Grzegorz"] = 167,
        ["Dog named cupcake"] = 250,
        ["Fałszywy Terminator"] = 100
    };
}

class Gra
{
    public Gracz gracz = new Gracz();
    public Przeciwnik przec = new Przeciwnik();
    string[] wybory = {"Pokaz Statystyki", "Zawalcz", "Uzyj przedmiotu", "Zakoncz rozgrywke"};
    List<string> Itemy = new List<string> { "Mikstura", "Zwoj"};
    int correctchoice = 1;
    int gameon = 1;
    string wyborcz = "";

    public void Menu(string imies)
    {
        while(gameon == 1){
        while(correctchoice == 1){
        correctchoice=0;
        Console.WriteLine("=== Arena Niedźwiedźi ===");
        for(int i = 0; i < wybory.Count(); i++){
            Console.WriteLine(i+1 + " - " + wybory[i]);
        
        }
        Console.WriteLine("Wybierz swą drogę..");
        string destynacja = Console.ReadLine();
        if(int.TryParse(destynacja, out int number) && number > 0 && number <= wybory.Count()){
            Console.WriteLine("Wybrałeś: "+wybory[number-1]);
            wyborcz = wybory[number-1];
        }
        else{
            Console.WriteLine("Niepoprawne wejście.");
            correctchoice = 1;
        }
        }
            switch (wyborcz)
            {
                case "Pokaz Statystyki":
                    Stats();
                    break;
                case "Zawalcz":
                    Arena();
                    break;
                case "Uzyj przedmiotu":
                    ItemUse();
                    break;
                case "Zakoncz rozgrywke":
                    End();
                    break;  
                default:
                    Console.WriteLine("Coś poszło nie tak");
                break;
            }
        }
    }
    void Stats(){
        Console.WriteLine(gracz.imie + " \n hp: " + gracz.Hp);


    }
    void Arena(){}
    void ItemUse(){}
    void End(){
        Console.WriteLine("Żegnaj");
        gameon = 0;
    }

}   