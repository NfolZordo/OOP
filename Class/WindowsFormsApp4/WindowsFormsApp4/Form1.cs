using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Hearse hearse = new Hearse();
                label7.Text = hearse.mass.ToString();
                richTextBox1.Text = hearse.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\1.jfif");
            }            
            if (radioButton2.Checked)
            {
                ConventionalFireEngine car = new ConventionalFireEngine();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\2.png");
            }            
            if (radioButton3.Checked)
            {
                AerialApparatus car = new AerialApparatus();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\3.jpg");
            }
            if (radioButton4.Checked)
            {
                TurntableLadder car = new TurntableLadder();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\4.jpg");
            }
            if (radioButton5.Checked)
            {
                SnowBlowers car = new SnowBlowers();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\5.jpg");
            }
            if (radioButton6.Checked)
            {
                GarbageTruck car = new GarbageTruck();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\6.jpg");
            }
            if (radioButton7.Checked)
            {
                StreetSweeper car = new StreetSweeper();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\7.jpg");
            }
            if (radioButton8.Checked)
            {
                ClassA car = new ClassA();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\8.jpg");
            }
            if (radioButton9.Checked)
            {
                ClassB car = new ClassB();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\9.jpg");
            }
            if (radioButton10.Checked)
            {
                ClassC car = new ClassC();
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\10.jpg");
            }
            if (radioButton11.Checked)
            {
                WheeledTruckCrane car = new WheeledTruckCrane(10);
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\11.jpg");
            }
            if (radioButton12.Checked)
            {
                CrawlerCrane car = new CrawlerCrane("Тип г.");
                label7.Text = car.mass.ToString();
                richTextBox1.Text = car.characteristic.ToString();
                pictureBox1.Image = Image.FromFile("D:\\II-K_I-C\\OOП\\М\\Class\\WindowsFormsApp4\\img\\12.jpg");
            }
        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    abstract class SpecialCars
    {
        internal string characteristic { get; set; }
        internal int mass { get; set; }
    }

    internal class Hearse : SpecialCars                          //Катафалк
    {
        protected internal int maxNumberSeats;                 //макс кількість місць
        protected internal int numberBodies;                 //кількість тіл
        protected internal Hearse()
        {
            characteristic = "Перевезення труни з тілом небіжчика, родичів і близьких померлого на цвинтар";
            mass = 3000;
            maxNumberSeats = 1;
            numberBodies = 0;
        }
        protected internal Hearse(int NumberSeats)
        {
            characteristic = "Перевезення труни з тілом небіжчика, родичів і близьких померлого на цвинтар";
            mass = 2000;
            maxNumberSeats = NumberSeats;
            numberBodies = 0;
        }
        protected internal void loadBody()
        {
            if (numberBodies < maxNumberSeats)
            {
                numberBodies = +1;
            }
            else { Console.WriteLine("Всі місця зайняті"); }
        }
        protected internal void unloadBody()
        {
            if (numberBodies > 0)
            {
                numberBodies = -1;
            }
            else { Console.WriteLine("Катафалк порожній"); }
        }
        protected internal int getnumberBodies()
        {
            return (numberBodies);
        }
    }

    abstract class FireEngine : SpecialCars          //Пожежна...
    {
        public int waterSupply;                                // запас води(л)
    }
    class ConventionalFireEngine : FireEngine
    {
        public ConventionalFireEngine()
        {
            characteristic = "Стандартна пожежна машина доставляє пожежників до місця події";
            mass = 19000;
            waterSupply = 4000;
        }
        public string getCharacteristic
        {
            get
            {
                return characteristic;
            }
        }
    }
    class AerialApparatus : FireEngine
    {
        public AerialApparatus()
        {
            characteristic = "Пожежна машина, на якій встановлено висувну стрілу, яка дозволяє пожежникам добиратися до високих точок.";
            mass = 12000;
            waterSupply = 3000;
        }
        public string getCharacteristic
        {
            get
            {
                return characteristic;
            }
        }
    }
    class TurntableLadder : FireEngine
    {
        public TurntableLadder()
        {
            characteristic = "Пожежна машина з великою сходами, встановленими на осі, що нагадує поворотну платформу. Ключовими функціями поворотних сходів є забезпечення доступу або виходу пожежників та постраждалих на висоті.";
            mass = 20000;
            waterSupply = 5000;
        }
        public string getCharacteristic
        {
            get
            {
                return characteristic;
            }
        }
    }
    abstract class CleaningVehicles : SpecialCars                    //Прибиральні автомобілі
    {
        private protected string function;
    }

    class SnowBlowers : CleaningVehicles          //Снігоочисники
    {
        public SnowBlowers()
        {
            characteristic = "Машина для очищення від снігу доріг, вулиць, залізничних колій, злітних смуг.";
            function = "Для очистки снігу";
            mass = 15000;
        }
        public string getFunction
        {
            get
            {
                return function;
            }
        }
    }
    class GarbageTruck : CleaningVehicles          //Сміттєвоз
    {
        public GarbageTruck()
        {
            characteristic = "Bантажний автомобіль або інший вид транспорту, призначений для завантаження, ущільнення, транспортування та вивантаження сміття.";
            function = "Для збору і вивезення сміття";
            mass = 16000;
        }
        public string getFunction
        {
            get
            {
                return function;
            }
        }
    }
    class StreetSweeper : CleaningVehicles          //Підмітально-прибиральна машина
    {
        public StreetSweeper()
        {
            characteristic = "Aвтомобіль призначений для прибирання пішохідних зон, паркових територій, автомобільних міських доріг у обмежених міських умовах.";
            function = "Для підмітання доріг.";
            mass = 11000;
        }
        public string getFunction
        {
            get
            {
                return function;
            }
        }
    }

    abstract class Ambulance : SpecialCars               //Швидка
    {
        private protected int numberStaffSeats;
        private protected int numberPatientSeats;
    }
    class ClassA : Ambulance
    {
        public ClassA(){
            characteristic = "Aвтомобіль призначений для транспортування пацієнтів";
            mass = 12000;
            numberStaffSeats = 2;
            numberPatientSeats = 4;
        }
    }
    class ClassB : Ambulance
    {
        public ClassB()
        {
            characteristic = "Aвтомобіль призначений для екстреної швидкої медичної допомоги";
            mass = 11000;
            numberStaffSeats = 4;
            numberPatientSeats = 1;
        }
    }
    class ClassC : Ambulance
    {
        public ClassC()
        {
            characteristic = "Aвтомобіль призначений для перевезення реанімаційної бригади та їх обладнання";
            mass = 10000;
            numberStaffSeats = 5;
            numberPatientSeats = 1;
        }
    }
    class MobileCrane : SpecialCars               //автокран
    {
        internal string type;
    }
    class WheeledTruckCrane : MobileCrane         //колісний автокран
    {
        public int numberWheels;                  //кількість коліс
        public WheeledTruckCrane(int NumberWheels)
        {
            characteristic = "Cамохідний піднімальний кран на автомобільному колісному шасі. ";
            numberWheels = NumberWheels;
            type = "колісний автокран";
            mass = 27000;
        }
        public string getType()
        {
            return type;
        }

    }
    class CrawlerCrane : MobileCrane              //гусеничний автокран
    {
        public string CrawlerType;                //Тип гусениці
        public CrawlerCrane(string NCrawlerType)
        {
            characteristic = "Cамохідний піднімальний кран на автомобільному гусеничному шасі. ";
            CrawlerType = NCrawlerType;
            type = "гусеничний автокран";
            mass = 30000;
        }
        public string getType()
        {
            return type;
        }
    }

}
