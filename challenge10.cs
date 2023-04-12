int challenge(int voltage,int current)
{
	int res = voltage * current;
	return res < 5000 ? res : 0;
}

Console.WriteLine(challenge(230,10));
Console.WriteLine(challenge(430, 10)); 
Console.WriteLine(challenge(930,10));
