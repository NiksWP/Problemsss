string input = Console.ReadLine();
Stack<char> stack = new Stack<char>(input);
foreach (var item in stack)
{
    Console.Write(item);
}