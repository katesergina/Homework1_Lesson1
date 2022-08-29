Console.WriteLine("Enter a day number:"); 
int n = int.Parse(Console.ReadLine()); 
 
if (n < 1 || n > 7) { 
    Console.WriteLine("Нет такого дня недели :-)"); 
    Environment.Exit(1); 
} 
 
Console.WriteLine(n >= 6 ? "Да" : "Нет");
