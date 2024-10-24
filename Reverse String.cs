string input = Console.ReadLine();
Stack<char> stack = new Stack<char>(input);
int a = 5;
foreach (var item in stack)
{
    Console.Write(item);
}