using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class furniture
    {
        private int weight;     //вага
        private bool state;    //стан(розібана/складена)
        private double prise;  //ціна

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public bool State
        {
            get { return state; }
            set { state = value; }
        }
        public double Prise
        {
            get { return prise; }
            set { prise = value; }
        }
        public void Disassemble() { state = false; }
        public void Сollect() { state = true; }
        public void DoDiscount() { prise *= 0.2; }
    }

    abstract class drink
    {
        private int volumeMax;
        private int volume;      //обєм

        public double VolumeMax
        {
            get { return volumeMax; }
            set { volumeMax = value; }
        }
        public double Prise         
        {
            get { return volume; }
            set { volume = value; }
        }
        public void topUp { volume = volumeMax }     //налити
        public void Drink { volume = 0 }           //випити   
    }
}