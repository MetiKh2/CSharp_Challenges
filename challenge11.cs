int challenge(int[] arr,int num)
{
	int count = default;//0
	for (int i = 0; i < arr.Length-1; i++)
	{
		if (arr[i] == num && arr[i + 1] == num)
		{
			count++;
		}
	}
	return count;
}
Console.WriteLine(challenge(new int[] { 7, 7, 1, 3, 5, 6, 9 }, 7)); //1
Console.WriteLine(challenge(new int[] { 1, 3, 5, 6, 7, 9 }, 7)); //0
Console.WriteLine(challenge(new int[] { 7, 7, 1, 3, 5, 6, 7, 7, 9 }, 7)); //2
