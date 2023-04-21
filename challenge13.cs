List <string> animals = new List<string>() {
"zebra",
"elephant",
"cat",
"dog",
"rhino",
"bat"
};
animals
	.Where(x => x.Length >= 5)
	.Select(x => x.ToUpper())
	.ToList()
	.ForEach(animal => Console.WriteLine(animal));


