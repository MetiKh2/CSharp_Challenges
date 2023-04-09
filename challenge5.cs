string[] challenge(object[] arr)
{
	return Array.ConvertAll(arr, (x) => x.ToString());
}

var arr = new object[] {1,2,3,"abc",'c' };

challenge(arr).ToList().ForEach(x=>Console.WriteLine(x));
