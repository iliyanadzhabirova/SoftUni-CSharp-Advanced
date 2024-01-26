﻿    char[] sequence = Console.ReadLine().ToCharArray();

    if (sequence.Length % 2 != 0)
    {
        Console.WriteLine("NO");
        return;
    }

     Stack <char> charStack = new();

    foreach (char c in sequence)
    {
        if ("{[(".Contains(c))
        {
            charStack.Push(c);
        }
        else if (c == ')' && charStack.Peek() == '(')
        {
            charStack.Pop();
        }
        else if (c == ']' && charStack.Peek() == '[')
        {
            charStack.Pop();
        }
        else if (c == '}' && charStack.Peek() == '{')
        {
            charStack.Pop();    
        }
    }
    Console.WriteLine(charStack.Any() ? "NO" : "YES" );