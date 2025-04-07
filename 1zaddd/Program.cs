namespace _1zaddd
{ }
class Program
{
    static void Main()
    {

        Console.WriteLine("Въведете списък от числа, разделени с интервал:");
        string input = Console.ReadLine();


        string[] inputArray = input.Split(' ');
        List<int> numbers = new List<int>();

        foreach (string str in inputArray)
        {
            if (int.TryParse(str, out int num))
            {
                numbers.Add(num);
            }
        }


        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);


        Console.WriteLine("Уникални числа:");
        foreach (var num in uniqueNumbers)
        {
            Console.Write(num + " ");
        }
    }
}


