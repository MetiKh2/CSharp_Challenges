int[] nums = { 1, 3, -2, -4, -6, -3, 11, 10, 19 };

nums.Where(x=>x>0).ToList().ForEach(x=>Console.WriteLine(x));


