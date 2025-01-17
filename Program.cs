namespace shifting_array_values;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[4];
        int length = numbers.Length;
        int firstElement = numbers[0];

        string userResponse;

        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
            Console.Write($"{numbers[i]} ");
        }
        
        Console.WriteLine("\n");

        userResponse = Console.ReadLine();

        if (int.TryParse(userResponse, out int countLeftShift))
        {
            countLeftShift %= length;
            
            for (int i = 0; i < countLeftShift; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[length - 1] = firstElement;
            }
        }
        else
            Console.WriteLine("That's not number!");

        Console.Write(string.Join(" ", numbers));
    }
}
