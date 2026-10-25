using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Adventurer
{

    internal class Program
    {
        void zad1(){
            int i = 0;
            Console.Write("\nRosnąco: ");
            while(i != 10){
                i++;
                Console.Write(i + " ");
            }
            Console.Write("\nMalejąco: ");
            i = 10;
            do
            {
            Console.Write(i + " ");
            i--;
            } while (i != 0);
            Console.Write("\nParzyste: ");
            for(int j=1; j <= 20; j++){
                if(j%2 == 0){
                Console.Write(j + " ");
                }
            }
        Console.WriteLine("\nStart!");
        }
        void zad2(){
            int wypd = 0;
            int zl = 0;
            int suma = 0;
            int bogacz = 0;
            Console.WriteLine("Ile dni trwa wyprawa?");
            wypd = int.Parse(Console.ReadLine());    
            for(int i = 0; i<wypd; i++){
                Console.WriteLine($"Złoto w dniu {i}: ");
                zl = int.Parse(Console.ReadLine());    
                suma += zl;
                if(zl > 10){
                    bogacz++;
                }
            Console.WriteLine("łącznie znaleziono: " + suma);
            Console.WriteLine("Dni z wynikiem powyżej 10: " + bogacz);
        }
            }
        void zad3(){
        for(int i = 5; i >= 1; i--){
            for(int t = i; t >= 1; t--){
                Console.Write(" ");
            }
            Console.Write("*");
            for(int j = i; j <= 4; j++){
                    Console.Write("*");
                    Console.Write("*");
            }
                Console.Write("\n");
        }
        for(int g = 0; g <= 4; g++){
        Console.Write(" ");
        }
        Console.Write("*");
        }
        void zad4(){
            int calk = 2;
            string gues = "";
            bool popr = true;
            int tura = 0;
            while(popr){
            tura++;
            Console.WriteLine("Aktualna runda: " + tura);
            Console.WriteLine("Zgadnij liczbe od 1-10");
            gues = Console.ReadLine();
            int.TryParse(gues, out int number);
            if(number == 0){
            Console.WriteLine("Nie poprawna wartosc");
            continue;
            }
            if(number > 10 || number <= 0){
            Console.WriteLine("Wartosc jest powyzej 10, badz mniejsza lub rowna 0");
            continue;
            }
            if(calk != number){
            Console.WriteLine("Niestety nie udało ci się zgadnąć");
            continue;
            }
            if(calk == number){
            Console.WriteLine("Udało ci się!");
            popr = false;
            break;
            }


            }



        }
        void zad5(){
        int zdrowieBohatera = 60;
        int zdrowiePrzeciwnika = 45;
        int liczbaMikstur = 2;
        int numerTury = 1;
        //zrobilem to juz robiac helloadventurer 4.0
        }
    
    static void Main(string[] args)
        {
            Program p;
            p = new Program();
            p.zad4();



        }
        }
}