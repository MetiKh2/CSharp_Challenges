

void challenge(uint number)
{
	while (number > 0)
	{
		if (number % 10 == 3)
		{
			Console.WriteLine(true);
			return;
		}
		number /= 10;
	}
	Console.WriteLine(false);

}
challenge(10);
challenge(123);
