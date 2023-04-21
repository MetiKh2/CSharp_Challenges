bool challenge(int[]arr)
{
	return arr[0] <= arr[1] && arr[1] <= arr[2];
}

Console.WriteLine(challenge(new int[] {1,4,10}));//true
Console.WriteLine(challenge(new int[] {1,14,10 }));//false

 

