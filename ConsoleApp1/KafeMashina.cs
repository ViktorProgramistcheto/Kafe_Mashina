using System;

namespace ConsoleApp1
{
    internal class KafeMashina
    {
        private int mliturVoda;
        private int gramaKafe;
        private bool vkljucheno;


        public int MliturVoda
        {
            get { return mliturVoda; }
            set { mliturVoda = value; }
        }

        public int GramaKafe
        {
            get { return gramaKafe; }
            set { gramaKafe = value; }
        }

        public bool Vkljucheno
        {
            get { return vkljucheno; }
            set { vkljucheno = value; }
        }





        public KafeMashina()
        {


            mliturVoda = 1000;
            gramaKafe = 200;
            vkljucheno = false;
        }







        public void Vkljchi()
        {
            if (vkljucheno)
            {
                Console.WriteLine("Кафе машината вече е включена.");
            }
            else
            {
                vkljucheno = true;
                Console.WriteLine("Кафе машината е включена!");
            }
        }

        public void NapraviKafe(string type)
        {
            if (!vkljucheno)
            {
                Console.WriteLine("Машината е изключена!");
                return;
            }

            int waterNeeded = 0;
            int coffeeNeeded = 0;


            Console.WriteLine("Изчакайте!");

            waterNeeded = 200;
            coffeeNeeded = 10;


            if (mliturVoda >= waterNeeded && gramaKafe >= coffeeNeeded)
            {
                mliturVoda -= waterNeeded;
                gramaKafe -= coffeeNeeded;

                Console.WriteLine($"{type} е готово! Насладете се!");
            }
            else
            {
                Console.WriteLine("Недостатъчно вода или кафе. Заредете машината.");
            }
        }

        public void Zaredi()
        {
            mliturVoda = 1000;
            gramaKafe = 200;
            Console.WriteLine("Машината е заредена!");
        }

        public void Rezervoar()
        {
            Console.WriteLine($"Ниво на водата: {mliturVoda} мл");
            Console.WriteLine($"Ниво на кафето: {gramaKafe} г");
        }
    }
}
