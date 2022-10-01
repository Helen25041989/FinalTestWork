string[] massiv = new string[]{"hello","qwerty","2",":-("};

Console.WriteLine("Исходный массив= {0}", string.Join(", ",massiv));

string [] result = massiv.Where(x => x.Length <= 3).ToArray();

Console.WriteLine("Результирущий массив= {0}", string.Join(", ", result));


