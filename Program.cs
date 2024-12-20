namespace AlphabetChecker
{
    internal class Program
    {

        static bool IsDigit(char c)
        {
            return c >= '0' && c <= '9';
        }

        static bool IsLetterInFirstRange(char c)
        {
            return c >= 'A' && c <= 'E';
        }

        static bool IsLetterInSecondRange(char c)
        {
            return c >= 'F' && c <= 'Z';
        }


        static bool IsLineValid(string? str)
        {
            int StringLength = str.Length;

            if (String.IsNullOrEmpty(str) || str[0] != 'A')
            {
                return false;
            }

            int i;

            for(i = 0; i < StringLength; i++)
            {
                char charr = str[i];
                if (charr == '_')
                {
                    if (str[i] == '_')
                    {
                        if (IsLetterInFirstRange(str[i - 1]) && IsLetterInSecondRange(str[i + 1]) || IsDigit(str[i + 1]))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (str[i] != '_')
                    {
                        return true;
                    }
                    break;
                }
                else
                {
                    continue;
                }
            }



            return true;
        }


        static void Main(string[] args)
        {
            string UserInputString;
            Console.Write("Write a phrase: ");
            UserInputString = Console.ReadLine();
            Console.WriteLine();
            if(IsLineValid(UserInputString))
            {
                Console.WriteLine("Line is Valid");
            }
            else
            {
                Console.WriteLine("Line is Invalid");
            }
        }
    }
}
