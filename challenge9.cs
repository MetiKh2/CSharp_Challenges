bool challenge(object a,object b)
{
	return a.Equals(b);
}

Console.WriteLine(challenge("a", "b")	); 
Console.WriteLine(challenge("a", "a")); 
Console.WriteLine(challenge("1", 1)); 
Console.WriteLine(challenge(2, 2)); 
