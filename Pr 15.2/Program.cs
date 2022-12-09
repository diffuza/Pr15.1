string s1 = "Hello, World!"; //объявление строки s1;
// Поиск первого вхождения символа 'r' 
Console.WriteLine("Index of \'r\': " + s1.IndexOf('r')); // вывод на экран строки с указанным значением
// Поиск первого вхождения символа 'l' начиная с позиции 4 
Console.WriteLine("Index of \'l\', start at 4: " + s1.IndexOf('l', 4)); // вывод на экран строки с указанным значением
// Поиск первого вхождения строки "World" 
Console.WriteLine("Index of \"World\": " + s1.IndexOf("World")); // вывод на экран строки с указанным значением
// Поиск первого вхождения символа из набора ['o', 'd', ','] 
Console.WriteLine("Index of pos of any symbol in array: " + s1.IndexOfAny(new char[] { 'o', 'd', ',' })); // вывод на экран строки с указанным значением
// Поиск последнего вхождения символа 'l'  
Console.WriteLine("Last index of \'l\': " + s1.LastIndexOf('l')); // вывод на экран строки с указанным значением
// Поиск последнего вхождения строки "or"
Console.WriteLine("Last index of \"or\": " + s1.LastIndexOf("or")); // вывод на экран строки с указанным значением
// Поиск последнего вхождения символа из набора ['o', 'd', ',']
Console.WriteLine("Last index of pos of any symbol in array: " + s1.LastIndexOfAny(new char[] { 'o', 'd', ',' })); // вывод на экран строки с указанным значением
