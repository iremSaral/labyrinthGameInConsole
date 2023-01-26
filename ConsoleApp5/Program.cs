using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kodumda kullandigim degiskenleri isimlendirmede camel case stilini benimsemeye ozen gosterdim.
            
            Class1 road = new Class1();
            road.makeRoadOne(); //1. yol olusturulur
            road.makeRoadTwo(); //2. yol olusturulur
            road.makeRoadThree(); //3. yol olusturulur
          
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write("{0}", road.gameSpace[i, j]);
                Console.WriteLine();
            }
           //Bomba eklenir.
            int a = 0;
            Random rnd4 = new Random();
            do
            {
                int bmb = rnd4.Next(0, 3);
                a++;
                if (bmb == 0)
                {//1. yola bomba
                    road.addBomb(road.first);
                }
                else if (bmb == 1)
                {//2. yola bomba 
                    road.addBomb(road.second);
                }
                else
                {//3. yola bomba
                    road.addBomb(road.third);
                }
            } while (a <=  2);
            Console.WriteLine("*********");
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //        Console.Write("{0}", Road.gameSpaceBomb[i, j]);
            //    Console.WriteLine();
            //}
           
            road.stepOne();
        
            
        
            Console.ReadKey();
           
    }
        

    }
}
