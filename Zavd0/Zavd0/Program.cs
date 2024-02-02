using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть перше число:");
     
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
 
        double num2 = Convert.ToDouble(Console.ReadLine());
      
        double sum = num1 + num2;
        
        Console.WriteLine($"Сума чисел {num1} та {num2} дорівнює {sum}");

        Console.ReadLine();
    }
}
