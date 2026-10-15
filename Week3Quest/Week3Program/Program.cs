     class Program{
        int hp = 10;
        int atk = 20;
        bool MaPotke = true;


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
        Console.WriteLine("|\tOdpowiedzi tak lub nie\t |");
        Console.WriteLine("Czy posiadasz klucz");
        bool klucz = (Console.ReadLine() == "tak") ? true : false;
        Console.WriteLine("Czy posiadasz hasło?");
        bool haslo = (Console.ReadLine() == "tak") ? true : false;

        if(hp == 0){Console.WriteLine("Niestety nie zyjesz."); return;}
        if(klucz == true || haslo == true){Console.WriteLine("Mozesz wejść");}
        else{Console.WriteLine("You shall not pass");}


        }
        void Operatorask(){
        int hpz = hp;
        int gold = 20;
        string zyje = (hpz != 0) ? "Żyje" : "Nie żyje";
        string wealth = (gold >= 30) ? "Możesz kupić potke" : "Nie możesz kupić potki";
        Console.WriteLine(zyje + "\n" + wealth);

        }
        void Walka(){
        if(hp == 0){
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("You Died");
        return;
        }
        else{
        if(hp <= 20){Console.WriteLine("UWAGA, Niski poziom życia: " + hp);}
        string ac2 = (MaPotke) ? "Możesz użyć mikstury" : "Nie możesz użyć mikstury";
            Console.WriteLine("|\tJakiej Akcji użyjesz?\t|");
            Console.WriteLine("Akcja 1: " + atk + " Obrażeń");
            Console.WriteLine("Akcja 2: " + ac2);
            Console.WriteLine("Akcja 3: " + "Ucieczka");
        string odp = Console.ReadLine();
        switch(odp){
        case "1":
        Console.WriteLine("Uderzyłeś za: " + atk);
        break;
        case "2":
        if(MaPotke){
        Console.WriteLine("Użyłeś potki, uleczyłeś się");
        hp += 20;
        MaPotke = false;}
        else{
        Console.WriteLine("Użyłeś pustej mikstury, nic sie nie stało");
        }break;

        case "3":
        Console.WriteLine("Uciekleś");
        break;
        default:
        Console.WriteLine("Nieznana akcja");
        break;
}



        }



        }
       static void Main(string[] args){
       Program prog = new Program();
          Console.Write("Wpisz liczbe: ");
          int odp;
          if (int.TryParse(Console.ReadLine(), out odp))
          {
              Console.WriteLine(prog.CzyParzysta(odp));
          }
          else
          {
              Console.WriteLine("To nie liczba");
          }

          Console.WriteLine("(wschód)Twoj kierunek to: " + prog.JakiKierunek("wschód"));
          Console.WriteLine("\n\n\n");
          Console.WriteLine("(20)twój wiek nazywany potocznie jest jako: " + prog.CheckAge(20));
          Console.WriteLine("\n\n\n");
          prog.BohaterLochy(); //zakladamy ze bohater zyje, mozna zmienic w funkcji
          Console.WriteLine("\n\n\n");
          prog.Operatorask(); //zakladamy ze bohater zyje i nie stac go na miksture, mozna zmienic
          Console.WriteLine("\n\n\n");
          prog.Walka();
          Console.ResetColor();

       }}