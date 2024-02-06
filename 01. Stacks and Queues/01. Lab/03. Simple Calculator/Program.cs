string[] input = Console.ReadLine().Split();
Stack<string> expression = new Stack<string>(new Stack<string>(input));


while (expression.Count > 1)
{
    int leftNumber = int.Parse(expression.Pop());
    string sign = expression.Pop();
    int rightNumber = int.Parse(expression.Pop());

    if (sign == "+")
    {
        expression.Push((leftNumber + rightNumber).ToString());
    }
    else if (sign == "-")
    {
        expression.Push((leftNumber - rightNumber).ToString());
    }
}

Console.WriteLine(expression.Pop());