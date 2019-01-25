using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Declare and use a bool, int, double, char, string, and decimal type.
            Implement at least one loop
            Implement at least one if or if-else branch with conditions
            Implement a switch statement
            Implement a simple function calculation (e.g. totalCost or hasEnough)
            Use Console.WriteLine and Console.ReadLine
            Use string interpolation ($"") and \n or \t
            Code must compile and run.*/
            double count = 1;
            while (1 == 1)
            {
                Console.WriteLine("Welcome!!, Please enter your name!");
                String name = Console.ReadLine();
                Console.WriteLine("You above 18? true/false");
                var age = Console.ReadLine();
                bool age1 = Convert.ToBoolean(age);
               

                if (!age1)
                {
                    Console.WriteLine("sorry you have to be above 18 to start trading!!");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine($"Hello {name}");
                Console.WriteLine("Choose the securities from below, separate the names with a comma\n");
                Console.WriteLine("HSBC");
                Console.WriteLine("IBM");
                Console.WriteLine("IVZ");
                Console.WriteLine("TOPIX");
                Console.WriteLine("FTSE\n");
                
                var securities = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("Please find the returns of your securities\n");
                
                String[] security_List = securities.Split(",");
                decimal BOD=0;
                decimal EOD=0;
                int num=1;
                decimal returns=0;
                decimal return_sum=0;
                decimal calc_returns(decimal BOD_in, decimal EOD_in)
                    {
                    return ((EOD-BOD)/BOD)*100;
                }
                
                Console.WriteLine("Number  Security  Shares  BOD  EOD  Returns ");
                Console.WriteLine("--------------------------------------------");
                foreach (String sec in security_List)
                {
                    switch (sec) {
                        case "HSBC":
                            BOD = 50;
                            EOD = 55;
                            returns=calc_returns(BOD, EOD);
                            break;
                        case "IVZ":
                            BOD = 100;
                            EOD = 101;
                            returns = calc_returns(BOD, EOD);
                            break;
                        case "IBM":
                            BOD = 60;
                            EOD = 55;
                            returns = calc_returns(BOD, EOD);
                            break;
                        case "TOPIX":
                            BOD = 90;
                            EOD = 99;
                            returns = calc_returns(BOD, EOD);
                            break;
                        case "FTSE":
                            BOD = 50;
                            EOD = 55;
                            returns = calc_returns(BOD, EOD);
                            break;
                        default:
                            Console.WriteLine($"The security {sec} is not available");
                            break;
                    }
                   Console.WriteLine($" {num}      {sec.PadRight(5)}       1      {BOD}    {EOD}    {Math.Round(returns,2)}%");
                    return_sum = return_sum + returns;
                    num++;
                }
                
                   Console.WriteLine("----------------------------------------------");
                   Console.WriteLine($"Total=                        {Math.Round(return_sum,2)}% \n");
               // char c;
                Console.WriteLine("Press q to quit or x to do it again");
               Char c= Convert.ToChar(Console.ReadLine());
                if (c == 'q')
                {
                    break;
                    Console.ReadLine();
                }
                else if(c!='q')
                    {
                    count++;
                    Console.WriteLine($"Happy to see you again!!, you have visited us for the {count} time");
                }
                
            }

        }
    }
}
