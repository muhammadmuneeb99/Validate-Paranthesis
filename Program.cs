// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


bool isValid(string brackets)
{
	Stack<char> paranthesis = new();
	foreach (char c in brackets)
	{
		switch (c)
		{
			case '{':
				paranthesis.Push('}');
				break;
			case '(':
				paranthesis.Push(')');
				break;
			case '[':
				paranthesis.Push(']');
				break;
			case '<':
				paranthesis.Push('>');
				break;
			case '}':
			case ')':
			case ']':
			case '>':
				if (paranthesis.Count == 0) return false;
				if (paranthesis.Pop() != c) return false;
				break;
		}
	}
	return paranthesis.Count == 0;
}

Console.WriteLine(isValid("[]{}()"));
Console.WriteLine(isValid("[}[}()"));
Console.WriteLine(isValid("[}{](]"));
Console.WriteLine(isValid("{]{}[)"));
Console.WriteLine(isValid("{[()]}"));
Console.ReadLine();
