/*
 * Write a program and ask the user to enter a few numbers separated by a hyphen. 
 * If the user simply presses Enter, without supplying an input, exit immediately; 
 * otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
 */
Console.Write("Enter numbers separated by hyphen: ");
var input = Console.ReadLine();
if (input.Length == 0)
{
    Console.WriteLine("Invalid input");
    return;
}
else
{
    var numbers = input.Split("-").Select(int.Parse).ToArray();
    for (var i = 0; i < numbers.Length - 1; i++)
    {
        if (numbers[i] == numbers[i+1])
        {
            Console.WriteLine("Duplicate");
            return;
        }
    }
}