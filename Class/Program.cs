using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("створити ієрархію класів по 2 поля і методами з різними ідент доступа -- ієрархія СПЕціалізованих транспортних засобів ()");
            Hearse qwe = new Hearse();

        }
    }


    abstract class SpecialCars
    {
        protected string characteristic { get; set; }

        internal int mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }
    }

    internal class Hearse : SpecialCars                          //Катафалк
    {
        protected internal int maxNumberSeats;                 //макс кількість місць
        protected internal int numberBodies;                 //кількість тіл
        charcteristic = "Перевезення труни з тілом небіжчика, родичів і близьких померлого на цвинтар";
        protected internal Hearse()
        {
            maxNumberSeats = 1;
            numberBodies = 0;
        }
        protected internal Hearse(int NumberSeats)
        {
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

    }
    class ConventionalFireEngine : FireEngine 
    {
        public ConventionalFireEngine()
        {
            characteristic = "Стандартна пожежна машина доставляє пожежників до місця події";
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
            characteristic = "пожежна машина, на якій встановлено висувну стрілу, яка дозволяє пожежникам добиратися до високих точок.";
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
            characteristic = "пожежна машина з великою сходами, встановленими на осі, що нагадує поворотну платформу. Ключовими функціями поворотних сходів є забезпечення доступу або виходу пожежників та постраждалих на висоті.";
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
            function = "Для очистки снігу";
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
            function = "Для збору і вивезення сміття";
        }
        public string getFunction
        {
            get
            {
                return function;
            }
        }
    }    class StreetSweeper : CleaningVehicles          //Підмітально-прибиральна машина
    {
        public StreetSweeper()
        {
            function = "Для прибирання пішохідних зон, паркових територій, автомобільних міських доріг у обмежених міських умовах.";
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

    }
    class ClassA : Ambulance
    {
        public string Appointment = "для транспортування пацієнтів";
        public string getAppointment()
        {

            return Appointment;

        }
    }
    class ClassB : Ambulance
    {
        public string Appointment = "для екстреної швидкої медичної допомоги";
        public string getAppointment()
        {

            return Appointment;

        }
    }
    class ClassC : Ambulance
    {
        public string Appointment = "реанімобіль";
        public string getAppointment()
        {

            return Appointment;

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
            numberWheels = NumberWheels;
            type = "колісний автокран";
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
            CrawlerType = NCrawlerType;
            type = "колісний автокран";
        }
        public string getType()
        {
            return type;
        }
    }
}

