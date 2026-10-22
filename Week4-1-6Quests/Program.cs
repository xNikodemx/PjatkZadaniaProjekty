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
        for(int i = 6; i >= 1; i--){
            Console.Write("\n  ");
            for(int j = i; j <= 5; j++){
                Console.Write("*");
            }
        }

        }
           

    
    static void Main(string[] args)
        {
            Program p;
            p = new Program();
            p.zad3();



        }
        }
}