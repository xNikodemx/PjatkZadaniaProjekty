namespace MyProject;

class Program
{
Dictionary<string, int> punktyZycia = new Dictionary<string, int>();
Dictionary<string, int> liczbaPokonanych = new Dictionary<string, int>();
bool Gameon = true;

void Zakoncz(){
Console.WriteLine("Zakonczyc? [1 - tak, 2 - nie]");
int odp = int.Parse(Console.ReadLine());
if(odp == 1){
  Gameon = false;
}
}



void DodajG(){
string mob="";
Console.WriteLine("Jakie zwierze chcesz dodać?");
mob=Console.ReadLine();
Console.WriteLine("Ile takie zwierze ma zdrowia?");
int hp = int.Parse(Console.ReadLine());
punktyZycia.Add(mob, hp);
liczbaPokonanych.Add(mob, 0);
foreach (var item in punktyZycia)
{
Console.WriteLine($"Nazwa: {item.Key}, HP: {item.Value}");
}
}
void usun(){
foreach (var item in punktyZycia)
{
Console.WriteLine($"Nazwa: {item.Key}, HP: {item.Value}");
}
Console.WriteLine("Jakie zwierze chcesz usunąć?");
string nazwa = Console.ReadLine();


if (punktyZycia.Remove(nazwa))
{
    liczbaPokonanych.Remove(nazwa);
    Console.WriteLine("Usunięto potwora.");
}
else
{
    Console.WriteLine("Nie znaleziono takiego potwora.");
}
}

void PotworDeaf(){
foreach (var item in punktyZycia)
{
Console.WriteLine($"Nazwa: {item.Key}, HP: {item.Value}");
}
foreach (var item in liczbaPokonanych)
{
Console.WriteLine($"Nazwa: {item.Key}, Pokonani: {item.Value}");
}
Console.WriteLine("Jakiego potwora chcesz wyzwać i wygrać");
string mobek=Console.ReadLine();
if (liczbaPokonanych.ContainsKey(mobek))
{
    Console.WriteLine("Pokonałeś "+mobek);
    liczbaPokonanych[mobek]++;
}
else
{
    Console.WriteLine("Nie ma takiego potwora.");
}

}

void Menus(string graczwyb){
switch(graczwyb){
case "Zakoncz":
    Zakoncz();
break;
case "Dodaj Potwora":
    DodajG();
break;
case "Usun":
    usun();
break;
case "Pokonaj Potwora":
    PotworDeaf();
break;


}

}

void Menu(){
while(Gameon){
Console.WriteLine("=== Bestiariusz Menu ===");

string[] wybory = { "Dodaj Potwora", "Usun", "Pokonaj Potwora", "Zakoncz"};

for (int i = 0; i < wybory.Length; i++)
{
    Console.WriteLine($"{i + 1} - {wybory[i]}");
}

int wybor;

while (!int.TryParse(Console.ReadLine(), out wybor) ||
       wybor < 1 || wybor > wybory.Length)
{
    Console.WriteLine("Niepoprawny wybór, spróbuj ponownie:");
}

Menus(wybory[wybor - 1]);
}
}

    static void Main(string[] args)
    {
       Program prog = new Program();
       prog.Menu();   


    }
}   