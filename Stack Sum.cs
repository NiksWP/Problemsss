int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(nums);

string input;
while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] tokens = input.Split();
    string command = tokens[0];

    if (command == "add")
    {
        for (int i = 1; i < tokens.Length; i++)
        {
            stack.Push(int.Parse(tokens[i]));
        }
    }
    else
    {
        int numsToRemove = int.Parse(tokens[1]);
        if (numsToRemove > stack.Count)
        {
            continue;
        }
        else
        {
            for (int i = 0; i < numsToRemove; i++)
            {
                stack.Pop();
            }
        }
    }
}

Console.WriteLine(stack.Sum());