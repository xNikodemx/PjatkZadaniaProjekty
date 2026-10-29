namespace MyProject;

class Program
{
Dictionary<string, int> punktyZycia = new Dictionary<string, int>();
Dictionary<string, int> liczbaPokonanych = new Dictionary<string, int>();
bool Gameon = true;
void Zakoncz(){
    Gameon = false;
}
void DodajG(){


}
void Menu(){
while(Gameon){
Console.WriteLine("=== Bestiariusz Menu ===");
string[] wybory = {"Dodaj","Usun","Zakoncz"}



Console.WriteLine("Zakonczyc? [1 - tak, 2 - nie]");
int odp = int.Parse(Console.ReadLine());
if(odp == 1){
    Zakoncz();
}
}
}


    static void Main(string[] args)
    {
       Program prog = new Program();
       prog.Menu();   


    }
}   