string challenge(string str)
{
	string res = string.Empty;
	for (int i = str[0]; i <= str[1]; i++)
	{
		res += (char)i;
	}
	return res;
}
Console.WriteLine(challenge("nz"));
