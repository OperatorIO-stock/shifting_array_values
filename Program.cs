namespace shifting_array_values;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        int lastIndex = numbers.Length - 1;
        int number = 0;

        int tempNumbers;

        string userResponse;

        for (int i = 0; i < numbers.Length; i++)
        {
            number++;
            numbers[i] = number;

            Console.Write($"{numbers[i]} ");
        }
        
        Console.WriteLine("\n");

        userResponse = Console.ReadLine();

        if (int.TryParse(userResponse, out int countLeftShift))
        {
            for (int i = 0; i < countLeftShift; i++)
                for (int j = 0; j < lastIndex; j++)
                {
                    tempNumbers = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tempNumbers;
                }
        }

        else
            { Console.WriteLine("That's not number!"); }

        Console.Write(string.Join(" ", numbers));
    }
}
