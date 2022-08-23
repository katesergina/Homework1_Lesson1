Console.WriteLine("Введите первое число:"); 
int a = int.Parse(Console.ReadLine()); 
 
Console.WriteLine("Введите второе число:"); 
int b = int.Parse(Console.ReadLine()); 
 
int min = 0; 
int max = 0; 
 
if (a < b) { 
    min = a; 
    max = b; 
} else if (b < a) { 
    min = b; 
    max = a; 
} 
 
if (min != max) { 
    Console.WriteLine("Минимальное число " + min); 
    Console.WriteLine("Максимальное число " + max); 
} else { 
    Console.WriteLine("Числа равны"); 
}
