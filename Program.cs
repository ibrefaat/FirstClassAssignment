using System;


namespace FirstAssignment
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            
            Console.WriteLine("Please Enter Series of Numbers Separeted By \"+\" ");
            userInput = Console.ReadLine();

            while (userInput.ToUpper() != "EXIT")
            {
                int sumResult = 0;
                bool isSuccess = true;
                string[] numberList = userInput.Split("+");
               

                foreach(string s in numberList)
                {
                    int convResult = 0;
                    if (Int32.TryParse(s , out convResult))
                    {
                        sumResult += convResult;
                    }
                    else
                    {
                        Console.WriteLine("Invalied Pattern");
                        isSuccess = false;
                        break;
                    }

                }

                if (isSuccess)
                Console.WriteLine("Summition Result is: " + sumResult);
                Console.WriteLine("If You Want Play Again Please Enter Series of Numbers Separeted By \"+\"  OR Enter  \"Exit\" To Exit From Program");
                userInput = Console.ReadLine();

            }

            Console.WriteLine("Goodbye");
            
        }
    }
}