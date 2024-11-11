namespace IterationStatements
{
    public class Program
    {
        int i;
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers1000()
        {


            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void UpThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static void AreNumsEqual(int numone, int numtwo)
        {
            if(numone == numtwo)
            {
                Console.WriteLine($"{numone} and {numtwo} are equal!");
            }
            else
            {
                Console.WriteLine($"{numone} and {numtwo} are not equal.");
            }
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static void EvanOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine("That number is evan!");
            }
            else
            {
                Console.WriteLine("That number is odd!");
            }
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static void IsPosOrNeg(int number)
        {
            if(number >= 0)
            {
                Console.WriteLine("That number is posative!");
            }
            else
            {
                Console.WriteLine("That number is negative!");
            }
        }
        
        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static void CanVote()
        {
            Console.WriteLine("Please enter your age!");
            var canParse = int.TryParse(Console.ReadLine(), out int UserAge);

            while(canParse == false)
            {
                Console.WriteLine("Please enter a valid age.");
                canParse = int.TryParse(Console.ReadLine(), out UserAge);
            }

            if (UserAge >= 18)
            {
                Console.WriteLine($"Congrats, {UserAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry {UserAge} Is not old enough to vote.");

            }
            
            
            //Console.WriteLine("Please enter your age.");
            //var canParse = int TryParse()

        }


        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static void IsInRange()
        {
            Console.WriteLine("Please enter a number:");
            var canParse = int.TryParse(Console.ReadLine(), out int UserNumber);


            while (!canParse)
            {
                Console.WriteLine("Pleas enter a valid number:");
                canParse = int.TryParse(Console.ReadLine(), out UserNumber);

            }

            if (UserNumber <= 10 && UserNumber >= -10)
            {
                Console.WriteLine($"{UserNumber} Is in range!");
            }
            else
            {
                Console.WriteLine($"{UserNumber} Is not in range.");
            }

        }




        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"


        public static void MultiplicationTable(int Number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {Number} = {i * Number}");
            }
        }







        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.


        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //UpThree();
            //AreNumsEqual(5,7);
            //EvanOrOdd(2);
            //IsPosOrNeg(0);
            //CanVote();
            //IsInRange();
            MultiplicationTable(10);

        }
    }
}



            

           