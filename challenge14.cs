int challenge(DateTime date1,DateTime date2)
{
	 return (date2- date1).Days;
}

Console.WriteLine(challenge(new DateTime(2010, 9, 9), DateTime.Now));
 

