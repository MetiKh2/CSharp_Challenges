int challenge(int number)//13
{
	int sum = 0;
	number.ToString()
		.ToCharArray()
		.ToList()//{'1','3'}
		.ForEach(digit => sum += int.Parse(digit.ToString()));
	return sum;
}

Console.WriteLine(challenge(13));//4
Console.WriteLine(challenge(9));//9
Console.WriteLine(challenge(134));//8
