using System;
using System.Drawing;
using System.Windows.Forms;

namespace PokerGraf
{

    public partial class Form1 : Form
    {
        private int startPoint;
        private int step = 0;
        private Deck firstDeck = new Deck();
        private string[] cardsOnTable = new string[5];
        Player player1 = new Player();
        Player player2 = new Player();
        string[] cardsInHand1 = { "", "" };

        string[] cardsInHand2 = { "", "" };

        private int rateOver = 0;                                               //зроблена ставка
        private int upperOver = 2;                                             //пiднята ставка

        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rateOver = 0;
            upperOver = 2;
            cardsOnTable = new string[5];
            firstDeck = new Deck();
            step = 0;
            pictureBox5.Image = loadImage(" ");
            pictureBox6.Image = loadImage(" ");
            pictureBox7.Image = loadImage(" ");
            pictureBox8.Image = loadImage(" ");
            pictureBox9.Image = loadImage(" ");
            label9.Text = rateOver.ToString();
            label7.Text = player2.Points.ToString();
            label6.Text = player1.Points.ToString();

        }
        private Image loadImage(String nameImage)
        {
            if (nameImage == "2Б") return Properties.Resources._2Б;
            if (nameImage == "3Б") return Properties.Resources._3Б;
            if (nameImage == "4Б") return Properties.Resources._4Б;
            if (nameImage == "5Б") return Properties.Resources._5Б;
            if (nameImage == "6Б") return Properties.Resources._6Б;
            if (nameImage == "7Б") return Properties.Resources._7Б;
            if (nameImage == "8Б") return Properties.Resources._8Б;
            if (nameImage == "9Б") return Properties.Resources._9Б;
            if (nameImage == "10Б") return Properties.Resources._10Б;
            if (nameImage == "11Б") return Properties.Resources._11Б;
            if (nameImage == "12Б") return Properties.Resources._12Б;
            if (nameImage == "13Б") return Properties.Resources._13Б;
            if (nameImage == "14Б") return Properties.Resources._14Б;

            if (nameImage == "2Х") return Properties.Resources._2Х;
            if (nameImage == "3Х") return Properties.Resources._3Х;
            if (nameImage == "4Х") return Properties.Resources._4Х;
            if (nameImage == "5Х") return Properties.Resources._5Х;
            if (nameImage == "6Х") return Properties.Resources._6Х;
            if (nameImage == "7Х") return Properties.Resources._7Х;
            if (nameImage == "8Х") return Properties.Resources._8Х;
            if (nameImage == "9Х") return Properties.Resources._9Х;
            if (nameImage == "10Х") return Properties.Resources._10Х;
            if (nameImage == "11Х") return Properties.Resources._11Х;
            if (nameImage == "12Х") return Properties.Resources._12Х;
            if (nameImage == "13Х") return Properties.Resources._13Х;
            if (nameImage == "14Х") return Properties.Resources._14Х;

            if (nameImage == "2Ч") return Properties.Resources._2Ч;
            if (nameImage == "3Ч") return Properties.Resources._3Ч;
            if (nameImage == "4Ч") return Properties.Resources._4Ч;
            if (nameImage == "5Ч") return Properties.Resources._5Ч;
            if (nameImage == "6Ч") return Properties.Resources._6Ч;
            if (nameImage == "7Ч") return Properties.Resources._7Ч;
            if (nameImage == "8Ч") return Properties.Resources._8Ч;
            if (nameImage == "9Ч") return Properties.Resources._9Ч;
            if (nameImage == "10Ч") return Properties.Resources._10Ч;
            if (nameImage == "11Ч") return Properties.Resources._11Ч;
            if (nameImage == "12Ч") return Properties.Resources._12Ч;
            if (nameImage == "13Ч") return Properties.Resources._13Ч;
            if (nameImage == "14Ч") return Properties.Resources._14Ч;

            if (nameImage == "2П") return Properties.Resources._2П;
            if (nameImage == "3П") return Properties.Resources._3П;
            if (nameImage == "4П") return Properties.Resources._4П;
            if (nameImage == "5П") return Properties.Resources._5П;
            if (nameImage == "6П") return Properties.Resources._6П;
            if (nameImage == "7П") return Properties.Resources._7П;
            if (nameImage == "8П") return Properties.Resources._8П;
            if (nameImage == "9П") return Properties.Resources._9П;
            if (nameImage == "10П") return Properties.Resources._10П;
            if (nameImage == "11П") return Properties.Resources._11П;
            if (nameImage == "12П") return Properties.Resources._12П;
            if (nameImage == "13П") return Properties.Resources._13П;
            if (nameImage == "14П") return Properties.Resources._14П;

            return Properties.Resources.ХХ;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            button1.Visible = false;
            label10.Visible = false;
            textBox1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            label4.Visible = true;
            label6.Visible = true;

            startPoint = Convert.ToInt32(textBox1.Text);
            player1.Points = startPoint;
            player2.Points = startPoint;
            cardsInHand1[0] = firstDeck.handOutCard();
            cardsInHand1[1] = firstDeck.handOutCard();
            cardsInHand2[0] = firstDeck.handOutCard();
            cardsInHand2[1] = firstDeck.handOutCard();

            player1.CardsInHand = cardsInHand1;
            player2.CardsInHand = cardsInHand2;

            pictureBox1.Image = loadImage(cardsInHand2[0]);
            pictureBox2.Image = loadImage(cardsInHand2[1]);
            pictureBox3.Image = loadImage(cardsInHand1[0]);
            pictureBox4.Image = loadImage(cardsInHand1[1]);

            player1.makeBet(1);
            player2.makeBet(2);
            rateOver += 3;
            player1.Rate = 2;
            player2.Rate = 2;
            label9.Text = rateOver.ToString();
            label7.Text = player2.Points.ToString();
            label6.Text = player1.Points.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (step == 0)
            {
                turn();
                step = 1;
            }
            else if (step == 1)
            {
                for (int i = 0; i < 3; i++)                        // 3 карти на столi   / етап 3
                {
                    cardsOnTable[i] = firstDeck.handOutCard();
                }
                pictureBox5.Image = loadImage(cardsOnTable[0]);
                pictureBox6.Image = loadImage(cardsOnTable[1]);
                pictureBox7.Image = loadImage(cardsOnTable[2]);
                step = 2;
            }
            else if (step == 2)
            {
                turn();
                step = 3;
            }
            else if (step == 3)
            {
                cardsOnTable[3] = firstDeck.handOutCard();
                pictureBox8.Image = loadImage(cardsOnTable[3]);

                step = 4;
            }
            else if (step == 4)
            {
                turn();
                step = 5;
            }
            else if (step == 5)
            {
                cardsOnTable[4] = firstDeck.handOutCard();
                pictureBox9.Image = loadImage(cardsOnTable[4]);

                step = 6;
            }
            else if (step == 6)
            {
                turn();
                step = 7;
            }
            else if (step == 7)
            {
                Console.Write("У тебе  ");                      // пiдрахунок результатiв
                int a = combinations(player1.CardsInHand);
                Console.Write("У противника  ");

                if (a >= combinations(player2.CardsInHand))
                {
                    label10.Text = "Ти перемiг";
                    player1.Points += rateOver;
                }
                else
                {
                    label10.Text = "Ти програв";
                    player2.Points += rateOver;
                }
                label10.Visible = true;
                button5.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label9.Text = rateOver.ToString();
                label7.Text = player2.Points.ToString();
                label6.Text = player1.Points.ToString();



            }

        }
        private void turn()
        {
            if (player1.Points - upperOver < 0)
            {
                rateOver += player1.Points;
                player1.makeBet(player1.Points);
            }
            else
            {
                player1.makeBet(upperOver);
                rateOver += upperOver;
            }
            if (player2.Points - upperOver <= 0)
            {
                rateOver += player2.Points;
                player2.makeBet(player2.Points);

            }
            else
            {
                player2.makeBet(upperOver);
                rateOver += upperOver;
            }
            label9.Text = rateOver.ToString();
            label7.Text = player2.Points.ToString();
            label6.Text = player1.Points.ToString();
        }

        int combinations(string[] cardsInHand)
        {

            string[] cardsCombinations = new string[7];
            for (int i = 0; i < cardsOnTable.Length; i++)
            {
                cardsCombinations[i] = cardsOnTable[i];
            }
            cardsCombinations[5] = cardsInHand[0];
            cardsCombinations[6] = cardsInHand[1];

            bool isIn(string elem)
            {
                for (int i = 0; i < cardsCombinations.Length; i++)
                {
                    if (cardsCombinations[i] == elem)
                    {
                        return true;
                    }
                }
                return false;
            }
            bool isInNam(string elem)
            {
                for (int i = 0; i < cardsInHand.Length; i++)
                {
                    if (cardsInHand[i].Substring(0, cardsInHand[i].Length - 1) == elem)
                    {
                        return true;
                    }
                }
                return false;
            }
            bool isInNam2()
            {
                for (int elem = 0; elem <= 13; elem++)
                {
                    int a = -1;
                    int b = -1;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                        {
                            a = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                        {
                            b = i;
                        }
                    }
                    if (a != -1 && b != -1)
                    {
                        return true;
                    }
                }
                return false;
            }
            bool isInNamTwoPairs()
            {

                for (int elem = 0; elem <= 13; elem++)
                {
                    int a = -1;

                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                        {
                            a = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                        {
                            for (int elem2 = 0; elem2 <= 13; elem2++)
                            {
                                int c = -1;
                                if (elem != elem2)
                                {

                                    for (int j = 0; j < cardsCombinations.Length; j++)
                                    {
                                        if ((cardsCombinations[j].Substring(0, cardsCombinations[j].Length - 1) == elem2.ToString()))
                                        {
                                            c = j;
                                        }
                                    }
                                    for (int j = 0; j < cardsCombinations.Length; j++)
                                    {
                                        if ((cardsCombinations[j].Substring(0, cardsCombinations[j].Length - 1) == elem2.ToString()) && j != c)
                                        {
                                            return true;
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
                return false;
            }
            bool isInNam3()
            {
                for (int elem = 0; elem <= 13; elem++)
                {
                    int a = -1;
                    int b = -1;
                    int c = -1;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                        {
                            a = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                        {
                            b = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != b && i != a)
                        {
                            c = i;
                        }
                    }
                    if (a != -1 && b != -1 && c != -1) return true;
                }
                return false;
            }
            bool isInNamFullHouse()
            {
                int c = -1;
                for (int elem = 0; elem <= 13; elem++)
                {
                    int a = -1;
                    int b = -1;

                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                        {
                            a = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                        {
                            b = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != b && i != a)
                        {
                            c = elem;
                        }
                    }

                }
                if (c != -1)
                {
                    for (int elem = 0; elem <= 13; elem++)
                    {
                        if (elem != c)
                        {
                            int a = -1;
                            int b = -1;
                            for (int i = 0; i < cardsCombinations.Length; i++)
                            {
                                if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                                {
                                    a = i;
                                }
                            }
                            for (int i = 0; i < cardsCombinations.Length; i++)
                            {
                                if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                                {
                                    b = i;
                                }
                            }
                            if (a != -1 && b != -1) return true;
                        }
                    }
                }
                return false;
            }

            bool isInNamStreet()
            {
                for (int elem = 2; elem <= 9; elem++)
                {

                    int a = -1;
                    int b = -1;
                    int c = -1;
                    int d = -1;
                    int e = -1;
                    int elemT = elem;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if (cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString())
                        {
                            a = i;
                        }
                    }
                    elemT++;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != a)
                        {
                            b = i;
                        }
                    }
                    elemT++;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != b && i != a)
                        {
                            c = i;
                        }
                    }
                    elemT++;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != b && i != a && i != c)
                        {
                            d = i;
                        }
                    }
                    elemT++;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != b && i != a && i != c && i != d)
                        {
                            e = i;
                        }
                    }
                    if (a != -1 && b != -1 && c != -1 && d != -1 && e != -1) return true;
                }
                return false;
            }

            bool isInMasFlash(string elem)
            {
                int a = -1;
                int b = -1;
                int c = -1;
                int d = -1;
                int e = -1;
                for (int i = 0; i < cardsCombinations.Length; i++)
                {
                    if (cardsCombinations[i].Substring(1) == elem)
                    {
                        a = i;
                    }
                }
                for (int i = 0; i < cardsCombinations.Length; i++)
                {
                    if (cardsCombinations[i].Substring(1) == elem && i != a)
                    {
                        b = i;
                    }
                }
                for (int i = 0; i < cardsCombinations.Length; i++)
                {
                    if (cardsCombinations[i].Substring(1) == elem && i != a && i != b)
                    {
                        c = i;
                    }
                }
                for (int i = 0; i < cardsCombinations.Length; i++)
                {
                    if (cardsCombinations[i].Substring(1) == elem && i != a && i != b && i != c)
                    {
                        d = i;
                    }
                }
                for (int i = 0; i < cardsCombinations.Length; i++)
                {
                    if (cardsCombinations[i].Substring(1) == elem && i != a && i != b && i != c && i != d)
                    {
                        e = i;
                    }
                }
                if (e != -1 && a != -1 && b != -1 && c != -1 && d != -1) return true;
                else return false;
            }
            //«Роял Стрит Флеш» – 5 самых старших одномастных карт.
            if ((isIn("14Х") && isIn("13Х") && isIn("12Х") && isIn("11Х") && isIn("10Х")) || (isIn("14Ч") && isIn("13Ч") && isIn("12Ч") && isIn("11Ч") && isIn("10П")) || (isIn("14П") && isIn("13П") && isIn("12П") && isIn("11П") && isIn("10П")) || (isIn("14Б") && isIn("13Б") && isIn("12Б") && isIn("11Б") && isIn("10Б")))
            {
                Console.WriteLine("Роял Стрит Флеш");
                return 50;
            }
            //«Стрит Флеш» – 5 карт одной масти по порядку.
            else if ((isIn("13Х") && isIn("12Х") && isIn("11Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("12Х") && isIn("11Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("11Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("6Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("6Х") && isIn("5Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("6Х") && isIn("5Х") && isIn("4Х")) || (isIn("3Х") && isIn("7Х") && isIn("6Х") && isIn("5Х") && isIn("4Х")) || (isIn("3Х") && isIn("2Х") && isIn("6Х") && isIn("5Х") && isIn("4Х")) ||
                     (isIn("13Ч") && isIn("12Ч") && isIn("11Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("12Ч") && isIn("11Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("11Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("6Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("6Ч") && isIn("5Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("6Ч") && isIn("5Ч") && isIn("4Ч")) || (isIn("3Ч") && isIn("7Ч") && isIn("6Ч") && isIn("5Ч") && isIn("4Ч")) || (isIn("3Ч") && isIn("2Ч") && isIn("6Ч") && isIn("5Ч") && isIn("4Ч")) ||
                     (isIn("13П") && isIn("12П") && isIn("11П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("12П") && isIn("11П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("11П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("6П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("6П") && isIn("5П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("6П") && isIn("5П") && isIn("4П")) || (isIn("3П") && isIn("7П") && isIn("6П") && isIn("5П") && isIn("4П")) || (isIn("3П") && isIn("2П") && isIn("6П") && isIn("5П") && isIn("4П")) ||
                     (isIn("13Б") && isIn("12Б") && isIn("11Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("12Б") && isIn("11Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("11Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("6Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("6Б") && isIn("5Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("6Б") && isIn("5Б") && isIn("4Б")) || (isIn("3Б") && isIn("7Б") && isIn("6Б") && isIn("5Б") && isIn("4Б")) || (isIn("3Б") && isIn("2Б") && isIn("6Б") && isIn("5Б") && isIn("4Б")))
            {
                Console.WriteLine("Стрит Флеш");
                return 49;
            }
            //«Каре» – 4 карты одного ранга.
            else if ((isIn("14Х") && isIn("14Ч") && isIn("14П") && isIn("14Б")) ||
                (isIn("2Х") && isIn("2Ч") && isIn("2П") && isIn("2Б")) ||
                (isIn("3Х") && isIn("3Ч") && isIn("3П") && isIn("3Б")) ||
                (isIn("4Х") && isIn("4Ч") && isIn("4П") && isIn("4Б")) ||
                (isIn("5Х") && isIn("5Ч") && isIn("5П") && isIn("5Б")) ||
                (isIn("6Х") && isIn("6Ч") && isIn("6П") && isIn("6Б")) ||
                (isIn("7Х") && isIn("7Ч") && isIn("7П") && isIn("7Б")) ||
                (isIn("8Х") && isIn("8Ч") && isIn("8П") && isIn("8Б")) ||
                (isIn("9Х") && isIn("9Ч") && isIn("9П") && isIn("9Б")) ||
                (isIn("10Х") && isIn("10Ч") && isIn("10П") && isIn("10Б")) ||
                (isIn("11Х") && isIn("11Ч") && isIn("11П") && isIn("11Б")) ||
                (isIn("12Х") && isIn("12Ч") && isIn("12П") && isIn("12Б")) ||
                (isIn("13Х") && isIn("13Ч") && isIn("13П") && isIn("13Б")))
            {
                Console.WriteLine("Каре");
                return 48;
            }
            //«Фулл Хаус» – комбинация, включающая в себя «Пару» и «Тройку» одновременно.
            else if (isInNamFullHouse())
            {
                Console.WriteLine("Фулл Хаус");
                return 47;
            }
            //«Флеш» – 5 одномастных карт.
            else if (isInMasFlash("Х") || isInMasFlash("Ч") || isInMasFlash("Б") || isInMasFlash("П"))
            {
                Console.WriteLine("Флеш");
                return 46;
            }
            // «Стрит» – 5 собранных по порядку карт любой масти.
            else if (isInNamStreet())
            {
                Console.WriteLine("Стрит");
                return 45;
            }
            //«Тройка» – 3 карты одного ранга.
            else if (isInNam3())
            {
                Console.WriteLine("Тройка");
                return 44;
            }
            //«Две пары» – 4 карты, среди которых собраны по 2 одинаковых по рангу.
            else if (isInNamTwoPairs())
            {
                Console.WriteLine("Двi пари");
                return 43;
            }
            else if (isInNam2())
            {
                Console.WriteLine("Пара");
                return 42;
            }

            else if (isInNam("14")) { Console.WriteLine("Вища карта"); return 41; }
            else if (isInNam("13")) { Console.WriteLine("Вища карта"); return 40; }
            else if (isInNam("12")) { Console.WriteLine("Вища карта"); return 39; }
            else if (isInNam("11")) { Console.WriteLine("Вища карта"); return 38; }
            else if (isInNam("10")) { Console.WriteLine("Вища карта"); return 37; }
            else if (isInNam("9")) { Console.WriteLine("Вища карта"); return 36; }
            else if (isInNam("8")) { Console.WriteLine("Вища карта"); return 35; }
            else if (isInNam("7")) { Console.WriteLine("Вища карта"); return 34; }
            else if (isInNam("6")) { Console.WriteLine("Вища карта"); return 33; }
            else if (isInNam("5")) { Console.WriteLine("Вища карта"); return 32; }
            else if (isInNam("4")) { Console.WriteLine("Вища карта"); return 31; }
            else if (isInNam("3")) { Console.WriteLine("Вища карта"); return 30; }
            else if (isInNam("2")) { Console.WriteLine("Вища карта"); return 29; }

            else return 1;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            label10.Text = "Введiть на скiльки ви хочите пiдняти ставки";
            label10.Visible = true;
            textBox1.Visible = true;
            textBox1.Text = "";
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            rateOver = 0;
            upperOver = 2;
            cardsOnTable = new string[5];
            firstDeck = new Deck();
            step = 0;
            pictureBox5.Image = loadImage(" ");
            pictureBox6.Image = loadImage(" ");
            pictureBox7.Image = loadImage(" ");
            pictureBox8.Image = loadImage(" ");
            pictureBox9.Image = loadImage(" ");
            label10.Visible = false;
            button5.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;



        }

        private void button6_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            button6.Visible = false;
            textBox1.Visible= false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            int newRate = Convert.ToInt32(textBox1.Text);
            upperOver += newRate;
        }
    }
}
/*
class Game
{
    static void GameM()
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
            string endMenu;

            Player player1 = new Player(startPoint);
            Player player2 = new Player(startPoint);

        RESTART:
            int rateOver = 0;                                               //зроблена ставка
            int upperOver = 2;                                             //пiднята ставка
            string[] cardsOnTable = new string[5];
            string blankText = cardsOnTable[0];
            int whoIsFirstRand = rand.Next(0, 2);                         //чий перший крок
            Deck firstDeck = new Deck();                                 //колода
            string[] cardsInHand1 = { firstDeck.handOutCard(), firstDeck.handOutCard() };
            player1.CardsInHand = cardsInHand1;
            string[] cardsInHand2 = { firstDeck.handOutCard(), firstDeck.handOutCard() };
            player2.CardsInHand = cardsInHand2;



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
            do                                                  // етап 2
            {
                if (whoIsFirstRand == 1)
                {
                    yoTurn();
                }
                mainScreen();
                do
                {
                    try
                    {
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ви ввели невiрне значення, спробуйте ще раз ");
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                } while (menu != 1 && menu != 2 && menu != 3);
                if (menu == 1)
                {
                    player2.Points += rateOver;
                    goto RESTART;

                }
                myTurn(menu);
                if (whoIsFirstRand == 0)
                {
                    yoTurn();
                }

            } while (menu == 3 & whoIsFirstRand == 1);

            for (int i = 0; i < 3; i++)                        // 3 карти на столi   / етап 3
            {
                cardsOnTable[i] = firstDeck.handOutCard();
            }
            do
            {
                if (whoIsFirstRand == 1)
                {
                    yoTurn();
                }
                mainScreen();
                do
                {
                    try
                    {
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ви ввели невiрне значення, спробуйте ще раз ");
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                } while (menu != 1 && menu != 2 && menu != 3);
                if (menu == 1)
                {
                    player2.Points += rateOver;
                    goto RESTART;
                }
                myTurn(menu);
                if (whoIsFirstRand == 0)
                {
                    yoTurn();
                }
            } while (menu == 3 & whoIsFirstRand == 1);
            cardsOnTable[3] = firstDeck.handOutCard();       // 4 карти на столi   / етап 4
            do
            {
                if (whoIsFirstRand == 1)
                {
                    yoTurn();
                }
                mainScreen();
                do
                {
                    try
                    {
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ви ввели невiрне значення, спробуйте ще раз ");
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                } while (menu != 1 && menu != 2 && menu != 3);
                if (menu == 1)
                {
                    player2.Points += rateOver;
                    goto RESTART;
                }
                myTurn(menu);
                if (whoIsFirstRand == 0)
                {
                    yoTurn();
                }
            } while (menu == 3 & whoIsFirstRand == 1);
            cardsOnTable[4] = firstDeck.handOutCard();       // 5 карти на столi   / етап 5
            do
            {
                if (whoIsFirstRand == 1)
                {
                    yoTurn();
                }
                mainScreen();
                do
                {
                    try
                    {
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("Ви ввели невiрне значення, спробуйте ще раз ");
                        menu = Convert.ToInt32(Console.ReadLine());
                    }
                } while (menu != 1 && menu != 2 && menu != 3); if (menu == 1)
                {
                    player2.Points += rateOver;
                    goto RESTART;
                }
                myTurn(menu);
                if (whoIsFirstRand == 0)
                {
                    yoTurn();
                }
            } while (menu == 3 & whoIsFirstRand == 1);
            Console.Write("У тебе  ");                      // пiдрахунок результатiв
            int a = combinations(player1.CardsInHand);
            Console.Write("У противника  ");
            if (a >= combinations(player2.CardsInHand))
            {
                Console.WriteLine("Ти перемiг");
                player1.Points += rateOver;
            }
            else
            {
                Console.WriteLine("Ти програв");
                player2.Points += rateOver;
            }
            if (player1.Points <= 0)
            {
                Console.WriteLine("У тебе закiнчилася валюта ");
                Console.WriteLine("1-зiграти ще раз 2-завершити");
                endMenu = Console.ReadLine();
                if (endMenu == "2") break;
                else continue;
            }
            else if (player2.Points <= 0)
            {
                Console.WriteLine("У противника закiнчилася валюта ");
                Console.WriteLine("1-зiграти ще раз 2-завершити");
                endMenu = Console.ReadLine();
                if (endMenu == "2") break;
                else continue;
            }
            Console.WriteLine("1-зiграти ще раз 2-завершити");
            endMenu = Console.ReadLine();
            if (endMenu == "2") break;
            goto RESTART;
            void mainScreen()
            {
                Console.Clear();
                Console.WriteLine(" Карти противника:" + player2.CardsInHand[0] + "  " + player2.CardsInHand[1] + "             ");
                Console.WriteLine(" $ противника: " + player2.Points + "                                                        ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine(" Ставка: " + rateOver + "                                                                    ");
                Console.WriteLine("                                                                                             ");
                Console.Write(" Карти на столi:");
                if (cardsOnTable[0] != blankText)
                {
                    Console.Write(" " + cardsOnTable[0] + "  " + cardsOnTable[1] + "  " + cardsOnTable[2]);
                }
                if (cardsOnTable[3] != blankText)
                {
                    Console.Write("  " + cardsOnTable[3]);
                }
                if (cardsOnTable[4] != blankText)
                {
                    Console.Write("  " + cardsOnTable[4]);
                }
                Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                           ");
                Console.WriteLine(" Вашi карти: " + player1.CardsInHand[0] + "  " + player1.CardsInHand[1] + "                   ");
                Console.WriteLine(" Вашi $: " + player1.Points + "                                                            ");
                if (player1.Rate == player2.Rate)
                {
                    Console.WriteLine(" Вашi дiї: 1-Пас, 2-Наступний хiд, 3-Пiдняти ставки                       ");
                }
                else Console.WriteLine(" Вашi дiї: 1-Пас, 2-Пiдтримати ставку, 3-Пiдняти ставки                       ");
            }
            void myTurn(int menu1)
            {
                if (menu1 == 1) { }
                else if (menu1 == 2)
                {
                    if (player1.Rate >= player2.Rate)
                    {

                    }
                    else
                    {
                        if (player1.Points - upperOver < 0)
                        {
                            rateOver += player1.Points;
                            player1.makeBet(player1.Points);
                        }
                        else
                        {
                            player1.makeBet(upperOver);
                            rateOver += upperOver;
                        }
                    }
                }
                else if (menu1 == 3)
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
                    if (player1.Points - upperOver < 0)
                    {
                        rateOver += player1.Points;
                        player1.makeBet(player1.Points);
                    }
                    else
                    {
                        player1.makeBet(upperOver);
                        rateOver += upperOver;
                    }
                }
                else
                {
                    Console.WriteLine("Ви ввели невiрне значення");
                }
            }
            void yoTurn()
            {
                if (player2.Points - upperOver <= 0)
                {
                    rateOver += player2.Points;
                    player2.makeBet(player2.Points);

                }
                else
                {
                    player2.makeBet(upperOver);
                    rateOver += upperOver;
                }
            }
            int combinations(string[] cardsInHand)
            {

                string[] cardsCombinations = new string[7];
                for (int i = 0; i < cardsOnTable.Length; i++)
                {
                    cardsCombinations[i] = cardsOnTable[i];
                }
                cardsCombinations[5] = cardsInHand[0];
                cardsCombinations[6] = cardsInHand[1];

                bool isIn(string elem)
                {
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if (cardsCombinations[i] == elem)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                bool isInNam(string elem)
                {
                    for (int i = 0; i < cardsInHand.Length; i++)
                    {
                        if (cardsInHand[i].Substring(0, cardsInHand[i].Length - 1) == elem)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                bool isInNam2()
                {
                    for (int elem = 0; elem <= 13; elem++)
                    {
                        a = -1;
                        int b = -1;
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                            {
                                a = i;
                            }
                        }
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                            {
                                b = i;
                            }
                        }
                        if (a != -1 && b != -1)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                bool isInNamTwoPairs()
                {

                    for (int elem = 0; elem <= 13; elem++)
                    {
                        a = -1;

                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                            {
                                a = i;
                            }
                        }
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                            {
                                for (int elem2 = 0; elem2 <= 13; elem2++)
                                {
                                    int c = -1;
                                    if (elem != elem2)
                                    {

                                        for (int j = 0; j < cardsCombinations.Length; j++)
                                        {
                                            if ((cardsCombinations[j].Substring(0, cardsCombinations[j].Length - 1) == elem2.ToString()))
                                            {
                                                c = j;
                                            }
                                        }
                                        for (int j = 0; j < cardsCombinations.Length; j++)
                                        {
                                            if ((cardsCombinations[j].Substring(0, cardsCombinations[j].Length - 1) == elem2.ToString()) && j != c)
                                            {
                                                return true;
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                    return false;
                }
                bool isInNam3()
                {
                    for (int elem = 0; elem <= 13; elem++)
                    {
                        a = -1;
                        int b = -1;
                        int c = -1;
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                            {
                                a = i;
                            }
                        }
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                            {
                                b = i;
                            }
                        }
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != b && i != a)
                            {
                                c = i;
                            }
                        }
                        if (a != -1 && b != -1 && c != -1) return true;
                    }
                    return false;
                }
                bool isInNamFullHouse()
                {
                    int c = -1;
                    for (int elem = 0; elem <= 13; elem++)
                    {
                        a = -1;
                        int b = -1;

                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                            {
                                a = i;
                            }
                        }
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                            {
                                b = i;
                            }
                        }
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != b && i != a)
                            {
                                c = elem;
                            }
                        }

                    }
                    if (c != -1)
                    {
                        for (int elem = 0; elem <= 13; elem++)
                        {
                            if (elem != c)
                            {
                                a = -1;
                                int b = -1;
                                for (int i = 0; i < cardsCombinations.Length; i++)
                                {
                                    if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()))
                                    {
                                        a = i;
                                    }
                                }
                                for (int i = 0; i < cardsCombinations.Length; i++)
                                {
                                    if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString()) && i != a)
                                    {
                                        b = i;
                                    }
                                }
                                if (a != -1 && b != -1) return true;
                            }
                        }
                    }
                    return false;
                }

                bool isInNamStreet()
                {
                    for (int elem = 2; elem <= 9; elem++)
                    {

                        a = -1;
                        int b = -1;
                        int c = -1;
                        int d = -1;
                        int e = -1;
                        int elemT = elem;
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if (cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elem.ToString())
                            {
                                a = i;
                            }
                        }
                        elemT++;
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != a)
                            {
                                b = i;
                            }
                        }
                        elemT++;
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != b && i != a)
                            {
                                c = i;
                            }
                        }
                        elemT++;
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != b && i != a && i != c)
                            {
                                d = i;
                            }
                        }
                        elemT++;
                        for (int i = 0; i < cardsCombinations.Length; i++)
                        {
                            if ((cardsCombinations[i].Substring(0, cardsCombinations[i].Length - 1) == elemT.ToString()) && i != b && i != a && i != c && i != d)
                            {
                                e = i;
                            }
                        }
                        if (a != -1 && b != -1 && c != -1 && d != -1 && e != -1) return true;
                    }
                    return false;
                }

                bool isInMasFlash(string elem)
                {
                    a = -1;
                    int b = -1;
                    int c = -1;
                    int d = -1;
                    int e = -1;
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if (cardsCombinations[i].Substring(1) == elem)
                        {
                            a = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if (cardsCombinations[i].Substring(1) == elem && i != a)
                        {
                            b = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if (cardsCombinations[i].Substring(1) == elem && i != a && i != b)
                        {
                            c = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if (cardsCombinations[i].Substring(1) == elem && i != a && i != b && i != c)
                        {
                            d = i;
                        }
                    }
                    for (int i = 0; i < cardsCombinations.Length; i++)
                    {
                        if (cardsCombinations[i].Substring(1) == elem && i != a && i != b && i != c && i != d)
                        {
                            e = i;
                        }
                    }
                    if (e != -1 && a != -1 && b != -1 && c != -1 && d != -1) return true;
                    else return false;
                }
                //«Роял Стрит Флеш» – 5 самых старших одномастных карт.
                if ((isIn("14Х") && isIn("13Х") && isIn("12Х") && isIn("11Х") && isIn("10Х")) || (isIn("14Ч") && isIn("13Ч") && isIn("12Ч") && isIn("11Ч") && isIn("10П")) || (isIn("14П") && isIn("13П") && isIn("12П") && isIn("11П") && isIn("10П")) || (isIn("14Б") && isIn("13Б") && isIn("12Б") && isIn("11Б") && isIn("10Б")))
                {
                    Console.WriteLine("Роял Стрит Флеш");
                    return 50;
                }
                //«Стрит Флеш» – 5 карт одной масти по порядку.
                else if ((isIn("13Х") && isIn("12Х") && isIn("11Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("12Х") && isIn("11Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("11Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("6Х") && isIn("10Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("6Х") && isIn("5Х") && isIn("9Х")) || (isIn("8Х") && isIn("7Х") && isIn("6Х") && isIn("5Х") && isIn("4Х")) || (isIn("3Х") && isIn("7Х") && isIn("6Х") && isIn("5Х") && isIn("4Х")) || (isIn("3Х") && isIn("2Х") && isIn("6Х") && isIn("5Х") && isIn("4Х")) ||
                         (isIn("13Ч") && isIn("12Ч") && isIn("11Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("12Ч") && isIn("11Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("11Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("6Ч") && isIn("10Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("6Ч") && isIn("5Ч") && isIn("9Ч")) || (isIn("8Ч") && isIn("7Ч") && isIn("6Ч") && isIn("5Ч") && isIn("4Ч")) || (isIn("3Ч") && isIn("7Ч") && isIn("6Ч") && isIn("5Ч") && isIn("4Ч")) || (isIn("3Ч") && isIn("2Ч") && isIn("6Ч") && isIn("5Ч") && isIn("4Ч")) ||
                         (isIn("13П") && isIn("12П") && isIn("11П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("12П") && isIn("11П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("11П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("6П") && isIn("10П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("6П") && isIn("5П") && isIn("9П")) || (isIn("8П") && isIn("7П") && isIn("6П") && isIn("5П") && isIn("4П")) || (isIn("3П") && isIn("7П") && isIn("6П") && isIn("5П") && isIn("4П")) || (isIn("3П") && isIn("2П") && isIn("6П") && isIn("5П") && isIn("4П")) ||
                         (isIn("13Б") && isIn("12Б") && isIn("11Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("12Б") && isIn("11Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("11Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("6Б") && isIn("10Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("6Б") && isIn("5Б") && isIn("9Б")) || (isIn("8Б") && isIn("7Б") && isIn("6Б") && isIn("5Б") && isIn("4Б")) || (isIn("3Б") && isIn("7Б") && isIn("6Б") && isIn("5Б") && isIn("4Б")) || (isIn("3Б") && isIn("2Б") && isIn("6Б") && isIn("5Б") && isIn("4Б")))
                {
                    Console.WriteLine("Стрит Флеш");
                    return 49;
                }
                //«Каре» – 4 карты одного ранга.
                else if ((isIn("14Х") && isIn("14Ч") && isIn("14П") && isIn("14Б")) ||
                    (isIn("2Х") && isIn("2Ч") && isIn("2П") && isIn("2Б")) ||
                    (isIn("3Х") && isIn("3Ч") && isIn("3П") && isIn("3Б")) ||
                    (isIn("4Х") && isIn("4Ч") && isIn("4П") && isIn("4Б")) ||
                    (isIn("5Х") && isIn("5Ч") && isIn("5П") && isIn("5Б")) ||
                    (isIn("6Х") && isIn("6Ч") && isIn("6П") && isIn("6Б")) ||
                    (isIn("7Х") && isIn("7Ч") && isIn("7П") && isIn("7Б")) ||
                    (isIn("8Х") && isIn("8Ч") && isIn("8П") && isIn("8Б")) ||
                    (isIn("9Х") && isIn("9Ч") && isIn("9П") && isIn("9Б")) ||
                    (isIn("10Х") && isIn("10Ч") && isIn("10П") && isIn("10Б")) ||
                    (isIn("11Х") && isIn("11Ч") && isIn("11П") && isIn("11Б")) ||
                    (isIn("12Х") && isIn("12Ч") && isIn("12П") && isIn("12Б")) ||
                    (isIn("13Х") && isIn("13Ч") && isIn("13П") && isIn("13Б")))
                {
                    Console.WriteLine("Каре");
                    return 48;
                }
                //«Фулл Хаус» – комбинация, включающая в себя «Пару» и «Тройку» одновременно.
                else if (isInNamFullHouse())
                {
                    Console.WriteLine("Фулл Хаус");
                    return 47;
                }
                //«Флеш» – 5 одномастных карт.
                else if (isInMasFlash("Х") || isInMasFlash("Ч") || isInMasFlash("Б") || isInMasFlash("П"))
                {
                    Console.WriteLine("Флеш");
                    return 46;
                }
                // «Стрит» – 5 собранных по порядку карт любой масти.
                else if (isInNamStreet())
                {
                    Console.WriteLine("Стрит");
                    return 45;
                }
                //«Тройка» – 3 карты одного ранга.
                else if (isInNam3())
                {
                    Console.WriteLine("Тройка");
                    return 44;
                }
                //«Две пары» – 4 карты, среди которых собраны по 2 одинаковых по рангу.
                else if (isInNamTwoPairs())
                {
                    Console.WriteLine("Двi пари");
                    return 43;
                }
                else if (isInNam2())
                {
                    Console.WriteLine("Пара");
                    return 42;
                }

                else if (isInNam("14")) { Console.WriteLine("Вища карта"); return 41; }
                else if (isInNam("13")) { Console.WriteLine("Вища карта"); return 40; }
                else if (isInNam("12")) { Console.WriteLine("Вища карта"); return 39; }
                else if (isInNam("11")) { Console.WriteLine("Вища карта"); return 38; }
                else if (isInNam("10")) { Console.WriteLine("Вища карта"); return 37; }
                else if (isInNam("9")) { Console.WriteLine("Вища карта"); return 36; }
                else if (isInNam("8")) { Console.WriteLine("Вища карта"); return 35; }
                else if (isInNam("7")) { Console.WriteLine("Вища карта"); return 34; }
                else if (isInNam("6")) { Console.WriteLine("Вища карта"); return 33; }
                else if (isInNam("5")) { Console.WriteLine("Вища карта"); return 32; }
                else if (isInNam("4")) { Console.WriteLine("Вища карта"); return 31; }
                else if (isInNam("3")) { Console.WriteLine("Вища карта"); return 30; }
                else if (isInNam("2")) { Console.WriteLine("Вища карта"); return 29; }

                else return 1;
            }
        }
    }
}*/
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
    public Player(int startPoint)
    {
        points = startPoint;
    }
    public Player()
    {
    }
    public void makeBet(int bet)
    {
        rate += bet;
        points -= bet;
    }
}
class Deck
{
    private readonly string[] gameDeck = new string[52] { "14Х", "14Ч", "14П", "14Б", "2Х", "2Ч", "2П", "2Б", "3Х", "3Ч", "3П", "3Б", "4Х", "4Ч", "4П", "4Б", "5Х", "5Ч", "5П", "5Б", "6Х", "6Ч", "6П", "6Б", "7Х", "7Ч", "7П", "7Б", "8Х", "8Ч", "8П", "8Б", "9Х", "9Ч", "9П", "9Б", "10Х", "10Ч", "10П", "10Б", "11Х", "11Ч", "11П", "11Б", "12Х", "12Ч", "12П", "12Б", "13Х", "13Ч", "13П", "13Б", };
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
    public string handOutCard()
    {
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
                if (whileBreaker)
                {
                    repeatError++;
                    whileBreaker = false;
                    break;
                }
                if (takenСards > 52)
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
            Console.WriteLine("---------------" + usingDeck[takenСards] + "-----------------");
            return "";
        }
    }
}


