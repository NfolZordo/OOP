
class Game
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введiть початкову кiлькiсть $ для ставок ");
            int startPoint;
            try
            {
                startPoint = Convert.ToInt32(Console.ReadLine());
            }

            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Ви ввели невiрне значення, спробуйте ще раз ");
                startPoint = Convert.ToInt32(Console.ReadLine());
            }
            var rand = new Random();
            
            int menu;

            RESTART:
            string[] cardsOnTable = new string[5];
            string blankText = cardsOnTable[0];
            int rateOver = 0;                                               //зроблена ставка
            int upperOver = 2;                                             //пiднята ставка
            int whoIsFirstRand = rand.Next(0, 2);                         //чий перший крок
            Deck firstDeck = new Deck();                                 //колода
            string[] cardsInHand1 = { firstDeck.handOutCard(), firstDeck.handOutCard() };
            Player player1 = new Player(startPoint, cardsInHand1);
            string[] cardsInHand2 = { firstDeck.handOutCard(), firstDeck.handOutCard() };
            Player player2 = new Player(startPoint, cardsInHand2);
            

            if (whoIsFirstRand == 0)                                            //роздача / етап 1
            {
                player1.makeBet(1);    //0  я-1 вiн-2
                player2.makeBet(2);  
            }
            else
            {
                player1.makeBet(2);    //1  я-2 вiн-1
                player2.makeBet(1);
            }
            rateOver += 3;
            player1.Rate = 2;
            player2.Rate = 2;
            do
            {
            if (whoIsFirstRand == 1)                                 // етап 2
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
                mainScreen();
            
            try
            {
                menu = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Ви ввели невiрне значення, спробуйте ще раз ");
                menu = Convert.ToInt32(Console.ReadLine());
            }
            if (menu == 1)
            {
                    player2.Points += rateOver;
                    goto RESTART;

                }
            myTurn(menu);
            if (whoIsFirstRand == 0)
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            } while (player1.Rate == player2.Rate);

            for (int i = 0; i < 3; i++)                        // 3 карти на столi   / етап 3
            {
                cardsOnTable[i] = firstDeck.handOutCard();
            }
            do {
            if (whoIsFirstRand == 1)                                
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            mainScreen();
            menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                player2.Points += rateOver;
                goto RESTART;
            }
            myTurn(menu);
            if (whoIsFirstRand == 0)
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            } while (player1.Rate == player2.Rate);
            cardsOnTable[3] = firstDeck.handOutCard();       // 4 карти на столi   / етап 4
            do { 
            if (whoIsFirstRand == 1)
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            mainScreen();
            menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                player2.Points += rateOver;
                goto RESTART;
            }
            myTurn(menu);
            if (whoIsFirstRand == 0)
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            } while (player1.Rate == player2.Rate);
            cardsOnTable[4] = firstDeck.handOutCard();       // 5 карти на столi   / етап 5
            do { 
            if (whoIsFirstRand == 1)
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            mainScreen();
            menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                player2.Points += rateOver;
                goto RESTART;
            }
            myTurn(menu);
            if (whoIsFirstRand == 0)
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            } while (player1.Rate == player2.Rate);
            void mainScreen()
            {
                Console.Clear();
                Console.WriteLine(" Карти противника:ХХХХ                                                                     ");
                Console.WriteLine(" $ противника: "+ player2.Points+ "                                                        ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine(" Ставка: "+ rateOver + "                                                                   ");
                Console.WriteLine("                                                                                           ");
                Console.Write    (" Карти на столi:");
                if (cardsOnTable[0]!=blankText)
                {
                    Console.Write(" " + cardsOnTable[0] + "  " + cardsOnTable[1] + "  " + cardsOnTable[2]);
                } 
                if (cardsOnTable[3]!=blankText)
                {
                    Console.Write("  " + cardsOnTable[3]);
                } 
                if (cardsOnTable[4]!=blankText)
                {
                    Console.Write("  " + cardsOnTable[4]);
                }
                Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine(" Вашi карти: "+ player1.CardsInHand[0] +"  "+ player1.CardsInHand[1] + "                   ");
                Console.WriteLine(" Вашi $: " + player1.Points + "                                                            ");
                if (player1.Rate==player2.Rate)
                {
                    Console.WriteLine(" Вашi дiї: 1-Пас, 2-Наступний хiд, 3-пiдняти ставки                       ");
                }
                else Console.WriteLine(" Вашi дiї: 1-Пас, 2-Пiдтримати ставку, 3-пiдняти ставки                       ");
            }
       /*     void enemyTurn(int whoIsFirstRand)
            {
                if (whoIsFirstRand == 0)
                {
                    player2.makeBet(upperOver);
                    rateOver += upperOver;
                }
            }*/
            void myTurn(int menu)
            {
                if (menu == 1){}
                else if (menu == 2)
                {
                    if (player1.Rate >= player2.Rate)
                    {

                    }
                    else
                    {
                        player1.makeBet(upperOver);
                        rateOver += upperOver;
                    }
                }
                else if (menu == 3)
                {
                    Console.WriteLine(" Введiть на скiльки ви хочите пiдняти ставки");
                    int newRate;
                    try
                    {
                        newRate = Convert.ToInt32(Console.ReadLine());
                    }

                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ви ввели невiрне значення, спробуйте ще раз ");
                        newRate = Convert.ToInt32(Console.ReadLine());
                    }
                    upperOver += newRate;
                    rateOver += upperOver;
                    player1.makeBet(upperOver);
                }
                else { Console.WriteLine("Ви ввели невiрне значення"); }
            }
        }
    }
}
class Player
{
    private string[] cardsInHand = new string[2];
    public string[] CardsInHand 
    { 
        get { return cardsInHand; }  
        set { cardsInHand = value; } 
    } 
    private int points;
    public int Points 
    {
        get { return points; }
        set { points = value; }
    }
    private int rate;
    public int Rate
    {
        get { return rate; }
        set { rate = value; }
    }
    public Player(int startPoint, string[] getingCardsInHand)
    {
        points = startPoint;
        CardsInHand = getingCardsInHand;
    }
    public void makeBet(int bet)
    {
        rate += bet;
        points -= bet;
    }
}
class Deck
{
    private readonly string[] gameDeck = new string[52]{ "1Х", "1Ч", "1П", "1Б", "2Х", "2Ч", "2П", "2Б", "3Х", "3Ч", "3П", "3Б", "4Х", "4Ч", "4П", "4Б", "5Х", "5Ч", "5П", "5Б", "6Х", "6Ч", "6П", "6Б", "7Х", "7Ч", "7П", "7Б", "8Х", "8Ч", "8П", "8Б", "9Х", "9Ч", "9П", "9Б", "10Х", "10Ч", "10П", "10Б", "11Х", "11Ч", "11П", "11Б", "12Х", "12Ч", "12П", "12Б", "13Х", "13Ч", "13П", "13Б", };
    public string[] GameDeck
    {
        get
        {
            return gameDeck;
        }
    }
    private int[] usingDeck = new int[52];
    private int takenСards = -1;
    private bool useOne = true;
    public string handOutCard() {
        if (useOne)
        {
            useOne = false;
            for (int i = 0; i < usingDeck.Length; i++)
            {
                usingDeck[i] = -2;
            } 
        }
        bool boo = true;
        bool whileBreaker = false;
        int repeatError = 0;
        var rand = new Random();
        while (boo)
        {
            while (boo)
            {      
                int aRand = rand.Next(0, 52);
                for (int i = 0; i < usingDeck.Length; i++)
                {
                    if (aRand == usingDeck[i])
                    {
                        whileBreaker = true;
                    }
                }
                if (repeatError > 500)
                {
                    Console.WriteLine("____________Колода закiнчилася____________");
                    Thread.Sleep(2000000);
                }
                if (whileBreaker)
                {
                    repeatError++;
                    whileBreaker = false;
                    break;
                }
                if (takenСards>52)
                {
                    Console.WriteLine("********Колода закiнчилася********");
                }
                else 
                {
                    takenСards++;
                    usingDeck[takenСards] = aRand;
                }
                boo = false;
            } 
        }
        boo = true;
        repeatError = 0;
        try
        {
            return gameDeck[usingDeck[takenСards]];
        }
        catch (System.IndexOutOfRangeException)
        {
            Console.WriteLine("---------------"+ usingDeck[takenСards]+"-----------------");
            return "";
        }
    }
}