using System;
///-----------------------------------------------------------------------------
///   Namespace:    L3_SquaresAndCubes
///   Description:  Input a number to get get the square and cube of it
///   Author:       Derek Wolters                
///   Date:         3.29.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------------------

namespace L3_SquaresAndCubes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //initialize variables
            bool keepGoing = true;

            Console.WriteLine("This program will square and cube a given " +
                "number");

            while (keepGoing)
            {                
                //get input, calculate and display the results
                PrintResults(GetInput());

                //exit program               
                if (ExitProgram()) break;
            }
        }

        //get the user's number
        public static int GetInput()
        {
            string input = "";
            int temp;

            Console.WriteLine("Enter a positive, whole number:");
            input = Console.ReadLine();

            if (!int.TryParse(input, out temp))
            {
                //check that input is an integer & ask for reentry if not
                Console.WriteLine("Input should be a whole number. " +
                    "Try again.");
                return GetInput();
            }
            else if (temp < 1)
            {
                //check that input is withing range & ask for reentry if not
                Console.WriteLine("Input should be greater than 1 or less " +
                     " than 100. Try again.");
                return GetInput();
            }
            else { return temp; }
        }

        //create and display a table of calculated results
        public static void PrintResults(int num)
        {
            string number = "Number";
            string squared = "Squared";
            string cubed = "Cubed";
            int padding = 4;

            //build the heading based on lengths of column labels and padding
            Console.WriteLine(
                number.PadRight(number.Length + padding) +
                squared.PadRight(squared.Length + padding) +
                cubed);

            Console.WriteLine(
                "======".PadRight(number.Length + padding) +
                "=======".PadRight(squared.Length + padding) +
                "=====");

            //calculate and display the results in a table
            for (int i = 1; i < num+1; i++)
            {
                Console.Write(
                    i.ToString().PadRight(number.Length + padding) +  
                    CalcSq(i).ToString().PadRight(squared.Length + padding) + 
                    CalcCu(i) + "\n");
            }
        }

        //calculate the square of a number
        public static int CalcSq(int num)
        {
            //Console.WriteLine(num * num);
            return num * num;
        }
        
        //calculate the cube of a number
        public static int CalcCu(int num)
        {
            //Console.WriteLine(num * num * num);
            return num * num * num;                
        }
        
        //exit the program when the user wants to
        public static Boolean ExitProgram()
        {
            string xitChoice = "";

            Console.WriteLine("Do you want to continue? Enter Y or N.");

            xitChoice = Console.ReadLine().ToUpper();

            while (xitChoice != "N" && xitChoice != "Y")
            {
                Console.WriteLine("Not a vaid answer. Do you want to " +
                    "continue? Enter Y or N.");
                xitChoice = Console.ReadLine().ToUpper();
            }

            return xitChoice == "N" ? true : false;
        }
    }
}
