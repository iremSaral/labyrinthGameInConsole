using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        int a = 1; //G harfinin girilme durumunu kontrol etmek için
        public int skor;//puan 
        public int x=9;//satir
        public int y;//sutun
        public int[,] gameSpace = new int[10, 10];
        public int[,] first = new int[10, 10]; 
        public int[,] second = new int[10, 10];
        public int[,] third = new int[10, 10];
        public int[,] gameSpaceBomb = new int[10, 10]; //Bomba eklenmis hali

        public int[,] makeRoadOne()
        {//yol bir
            Random rnd = new Random();
            int line = 9;
        tekrar:
            int column = rnd.Next(0, 10);
            do
            {
                if (gameSpace[line, column] == 0)
                {
                    gameSpace[line, column] = 1;
                    first[line, column] = 1;
                    gameSpaceBomb[line, column] = 1;
                    line--;
                }
                else { goto tekrar; }
            } while (line >= 8);
            line = 8;
        tekrartwo:
            do
            {
                int direct = rnd.Next(0, 3);
                if (direct == 0)
                {//sag
                    if (column < 9 && column >= 0)
                    {
                        column++;
                        gameSpace[line, column] = 1;
                        first[line, column] = 1;
                        gameSpaceBomb[line, column] = 1;
                    }
                    else { goto tekrartwo; }
                }
                else if (direct == 1)
                {//sol
                    if (column <= 9 && column > 0)
                    {
                        column--;
                        gameSpace[line, column] = 1;
                        first[line, column] = 1;
                        gameSpaceBomb[line, column] = 1;
                    }
                    else { goto tekrartwo; }
                }
                else
                {//duz
                    if (line <= 9 && line > 0)
                    {
                        line--;
                        gameSpace[line, column] = 1;
                        first[line, column] = 1;
                        gameSpaceBomb[line, column] = 1;
                    }
                    else { goto tekrartwo; }
                }
            } while (line > 0);

            return (gameSpace);
        }

        public int[,] makeRoadTwo()
        {//Yol iki
            int lineTwo = 9;
            Random rnd2 = new Random();
        tekrar:
            int columnTwo = rnd2.Next(0, 10);
            if (gameSpace[lineTwo, columnTwo] == 0)
                do {
                    gameSpace[lineTwo, columnTwo] = 1;
                    second[lineTwo, columnTwo] = 1;
                    gameSpaceBomb[lineTwo, columnTwo] = 1;
                    lineTwo--;
                } while (lineTwo >= 8);
            else { goto tekrar; }
            lineTwo = 8;
            do
            { tekrarTwo:
                int directTwo = rnd2.Next(0, 3);
                if (directTwo == 0)
                {//sag
                    if (columnTwo < 9 && columnTwo >= 0)
                    {
                        columnTwo++;
                        gameSpace[lineTwo, columnTwo] = 1;
                        second[lineTwo, columnTwo] = 1;
                        gameSpaceBomb[lineTwo, columnTwo] = 1;
                    }
                    else { goto tekrarTwo; }
                }
                else if (directTwo == 1)
                {//sol
                    if (columnTwo <= 9 && columnTwo > 0)
                    {
                        columnTwo--;
                        gameSpace[lineTwo, columnTwo] = 1;
                        second[lineTwo, columnTwo] = 1;
                        gameSpaceBomb[lineTwo, columnTwo] = 1;
                    }
                    else { goto tekrarTwo; }
                }
                else
                {//duz
                    if (lineTwo <= 9 && lineTwo > 0)
                    {
                        lineTwo--;
                        gameSpace[lineTwo, columnTwo] = 1;
                        second[lineTwo, columnTwo] = 1;
                        gameSpaceBomb[lineTwo, columnTwo] = 1;
                    }
                    else { goto tekrarTwo; }
                }
            } while (lineTwo > 0);
        
           return (gameSpace);
       } 

        public int[,] makeRoadThree()
        {//yol uc
            int lineThree = 9;
            Random rnd3 = new Random();
        tekrar:
            int columnThree = rnd3.Next(0, 10);
            // for (lineThree = 9; lineThree >= 8; lineThree--)
            do
            {
                if (gameSpace[lineThree, columnThree] == 0)
                {
                    gameSpace[lineThree, columnThree] = 1;
                    third[lineThree, columnThree] = 1;
                    gameSpaceBomb[lineThree, columnThree] = 1;
                    lineThree--;
                }
                else { goto tekrar; }
            } while (lineThree >= 8);
            lineThree = 8;
            do
            {
            tekrarThree:
                int directThree = rnd3.Next(0, 3);
                if (directThree == 0)
                {//sag
                    if (columnThree < 9 && columnThree >= 0)
                    {
                        columnThree++;
                        gameSpace[lineThree, columnThree] = 1;
                        third[lineThree, columnThree] = 1;
                        gameSpaceBomb[lineThree, columnThree] = 1;
                    }
                    else { goto tekrarThree; }
                }
                else if (directThree == 1)
                {//sol
                    if (columnThree <= 9 && columnThree > 0)
                    {
                        columnThree--;
                        gameSpace[lineThree, columnThree] = 1;
                        third[lineThree, columnThree] = 1;
                        gameSpaceBomb[lineThree, columnThree] = 1;
                    }
                    else { goto tekrarThree; }
                }
                else
                {//duz
                    if (lineThree <= 9 && lineThree > 0)
                    {
                        lineThree--;
                        gameSpace[lineThree, columnThree] = 1;
                        third[lineThree, columnThree] = 1;
                        gameSpaceBomb[lineThree, columnThree] = 1;
                    }
                    else { goto tekrarThree; }
                }
            } while (lineThree > 0);
            return (gameSpace);
        }
        public int[,] addBomb(int[,] a)//Bomba eklemek icin. 
        {tekrar5:
            Random random = new Random();
            int x = random.Next(0, 10);
            int y = random.Next(0, 10);
            if (a[x, y] == 1) {
              gameSpaceBomb[x, y] = 2;
            }
            else
            {
                goto tekrar5;
            }
            return (gameSpaceBomb);
        }
        //kullanının  hangi girişi sectiği sorulur.
     public int[,] stepOne()
        {
           // do
            //{
                Console.WriteLine("Hangi girişi Secmek istersiniz:");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (selection == 1)
                {
                    gameStart(first);

                }
                else if (selection == 2)
                {
                    gameStart(second);

                }
                else
                {
                    gameStart(third);

                }
                ilerle();
         //   } while (x > 0);
            return (gameSpace);
        }

        public int[,] gameStart(int[,] b)
        {
            //secilen yolun ilk kordinatı baslangıc noktası olarak alınır
            for (int a = 0; a < 10; a++)
            {
                if (b[9, a] == 1)
                {
                    x = 9;//satir
                    y = a;//sutun
                   Console.SetCursorPosition(y, x);
                    Console.Write("K");
                }
            }
            return (gameSpace);
        }
        //**********
        public void ilerle()
        {
            do { 
              ConsoleKeyInfo okunan = Console.ReadKey();
                if (okunan.Key == ConsoleKey.W) //Duz ilerler
                {
                    x--;
                    if (x > 0)
                    {
                        if (gameSpaceBomb[x, y] != 2)
                        {
                            if (gameSpace[x, y] == 1)
                            {
                                skor++;
                                ciz();
                                puanDurum();
                            }
                            else
                            {//Duvar
                                Console.WriteLine("Duvara carptınız");
                                skor--;
                                puanDurum();
                            }
                        }

                        else
                        {//Bombaya carptıgımızda oyun kapanır
                            Console.Clear();
                            Console.WriteLine("Kaybettiniz !");
                            Console.SetCursorPosition(y, x);
                            puanDurum();
                            Environment.Exit(0);
                        }
                    }
                    else
                    { 
                        Console.Clear();
                        Console.WriteLine("Kazandınız !");
                        puanDurum();
                    }
                }
                else if (okunan.Key == ConsoleKey.A)
                {//Sola ilerler
                    y--;
                    if (x > 0)
                    {
                        if (gameSpaceBomb[x, y] != 2)
                        {
                            if (gameSpace[x, y] == 1)
                            {
                                skor++;
                                ciz();
                                puanDurum();
                            }
                            else
                            {//duvar
                                Console.WriteLine("Duvara carptınız");
                                skor--;
                                puanDurum();
                            }
                        }
                        else
                        {//Bomba
                            Console.Clear();
                            Console.WriteLine("Kaybettiniz !");
                            puanDurum();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {//Labirenti bitirince
                        Console.Clear();
                        Console.WriteLine("Kazandınız !");
                        puanDurum();
                    }

                }
                else if (okunan.Key == ConsoleKey.S)
                {//Geriye ilerler
                    x++;
                    if (x > 0 && x < 9)
                    {
                        if (gameSpaceBomb[x, y] != 2)
                        {
                            if (gameSpace[x, y] == 1)
                            {
                                skor++;
                                ciz();
                                puanDurum();
                            }
                            else
                            {//Duvar
                                Console.WriteLine("Duvara carptınız");
                                skor--;
                                puanDurum();
                            }
                        }
                        else
                        {//Bomba
                            Console.Clear();
                            Console.WriteLine("Kaybettiniz!");
                            puanDurum();
                            Environment.Exit(0);
                        }
                    }
                    else if (x == 0) 
                    {//labirenti tamamlayınca
                        Console.Clear();
                        Console.WriteLine("Kazandınız !");
                        puanDurum();
                    }
                    else if (x == 9)
                    {//Kullanıcı geriye giderek basladigi girise ulasirsa yeniden giris sectirilir.
                        stepOne();
                    }
                }
                else if (okunan.Key == ConsoleKey.D)
                {//Saga ilerler 
                    y++;
                    if (x > 0)
                    {
                        if (gameSpaceBomb[x, y] != 2)
                        {
                            if (gameSpace[x, y] == 1)
                            {
                                skor++;
                                ciz();
                                puanDurum();
                            }
                            else
                            {//Duvar
                                Console.WriteLine("Duvara carptınız");
                                skor--;
                                puanDurum();
                            }
                        }
                        else
                        {//Bomba
                            Console.Clear();
                            Console.WriteLine("Kaybettiniz!");
                            puanDurum();
                            Environment.Exit(0);
                        }
                    }
                    else
                    {//Labirent tamamlanir
                        Console.Clear();
                        Console.WriteLine("Kazandınız !");
                        puanDurum();
                    }
                }
                else if (okunan.Key == ConsoleKey.G)
                { //Klavyeden G tusu okunursa kullanici bombanin yerini görebilir
                    a++;
                    if (a % 2 == 0)
                    {
                        Console.Clear();
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 10; j++)
                                Console.Write("{0}", gameSpaceBomb[i, j]);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Clear();
                        ciz();
                    }
               }
           } while (x >= 0);
                     
        }

       public int[,] ciz()
        {
            Console.Clear();
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write("{0}", gameSpace[i, j]);
                Console.WriteLine();
            }
             Console.SetCursorPosition(y, x);
             Console.Write("K");
             return (gameSpace);
        }

        public void puanDurum()
        {
            Console.SetCursorPosition(15, 15);
            Console.WriteLine("skor:" + skor);
        }
    }
  }
