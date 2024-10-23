int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(nums);

string input;
while ((input = Console.ReadLine()) != "end")
{
	input = input.ToLower();
	string[] tokens = input.Split().ToArray();
	string command = tokens[0];

	if (command == "add")
	{
		int firstNum = int.Parse(tokens[1]);
		int secondNum = int.Parse(tokens[2]);
		stack.Push(firstNum);
		stack.Push(secondNum);
	}
	else if (command == "remove")
	{
		int numsToRemove = int.Parse(tokens[1]);
		if (stack.Count >= numsToRemove)
		{
			for (int i = 0; i < numsToRemove; i++)
			{
				stack.Pop();
			}
		}
	}
}

Console.WriteLine(stack.Sum());