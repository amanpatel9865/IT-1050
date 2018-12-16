

using System;



namespace MovieTickets

{

    class Program

    { 

        static void Main(string[] args)

        {

            ShowMainMenu();
            ShowInputPrompt();
            string showtimes = Console.ReadLine();
            
              if (showtimes == "1")

             { 

                Console.WriteLine();

                Console.Write("Enter the number of Adults : ");
                double Adults = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of Kids : ");
                double Kids = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of Senior : ");
                double Senior = double.Parse(Console.ReadLine());

                Console.Write("Enter the number of Small Sodas : ");
                double SmallSodas = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of LargeSodas : ");
                double LargeSodas = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of Popcorn : ");
                double Popcorn = double.Parse(Console.ReadLine());

                Console.Write("Enter the number of Candy : ");
                double Candy = double.Parse(Console.ReadLine());

                double total = SmallSodas * 3.50 + LargeSodas * 5.99 + Popcorn * 4.50 + Candy * 1.99 + Adults * 5.99 + Kids * 3.99 + Senior * 4.50;

                double numTickets = Adults + Kids + Senior;
                double min1 = System.Math.Min(Popcorn, LargeSodas);
                double min2 = System.Math.Min(min1, numTickets);
                double discountTotal = (min2 * 2.0);

                if (Candy >= 4)
                {
                    Console.WriteLine();

                    Console.WriteLine("-------------------You will have " + Candy/ 4 + "candies free.-----------------------");
                }

                else
                {
                    Console.WriteLine();
                }

                Console.WriteLine();

                Console.WriteLine("-------------------------------");
                Console.WriteLine(" | Your total is $ "+ total +" | "  );
                Console.WriteLine(" YOUR TOTAL SAVINGS IS $ " + discountTotal);
                Console.WriteLine("-------------------------------");

            }


        

            else if (showtimes == "2")

            {

                Console.WriteLine();

                Console.Write("Enter the number of Adults : ");
                double Adults = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of Kids : ");
                double Kids = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of Senior : ");
                double Senior = double.Parse(Console.ReadLine());

                Console.Write("Enter the number of Small Sodas : ");
                double SmallSodas = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of LargeSodas : ");
                double LargeSodas = double.Parse(System.Console.ReadLine());

                Console.Write("Enter the number of Popcorn : ");
                double Popcorn = double.Parse(Console.ReadLine());

                Console.Write("Enter the number of Candy : ");
                double Candy = double.Parse(Console.ReadLine());

                double total = SmallSodas * 3.50 + LargeSodas * 5.99 + Popcorn * 4.50 + Candy * 1.99 + Adults * 10.99 + Kids * 6.99 + Senior * 8.50;

                
                double numTickets = Adults + Kids + Senior;
                double min1 = System.Math.Min(Popcorn, LargeSodas);
                double min2 = System.Math.Min(min1, numTickets);
                double discountTotal = (min2 * 2.0);

                if (numTickets >= 3 )
                {
                    Console.WriteLine();

                    Console.WriteLine(" You will have bags of popcorn free.");

                }
                else
                {
                    Console.WriteLine();
                }

                if (Candy >= 4)
                {
                    Console.WriteLine();

                    Console.WriteLine(" --------------------------You will have " + Candy / 4 + "bags of candies free.--------------");
                }

                else
                {
                    Console.WriteLine();
                }


                Console.WriteLine();

                Console.WriteLine("-------------------------------");

                Console.WriteLine(" | Your total is $ " + total + " | ");

                Console.WriteLine(" YOUR TOTAL SAVINGS IS " + discountTotal);
                Console.WriteLine("-------------------------------");



            }

            else

            {

                Console.WriteLine();

                Console.WriteLine(" Invalid Command.");

            }

            
  
            Console.WriteLine();

            Console.WriteLine(" Press any key to continue... ");

            Console.WriteLine();

            Console.Write(" ");

            Console.ReadKey();


        }
      
        ////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////
        



        private static void ShowMainMenu()

        {

            Console.WriteLine();

            Console.WriteLine(" +-------------------------------------------+ ");

            Console.WriteLine(" | Please choose from the following options: | ");

            Console.WriteLine(" +-------------------------------------------+ ");

            Console.WriteLine(" | (1) - Morning Showes | ");

            Console.WriteLine(" | (2) - Evening Showes | ");

            Console.WriteLine(" +-------------------------------------------+ ");

        }



        ///////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////////////////////////



        private static void ShowInputPrompt()

        {

            Console.WriteLine();

            Console.Write(" ---> ");

        }



        ///////////////////////////////////////////////////////////////////////////////////////////

        ///////////////////////////////////////////////////////////////////////////////////////////

    }

}