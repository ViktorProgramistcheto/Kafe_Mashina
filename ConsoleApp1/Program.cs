namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.OutputEncoding = System.Text.Encoding.UTF8;

            KafeMashina myMachine = new KafeMashina();

            Console.WriteLine("Добре дошли!");

            myMachine.DisplayStatus();

            while (true)
            {
                Console.WriteLine("Изберете действие:");
                Console.WriteLine("1. Включете машината");
                Console.WriteLine("2. Направете кафе");
                Console.WriteLine("3. Допълнете ресурси");
                Console.WriteLine("4. Проверете състоянието");
                Console.WriteLine("5. Изключи");

                string izbor = Console.ReadLine()?.Trim();

                if (izbor == "1")
                {
                    myMachine.TurnOn();
                }
                else if (izbor == "2")
                {
                    Console.WriteLine("Въведете вид кафе");
                    string coffeeType = Console.ReadLine();

                    myMachine.MakeCoffee(coffeeType);
                }
                else if (izbor == "3")
                {
                    myMachine.Zaredi();
                }
                else if (izbor == "4")
                {
                    myMachine.DisplayStatus();
                }
                else if (izbor == "5")
                {
                    Console.WriteLine("Довиждане!");
                    break; 
                }
                else
                {
                    Console.WriteLine("Невалиден избор. Опитайте отново.");
                }



            }
        }
    }
}
