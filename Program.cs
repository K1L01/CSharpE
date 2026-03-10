using System.Globalization;
using System.IO.Pipelines;
using System.Transactions;

public class Exercise1
{
    public static void MainExercise1()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Kristiyan Ivanov!");
    }
}
public class Exercise2
{
    public static void MainExercise2()
    {
        Console.WriteLine(15+17);
    }
}
public class Exercise3
{
    public static void MainExercise3()
    {
        Console.WriteLine(169/13);
    }
}
public class Exercise4
{
    public static void MainExercise4()
    {
        int res1 = -1 + 4 * 6;
        int res2 = (35+ 5)% 7;
        int res3 = 14+ -4*6/11;
        int res4 = 2 + 15/6 * 1 - 7 % 2;
        Console.WriteLine($"{res1}\n{res2}\n{res3}\n{res4}");
    }
}
public class Exercise5
{
    public static void MainExercise5()
    {
        int number1, number2, temp;
        
        Console.Write("Input the First Number: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Input the Second Number: ");
        number2 = int.Parse(Console.ReadLine());
        
        temp = number1;
        number1 = number2;
        number2 = temp;
        Console.Write("After Swapping");
        Console.Write($"\nFirst Number is: {number1}");
        Console.Write($"\nSecond Number is: {number2}");
        
        Console.Read(); //Keep the console open till key is pressed.
    }
}
public class Exercise6
{
    public static void MainExercise6()
    {
        int num1,num2,num3,result; 
        Console.Write("\nInput Number#1 for multiply: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Number#2 for multiply: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Number#3 for multiply: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        result = num1 * num2 * num3;
        Console.Write($"The Result: {num1} x {num2} x {num3} = {result}");
        Console.Read(); // zzz
        Console.Read(); // Testing purposes
    }
}
public class Exercise7
{
    public static void Main()
    {
        
    }
}