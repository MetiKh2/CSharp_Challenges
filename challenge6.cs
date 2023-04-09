void challenge(int num)
{
	char[] arr = num.ToString().ToCharArray(); //{'1','2','3'}
	Array.Reverse(arr);
	Console.WriteLine(new string (arr)+num.ToString());
}

challenge(123);
