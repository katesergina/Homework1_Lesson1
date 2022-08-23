Console.WriteLine("Введите число:");  
int A = int.Parse(Console.ReadLine());  
 
string s = ""; 
for (int i = 1; i <= A; i++)
{ 
    if (i % 2 == 0)
    { 
        if (s.Length > 0)
        { 
            s += ", "; 
        } 
        s += i; 
    } 
} 
Console.WriteLine(s);
