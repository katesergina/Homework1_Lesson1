Console.WriteLine("Enter the number:"); 
string n = int.Parse(Console.ReadLine()).ToString(); 
 
if (n.Length >=3) { 
    Console.WriteLine(n[2]); 
} else { 
    Console.WriteLine("третьей цифры нет"); 
}
