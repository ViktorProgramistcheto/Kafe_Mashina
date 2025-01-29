using ConsoleApp1;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            KafeMashina myMachine = new KafeMashina();

            Console.WriteLine("Добре дошли!");

            myMachine.Rezervoar();


            Console.WriteLine("Изберете действие:");
            Console.WriteLine("1. Включете машината");
            Console.WriteLine("2. Направете кафе");
            Console.WriteLine("3. Допълнете ресурси");
            Console.WriteLine("4. Проверете състоянието");
            Console.WriteLine("5. Изключи");

            while (true)
            {


                string izbor = Console.ReadLine();

                if (izbor == "1")
                {
                    myMachine.Vkljchi();
                }
                else if (izbor == "2")
                {
                    Console.WriteLine("Въведете вид кафе");
                    string coffeeType = Console.ReadLine();

                    myMachine.NapraviKafe(coffeeType);
                }
                else if (izbor == "3")
                {
                    myMachine.Zaredi();
                }
                else if (izbor == "4")
                {
                    myMachine.Rezervoar();
                }
                else if (izbor == "5")
                {
                    Console.WriteLine("Довиждане!");
                    break;
                }
                else
                {
                    Console.WriteLine("ГРЕШКА!!!!!!!!!");
                }



            }
        }
    }
}

