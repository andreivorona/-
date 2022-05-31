namespace FindPassword
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.WriteLine("Please type 3 digits on the each line 5 times");

            int firstDigit = int.MinValue;
            int secondDigit = int.MinValue;
            int thirdDigit = int.MinValue;

            for (int i = 0; i <= 4; i++)
            {
                char[] digitLine = Console.ReadLine().ToCharArray();
                
                //one digit is correct and is correct place
                if (i == 0)
                {
                    thirdDigit = digitLine[2];
                }

                //one digit is correct and is incorrect place
                if (i == 1)
                {
                    secondDigit = digitLine[2];
                }

                //two didits is correct and is incorrect places
                if (i == 2)
                {
                    firstDigit = digitLine[1];
                    thirdDigit = digitLine[0];
                }

                //all is incorrect
                if (i == 3)
                {
                    continue;
                }

                //one digit is correct and is incorrect place
                if (i == 4)
                {
                    firstDigit = digitLine[2];
                }
            }

            Console.WriteLine($"Password is: {(char)firstDigit}{(char)secondDigit}{(char)thirdDigit}");
        }
    }
}
