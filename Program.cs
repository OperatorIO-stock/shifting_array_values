namespace shifting_array_values;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        int number = 0;

        int countLeftShift = 0;

        string userResponse;

        bool isProgramWorking;

        for (int i = 0; i < numbers.Length; i++)
        {
            number++;
            numbers[i] = number;

            Console.Write($"{numbers[i]} ");
        }

        isProgramWorking = true;

        while(isProgramWorking)
        {
            userResponse = Console.ReadLine();

            if (int.TryParse(userResponse, out countLeftShift))
            {

            }
            else
                { Console.WriteLine("That's not number!"); }

        }
        
    }
}
