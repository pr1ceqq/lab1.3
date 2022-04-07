

/*
- First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault (поелементні операції)
- Count, Sum, Average, Max, Min, Aggregate (агрегування); • Range (генерування послідовностей).
*/
/*
 Дано символ С і строкова послідовність A. 
Якщо A містить єдиний елемент, що закінчується символом C, то вивести цей елемент; 
якщо необхідних рядків в A немає, то вивести порожній рядок; 
якщо необхідних рядків більше одного, то вивести рядок «Error». 
Використовувати try-блок для перехоплення можливого виключення. (1)
*/
try
{
    IEnumerable<int> numbers = Enumerable.Range(1, 6).Select(x => x + 3 * x);
    foreach (int num in numbers)
    {
        Console.WriteLine(num);
    }
    Console.WriteLine("Введіть символ С");
    char c = char.Parse(Console.ReadLine());
    string[] a = numbers.Select(i => i.ToString()).ToArray();
    Console.WriteLine();
    if (a.SingleOrDefault(number => number.EndsWith(c)) == null)
    {
        Console.WriteLine("пустий рядок");
    }
    else
    Console.WriteLine(a.SingleOrDefault(number => number.EndsWith(c)));
    
}
catch (InvalidOperationException)
{
    Console.WriteLine("Error");
}

