using System;

namespace Lab_2._6
{
   
    class Converter
    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public double GRN { get; set; }


        public Converter()
        {
            USD = 0;
            EUR = 0;
            RUB = 0;
        }
        public Converter(double usd, double eu, double rub)
        {
            USD = usd;
            EUR = eu;
            RUB = rub;
        }

        public double Convert(int currency, double amount)
        {
            switch (currency)
            {
                // usd to uah
                case 1:
                    return amount * USD;
                // eu to uah
                case 2:
                    return amount * EUR;
                // rub to eur
                case 3:
                    return amount * RUB;
                // uah to usd
                case 4:
                    return amount / USD;
                // uah to eur
                case 5:
                    return amount / EUR;
                // uah to rub
                case 6:
                    return amount / RUB;
                default:
                    Console.WriteLine("An error occurred...");
                    return -1;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rate in the format: USD -> UAH and EUR -> UAH and RUB -> UAH (27 33 0.37)");
            string[] inp = Console.ReadLine().Split(' ');
            double[] input = new double[] { };
            if (inp != null && inp.Length == 3)
            {
                Converter myConv = new Converter(Convert.ToDouble(inp[0]), Convert.ToDouble(inp[1]), Convert.ToDouble(inp[2]));
                Console.WriteLine("UAH to */* TO UAH? (1/2)");
                int _case = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter amount:");
                double amount = Convert.ToDouble(Console.ReadLine());
                switch (_case)
                {
                    case 1:
                        Console.WriteLine("To USD(1)/EUR(2)/RUB(3):");
                        int _caseTo = Int32.Parse(Console.ReadLine());
                        switch (_caseTo)
                        {
                            case 1:
                                Console.WriteLine(myConv.Convert(4, amount));
                                break;
                            case 2:
                                Console.WriteLine(myConv.Convert(5, amount));
                                break;
                            case 3:
                                Console.WriteLine(myConv.Convert(6, amount));
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("From USD to UAH(1)/EUR(2)/RUB(3)");
                        int _caseFrom = Int32.Parse(Console.ReadLine());
                        switch (_caseFrom)
                        {
                            case 1:
                                Console.WriteLine(myConv.Convert(1, amount));
                                break;
                            case 2:
                                Console.WriteLine(myConv.Convert(2, amount));
                                break;
                            case 3:
                                Console.WriteLine(myConv.Convert(3, amount));
                                break;
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
