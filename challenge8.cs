void challenge(object[] arr)
{
	double sum = 0.0;
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] is double)
		{
			sum += (double)arr[i];
		}
	}
	Console.WriteLine(sum);
}

challenge(new object[] {5.1,'a',"hello",true,11,3.2});
